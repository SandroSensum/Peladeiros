using CamadaComponente.Formularios;
using CamadaFormulario;
using CamadaFormulario.Cadastros;
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
            frmJogador oFrmJogador = new frmJogador();
            oFrmJogador.Show();
        }

        private void usuariosESenhasToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmUsuario Usuario = new frmUsuario ();
            Usuario.Show ();
        }

        private void btnMensalidades_Click( object sender, EventArgs e )
        {
            frmMensalidades oFrmMesalidades = new frmMensalidades ();
            oFrmMesalidades.Show ();
        }

        private void contasToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmContas oFrmContas = new frmContas ();
            oFrmContas.Show ();
        }

        private void fornecedoresToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmFornecedores oFrmFornecedores = new frmFornecedores ();
            oFrmFornecedores.Show ();
        }

        private void menMensalidades_Click( object sender, EventArgs e )
        {
            frmMensalidades oFrmMensalidades = new frmMensalidades ();
            oFrmMensalidades.Show ();
        }

        private void despesasToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmPagamentos oFrmPagamentos = new frmPagamentos ();
            oFrmPagamentos.Show ();
        }

        private void mesesToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmMeses oFrmMeses = new frmMeses ();
            oFrmMeses.Show ();
        }

        private void toolStripMenuItem1_Click( object sender, EventArgs e )
        {
            frmValores oFrmValores = new frmValores ();
            oFrmValores.Show ();
        }

        private void caixaToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmContaCorrente oFrmContaCorrente = new frmContaCorrente ();
            oFrmContaCorrente.Show ();
        }
    }
}
