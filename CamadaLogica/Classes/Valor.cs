using CamadaBase;
using CamadaFuncao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogica.Classes
{
    public class Valor : Base
    {
        public DataTable BuscarMesAno( string Referencia )
        {
            StringBuilder sql = new StringBuilder ();
            sql.AppendLine ( "SELECT " );
            sql.AppendLine ( " * FROM VALOR " );            
            if ( !string.IsNullOrEmpty ( Referencia.Replace ( "/", "" ).Trim () ) )
            {
                sql.AppendLine ( "WHERE " );
                sql.AppendLine ( $"DAT_VALOR LIKE '{Referencia}'" );
            }

            return Select ( sql );
        }

        public bool ValidaRef( string Referencia )
        {
            DataTable Valref = BuscarMesAno ( Referencia );
            if ( Valref.Rows.Count > 0 )// conta o numero de linhas na tabela
                return Convert.ToInt32 ( Valref.Rows[0]["COD_VALOR"] ) == 0; //se nao tiver linha retorna false
            else
                return true;// se não é verdadeiro
        }

        public double BuscaValor (int Valor )
        {
            if ( Valor > 0 )
            {
                StringBuilder sql = new StringBuilder ();
                sql.AppendLine ( "SELECT VALOR FROM VALOR " );
                sql.AppendLine ( "WHERE " );
                sql.AppendLine ( $"COD_VALOR ='{Valor}'" );

                DataTable oValor = Select ( sql );
                if ( Funcao.PossuiRegistro ( oValor ) )
                {
                    return Convert.ToDouble(oValor.Rows[0][0]);                   
                }

                
            }

            return 0 ;
        }

    }
}
