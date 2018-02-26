using CamadaComponente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaFormulario
{
    public partial class frmUsuario : frmPadrao
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnInformeNome_Click( object sender, EventArgs e )
        {
            MessageBox.Show ( "Informe o nome para pesquisar um Usuario!" );
        }

        private void btnPesquisar_Click( object sender, EventArgs e )
        {
            dtsUsuarios1.Clear ();
            Usuario ousuario = new Usuario ();
            dtsUsuarios1.USUARIOS.Merge ( ousuario.BuscarUsuarios ( txtNomePesquisa.Text) );
        }

    }
}
