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
    public partial class frmContas : CamadaComponente.frmPadrao
    {
        public frmContas()
        {
            InitializeComponent ();
        }

        private void dtgPesquisaConta_DoubleClick( object sender, EventArgs e )
        {
            tbcPadrao.SelectedTab = tabPrincipal;
        }

        private void btnPesquisar_Click( object sender, EventArgs e )
        {
            dtsConta1.Clear ();
            Contas oContas = new Contas ();
            dtsConta1.CONTAS.Merge ( oContas.BuscarContas (txtNome.Text,ckAtivos.Checked) );
        }
    }
}
