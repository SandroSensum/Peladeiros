using CamadaFuncao;
using CamadaLogica.Auxiliar;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Configuracao oConfiguracao = new Configuracao();
            oConfiguracao.CaminhoBanco = txtCaminhoBanco.Text;
            oConfiguracao.Local = radLocal.Checked;
            oConfiguracao.Rede = radRede.Checked;
            oConfiguracao.Senha = txtSenha.Text;
            oConfiguracao.Servidor = txtServidor.Text;
            oConfiguracao.Usuario = txtUsuario.Text;

            oConfiguracao.GravarArquivoConfiguracao(oConfiguracao);
        }

        private void frmConexaoBanco_Load(object sender, EventArgs e)
        {
            CarregarArquivoConfiguracao();
        }

        #endregion

        #region [Métodos]

        private void TestarConexao()
        {
            lblStatus.Text = Funcao.TestarConexao(Funcao.MontarConexao(txtUsuario.Text, txtSenha.Text, txtCaminhoBanco.Text));
        }

        private void CarregarArquivoConfiguracao()
        {
            Configuracao oConfiguracao = new Configuracao().CarregarArquivoConfiguracao();

            if (oConfiguracao != null)
            {
                txtCaminhoBanco.Text = oConfiguracao.CaminhoBanco;
                radLocal.Checked = oConfiguracao.Local;
                radRede.Checked = oConfiguracao.Rede;
                txtSenha.Text = oConfiguracao.Senha;
                txtServidor.Text = oConfiguracao.Servidor;
                txtUsuario.Text = oConfiguracao.Usuario;
            }
        }

        #endregion

      
    }
}
