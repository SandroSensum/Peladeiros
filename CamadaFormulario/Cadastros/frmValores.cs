using CamadaFuncao.Classes;
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
    public partial class frmValores : CamadaComponente.frmPadrao
    {
        public frmValores()
        {
            InitializeComponent ();
        }

        private void btnPesquisar_Click( object sender, EventArgs e )
        {
            dtsValor1.Clear ();
            Valor oMesAno = new Valor ();
            dtsValor1.VALOR.Merge ( oMesAno.BuscarMesAno ( txtReferencia.Text) );
        }

        private void dataGridView1_DoubleClick( object sender, EventArgs e )
        {
            tbcPadrao.SelectedTab = tabPrincipal;
        }

        private void txtReferencia_Leave( object sender, EventArgs e )
        {
            //dtsValor1.Clear ();
            //Valor oRef = new Valor ();
            //dtsValor1.VALOR.Merge ( oRef.Buscarvalref ( txtReferencia.Text ) );
        }
    }
}
