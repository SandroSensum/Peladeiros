using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CamadaFormulario.Cadastros
{
    public partial class frmLancamentos : CamadaComponente.frmPadrao
    {
        public frmLancamentos()
        {
            InitializeComponent ();
        }

        private void btnConta_Click( object sender, EventArgs e )
        {
            frmContas oFrmContas = new frmContas ();
            oFrmContas.Show ();
        }
    }
}
