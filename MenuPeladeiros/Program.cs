using CamadaComponente.Formularios;
using CamadaFormulario.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            Application.Run ( new frm_Principal () );

            //frmLogin oFrmLogin = new frmLogin();

            //if (oFrmLogin.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new frm_Principal());

            //}
        }
    }
}
