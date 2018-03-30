using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaComponente.Componentes
{
    public partial class cpAtivoInativo : UserControl
    {
        public cpAtivoInativo()
        {
            InitializeComponent ();
        }
        [Description ( "bso que contem o campo inativo" ), Category ( "Peladeiros" ), DefaultValue ( null )]
        public scBso bsoAtivoInativo { get; set; }

        [Description ( "Nome do campo Inativo" ), Category ( "Peladeiros" ), DefaultValue ( null )]
        public string NomeCampo { get; set; }

        private void rbInativo_CheckedChanged( object sender, EventArgs e )
        {
            if ( !DesignMode )
            {
                if ( rbInativo.Checked )
                {
                    bsoAtivoInativo.Linha[NomeCampo] = DateTime.Now;
                }
                else
                {
                    bsoAtivoInativo.Linha[NomeCampo] = DBNull.Value;
                }
            }
        }

        private void cpAtivoInativo_Load( object sender, EventArgs e )
        {
            if ( !DesignMode )
            {
                this.txtDesativado.DataBindings.Add ( new Binding ( "Text", this.bsoAtivoInativo, NomeCampo, true ) );
                VerificarAtivoInativo ();
            }
        }

        public void VerificarAtivoInativo()
        {
            if ( !DesignMode )
            {
                if ( bsoAtivoInativo.Linha != null && bsoAtivoInativo.Linha[NomeCampo] != DBNull.Value )
                {
                    if ( Convert.ToDateTime ( bsoAtivoInativo.Linha[NomeCampo] ) == new DateTime () )
                        rbAtivo.Checked = true;
                    else
                        rbInativo.Checked = true;
                }
                else
                    rbAtivo.Checked = true;
            }
        }
    }

}
