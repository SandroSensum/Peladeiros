using CamadaComponente.Formularios;
using CamadaFormulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPeladeiros
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void propriedadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConexaoBanco Configura = new frmConexaoBanco();
            Configura.Show();
        }

        private void btJogadores_Click(object sender, EventArgs e)
        {
            frmUsuario oFrmUsuario = new frmUsuario();
            oFrmUsuario.Show();
        }
    }
}
