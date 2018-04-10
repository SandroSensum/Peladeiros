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
            dtsValor1.VALOR.Merge ( oMesAno.BuscarMesAno ( txtMesAnoPesquisa.Text ) );
        }

        private void dataGridView1_DoubleClick( object sender, EventArgs e )
        {
            tbcPadrao.SelectedTab = tabPrincipal;
        }

        private void txtReferencia_Leave( object sender, EventArgs e )
        {
            Valor oRef = new Valor ();
            if ( !string.IsNullOrEmpty ( txtReferencia.Text.Replace ( "/", "" ).Trim () ) && !oRef.ValidaRef ( txtReferencia.Text ) )
                MessageBox.Show ( "Valor para o Mês e Ano de referencia já cadastrado", "Peladeiros", MessageBoxButtons.OK, MessageBoxIcon.Stop );
        }

        private bool frmValores_ValidarGravar()
        {
            bool validacao = true;
            Valor oRef = new Valor ();
            if ( !string.IsNullOrEmpty ( txtReferencia.Text.Replace ( "/", "" ).Trim () ) && !oRef.ValidaRef ( txtReferencia.Text ) )
            {
                validacao = false;
                MessageBox.Show ( "Valor para o Mês e Ano de referencia já cadastrado", "Peladeiros", MessageBoxButtons.OK, MessageBoxIcon.Stop );
            }
            else
            {
                if ( string.IsNullOrEmpty ( txtReferencia.Text.Replace ( "/", "" ).Trim () ) )
                {
                    validacao = false;
                    MessageBox.Show ( "Deve ser informado Mês e Ano de referencia", "Peladeiros", MessageBoxButtons.OK, MessageBoxIcon.Stop );
                }
            }

            return validacao;

        }
    }
}
