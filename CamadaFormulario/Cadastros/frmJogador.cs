using CamadaComponente;
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

namespace CamadaFormulario.Cadastros
{
    public partial class frmJogador : frmPadrao
    {
        public frmJogador()
        {
            InitializeComponent ();
        }

        private bool frmJogador_ValidarGravar()
        {
            StringBuilder sbMensagem = new StringBuilder ();
            if ( string.IsNullOrWhiteSpace ( txtNome.Text ) )
                sbMensagem.AppendLine ( "- Nome não pode ficar em branco." );
            if(string.IsNullOrWhiteSpace(txtCelular1.Text.Replace("(", "").Replace(")", "").Replace("-", "" ).Trim () ) )
                sbMensagem.AppendLine ( "- Deve ser informado pelo menos um número de celular." );
            if(string.IsNullOrWhiteSpace(txtEmail.Text))
                sbMensagem.AppendLine ( "- Deve ser informada o email." );

            if ( !string.IsNullOrWhiteSpace ( sbMensagem.ToString () ) )
                MessageBox.Show ( sbMensagem.ToString (), "Validação de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Stop );

            return string.IsNullOrWhiteSpace ( sbMensagem.ToString () );
        }

        private void btnPesquisar_Click( object sender, EventArgs e )
        {
            dtsJogador1.Clear ();
            Jogador ojogador = new Jogador ();
            dtsJogador1.JOGADOR.Merge ( ojogador.BuscarJogadores (txtNomePesquisa.Text,ckAtivos.Checked) );
        }

        private void dtgResultpesquisa_DoubleClick( object sender, EventArgs e )
        {
            tbcPadrao.SelectedTab = tabPrincipal;
        }

        private void btnInformeNome_Click( object sender, EventArgs e )
        {
            MessageBox.Show ( "Informe o nome para pesquisar um jogador!" );
        }

        private void btnInformeInativo_Click( object sender, EventArgs e )
        {
            MessageBox.Show ( "Marque para listar os jogadores inativos!" );
        }

        private void txtNomePesquisa_KeyPress( object sender, KeyPressEventArgs e )
        {
            //if (e.KeyChar = )
            //btnPesquisar.PerformClick ();
        }

        private void txtNomePesquisa_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                btnPesquisar.PerformClick ();
        }
    }
}
