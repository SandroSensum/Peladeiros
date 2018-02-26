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
    public partial class frmFornecedores : CamadaComponente.frmPadrao
    {
        public frmFornecedores()
        {
            InitializeComponent ();
        }

        private void btnPesquisar_Click( object sender, EventArgs e )
        {
            dtsFornecedor1.Clear ();
            Fornecedores oFornecedor = new Fornecedores ();
            dtsFornecedor1.FORNECEDORES.Merge ( oFornecedor.BuscarFornecedor ( txtNomePesquisa.Text ) );
        }

        private void dataGridView1_DoubleClick( object sender, EventArgs e )
        {
            tbcPadrao.SelectedTab = tabPrincipal;
        }

        private void txtNomePesquisa_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                btnPesquisar.PerformClick ();
        }
    }
}
