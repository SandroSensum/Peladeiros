using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaComponente.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            frmConexaoBanco ofrmconexao = new frmConexaoBanco();
            ofrmconexao.ShowDialog();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "ADMIN" && txtSenha.Text == "ADMIN")
            {
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Usuario ou senha invalidos");
        }       
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
