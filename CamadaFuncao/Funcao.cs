using FirebirdSql.Data.FirebirdClient;
using System;
using System.Text;
using System.Windows.Forms;

namespace CamadaFuncao
{
    public static class Funcao
    {
        #region [Métodos]

        /// <summary>
        /// Localiza um arquivo abrindo a tela para escolher
        /// </summary>
        /// <returns></returns>
        public static string LocalizarArquivo()
        {
            OpenFileDialog oFileDialog = new OpenFileDialog();

            if (oFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return oFileDialog.FileName;
            }

            return "";
        }

        /// <summary>
        /// Monta a string de conexão com o banco
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <param name="pSenha"></param>
        /// <param name="pBanco"></param>
        /// <param name="pServidor"></param>
        /// <param name="pPorta"></param>
        /// <returns></returns>
        public static string MontarConexao(string pUsuario, string pSenha, string pBanco, string pServidor = "localhost", string pPorta = "3050")
        {
            StringBuilder sbConexao = new StringBuilder();

            sbConexao.Append($"User={pUsuario.ToUpper()};");
            sbConexao.Append($"Password={pSenha.ToLower()};");
            sbConexao.Append($"Database={pBanco};");
            sbConexao.Append($"DataSource={pServidor};");
            sbConexao.Append($"Port={pPorta};");
            sbConexao.Append("Dialect=3;");
            sbConexao.Append("Charset=NONE;");
            sbConexao.Append("Role=;");
            sbConexao.Append("Connection lifetime=15;");
            sbConexao.Append("Pooling=true;");
            sbConexao.Append("Packet Size=8192;");
            sbConexao.Append("Client Library=gds32.dll;");
            sbConexao.Append("ServerType=0");

            return sbConexao.ToString();
        }

        /// <summary>
        /// Testa a conexão com o banco
        /// </summary>
        /// <returns></returns>
        public static string TestarConexao(string pConexao)
        {
            FbConnection oConexao = new FbConnection(pConexao);
            string sMensagem = "";
            try
            {
                oConexao.Open();
                sMensagem = "Conexão bem sucedida";
            }
            catch (Exception ex)
            {
                sMensagem = "Ocorreu uma anomalia: \n" + ex.Message;
            }

            return sMensagem;
        }

        #endregion
    }
}
