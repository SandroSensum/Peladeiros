using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaBanco
{
    public class AcessoBanco
    {
        #region Atributos

        private FbConnection oConexao;

        #endregion

        #region Metodos
        public void Atualizar(DataTable pTabela)
        {
            List<FbCommand> oListaComando = new List<FbCommand>();

            if (pTabela != null)
            {
                foreach (DataRow linha in pTabela.Rows)
                {
                    if (linha.RowState == DataRowState.Added)
                        oListaComando.Add(ComandoInsert(linha));
                    else if (linha.RowState == DataRowState.Modified)
                        oListaComando.Add(ComandoAlterar(linha));
                    else if (linha.RowState == DataRowState.Deleted)
                        oListaComando.Add(ComandoExcluir(linha));
                }

                Executar(oListaComando);
            }
        }

        private void Executar(List<FbCommand> pLista)
        {
            AbrirConexao();

            foreach (FbCommand comando in pLista)
            {
                comando.Connection = oConexao;

                comando.ExecuteNonQuery();
            }
        }

        private FbCommand ComandoInsert(DataRow linha)
        {
            StringBuilder Colunas = new StringBuilder();
            StringBuilder ValoresString = new StringBuilder();
            List<FbParameter> Valores = new List<FbParameter>();
            FbCommand oComando = new FbCommand();
            FbParameter oParametro = null;

            foreach (DataColumn coluna in linha.Table.Columns)
            {
                if (!coluna.ColumnName.StartsWith("LKP_"))
                {
                    Colunas.Append(coluna.ColumnName).Append(",");
                    oParametro = new FbParameter("@" + coluna.ColumnName, linha[coluna]);
                    oComando.Parameters.Add("@" + coluna.ColumnName, linha[coluna]);
                    //Valores.Add(oParametro);
                    ValoresString.Append("@" + coluna.ColumnName).Append(",");
                }
            }

            Colunas = Colunas.Remove(Colunas.Length - 1, 1);
            ValoresString = ValoresString.Remove(ValoresString.Length - 1, 1);
            oComando.CommandText = "INSERT INTO " + linha.Table.TableName + "( " + Colunas.ToString() + ")" + "VALUES (" + ValoresString.ToString() + ")";

            return oComando;
        }
        private FbCommand ComandoAlterar(DataRow linha)
        {
            StringBuilder Colunas = new StringBuilder();
            StringBuilder ValoresString = new StringBuilder();
            List<FbParameter> Valores = new List<FbParameter>();
            FbCommand oComando = new FbCommand();
            FbParameter oParametro = null;
            int iChavePrimaria = Convert.ToInt32(linha[linha.Table.PrimaryKey[0]]);

            foreach (DataColumn coluna in linha.Table.Columns)
            {
                if (!coluna.ColumnName.StartsWith("LKP_"))
                {
                    Colunas.Append(coluna.ColumnName).Append("=").Append("@" + coluna.ColumnName).Append(",");
                    oParametro = new FbParameter("@" + coluna.ColumnName, linha[coluna]);
                    oComando.Parameters.Add("@" + coluna.ColumnName, linha[coluna]);
                }
            }

            Colunas = Colunas.Remove(Colunas.Length - 1, 1);
            oComando.CommandText = "UPDATE " + linha.Table.TableName + " SET " + Colunas.ToString() + " WHERE " + linha.Table.PrimaryKey[0].ColumnName + " = " + iChavePrimaria;

            return oComando;
        }
        private FbCommand ComandoExcluir(DataRow linha)
        {
            StringBuilder Colunas = new StringBuilder();
            StringBuilder ValoresString = new StringBuilder();
            List<FbParameter> Valores = new List<FbParameter>();
            FbCommand oComando = new FbCommand();
            FbParameter oParametro = null;
            int iChavePrimaria = Convert.ToInt32(linha[linha.Table.PrimaryKey[0], DataRowVersion.Original]);

            oParametro = new FbParameter("@" + linha.Table.PrimaryKey[0], iChavePrimaria);
            oComando.Parameters.Add("@" + linha.Table.PrimaryKey[0], iChavePrimaria);

            oComando.CommandText = "DELETE FROM " + linha.Table.TableName + " WHERE " + linha.Table.PrimaryKey[0].ColumnName + " = " + iChavePrimaria;

            return oComando;
        }

        public DataTable Select(string pSbql)
        {
            AbrirConexao();

            DataTable dtbResultado = new DataTable();

            FbCommand oComando = new FbCommand(pSbql, oConexao);

            FbDataReader oDataReader = oComando.ExecuteReader();

            dtbResultado.Load(oDataReader);

            return dtbResultado;
        }

        private FbConnection AbrirConexao()
        {
            //oConexao = new FbConnection(MontarConexao());

            oConexao.Open();

            return oConexao;
        }
        #endregion
    }
}
