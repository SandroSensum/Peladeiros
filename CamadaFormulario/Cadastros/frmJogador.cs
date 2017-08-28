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

namespace CamadaFormulario.Cadastros
{
    public partial class frmJogador : frmPadrao
    {
        public frmJogador()
        {
            InitializeComponent();
        }

        private void frmJogador_Load(object sender, EventArgs e)
        {

        }

        private bool frmJogador_ValidarGravar()
        {
            MessageBox.Show("foi validado, deu bom");
            return true;
        }

        private void frmJogador_AntesDeGravar()
        {
            MessageBox.Show("cHEGOU AQUI!");
        }
    }
}
