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

        private void ckBanco_CheckedChanged( object sender, EventArgs e )
        {
            //if ( ckBanco.Checked )
            //    gpBanco.Enabled = true;
            //else
            //    gpBanco.Enabled = false;
            gpBanco.Enabled = ckBanco.Checked; // esta linha faz o mesmo "if" de cima
        }

        private void frmContas_Load( object sender, EventArgs e )
        {
            gpBanco.Enabled = ckBanco.Checked; // esta linha faz o mesmo "if" de cima
        }

        private void txtContaPesquisa_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                btnPesquisar.PerformClick ();
        }

        private void btnPesquisar_Click( object sender, EventArgs e )
        {
            dtsConta1.Clear ();
            Contas oConta = new Contas ();
            dtsConta1.CONTAS.Merge ( oConta.BuscarContas( txtContaPesquisa.Text,ckAtivos.Checked ) );
        }
    }
}
