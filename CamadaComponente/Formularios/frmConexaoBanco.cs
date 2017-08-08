using CamadaFuncao;
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
    public partial class frmConexaoBanco : Form
    {
        #region [Construtor]


        public frmConexaoBanco()
        {
            InitializeComponent();
        }

        #endregion

        #region [Eventos]

        
        private void button1_Click(object sender, EventArgs e)
        {
           txtCaminhoBanco.Text = Funcao.LocalizarArquivo();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            TestarConexao();
        }

        #endregion

        #region [Métodos]

        private void TestarConexao()
        {
            lblStatus.Text = Funcao.TestarConexao(Funcao.MontarConexao(txtUsuario.Text, txtSenha.Text, txtCaminhoBanco.Text));
        }

        #endregion


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
