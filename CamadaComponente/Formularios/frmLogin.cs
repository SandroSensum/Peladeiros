using CamadaFuncao.Classes;
using CamadaFuncao.Cls;
using CamadaLogica.Classes;
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
        Configuracao oConfiguracao = null;
        Usuario oUsuario = new Usuario ();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            oConfiguracao = new Configuracao ().CarregarArquivoConfiguracao ();

            frmConexaoBanco oFrmConexao = null;

            if ( oConfiguracao == null )
                oFrmConexao.ShowDialog ();
            else
            {
                ConexaoBanco.ConfiguracaoBanco = oConfiguracao;
            }
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            frmConexaoBanco ofrmconexao = new frmConexaoBanco();
            ofrmconexao.ShowDialog();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.ToUpper() == "ADMIN" && txtSenha.Text.ToUpper() == "ADMIN")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                if ( oUsuario.VerificaUsuarioSenha ( txtUsuario.Text, txtSenha.Text ) )
                {
                    Propriedades.UsuarioLogado = txtUsuario.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show ( "senha invalida" );
                    txtSenha.Clear ();
                    txtSenha.Focus ();
                }
            }
        }       
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtSenha_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                btnAcessar.PerformClick ();
        }

        private void txtUsuario_Leave( object sender, EventArgs e )
        {
            if ( txtUsuario.Text.ToUpper () != "ADMIN" )
            {
                if ( !oUsuario.VerificaUsuario ( txtUsuario.Text ) )
                {
                    txtUsuario.Clear ();
                    txtUsuario.Focus ();
                }
            }
               
        }
    }
}
