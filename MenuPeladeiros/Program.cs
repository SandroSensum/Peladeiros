using CamadaComponente.Formularios;
using CamadaFuncao.Cls;
using System;
using System.Windows.Forms;

namespace MenuPeladeiros
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());  
            //ConexaoBanco.ConfiguracaoBanco = new Configuracao ().CarregarArquivoConfiguracao ();

            //Application.Run ( new frm_Principal () );

            frmLogin oFrmLogin = new frmLogin ();

            if ( oFrmLogin.ShowDialog () == DialogResult.OK )
            {
                Application.Run ( new frm_Principal () );
                
            }
        }
    }
}
