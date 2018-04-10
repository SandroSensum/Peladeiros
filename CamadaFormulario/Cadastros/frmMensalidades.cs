using CamadaLogica.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CamadaFormulario.Cadastros
{
    public partial class frmMensalidades : CamadaComponente.frmPadrao
    {
        public frmMensalidades()
        {
            InitializeComponent ();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            frmJogador oFrmJogador = new frmJogador ();
            oFrmJogador.Show ();
        }

        private void frmMensalidades_Load( object sender, EventArgs e )
        {
            CarregarCombos ();
        }

        private void CarregarCombos()
        {
            Valor oValorCombo = new Valor ();
            cboBuscaValor.DataSource = oValorCombo.BuscarMesAno ( "" );      // cboBuscaValor --> 'nome do combo no formulario' .DataSource --> 'inforação que será apresentada no combo' = oValorCombo --> 'variavel criada' .BuscarMesAno --> "Metodo para buscar as informações' ( "" );      
            cboBuscaValor.DisplayMember = "DAT_VALOR";
            cboBuscaValor.ValueMember = "COD_VALOR";

            Jogador oJogadorCombo = new Jogador ();
            cboJogador.DataSource = oJogadorCombo.BuscarJogadores ( "",false );
            cboJogador.DisplayMember = "NOM_JOGADOR";
            cboJogador.ValueMember = "COD_JOGADOR";
        }

        private void CarregarValor()
        {
            Valor oValortxt = new Valor ();
            txtValor.Text = oValortxt.BuscaValor ( Convert.ToInt32 ( cboBuscaValor.SelectedValue ) ).ToString ();
        }

        private void cboBuscaValor_Leave( object sender, EventArgs e )
        {
            CarregarValor ();
        }
    }
}
