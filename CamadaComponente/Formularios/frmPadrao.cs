using CamadaBase;
using CamadaComponente.Componentes;
using CamadaFuncao;
using CamadaFuncao.Classes;
using CamadaFuncao.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CamadaFuncao.Delegates.Delegates;
using static CamadaFuncao.Enumerados;

namespace CamadaComponente
{
    public partial class frmPadrao : Form
    {
        #region [Atributos]

        private eModoNavegacao Navegacao = eModoNavegacao.navegacao;
        private Base classeDados = null;
        
        #endregion

        #region [Propriedades]

        [Description ( "Vincula uma classe que irá gravar os dados no banco" ), Category ( "Peladeiros" ), DefaultValue ( null )]
        public Base ClasseDados
        {
            
            get { return classeDados; }
            set { classeDados = value; }
        }

        #endregion

        #region [Delegates]

        [Description ( "Evento executado para validações antes de gravar" ), Category ( "Peladeiros" )]
        public event PadraoValidarEventHandler ValidarGravar;

        [Description ( "Evento executado antes de gravar no banco" ), Category ( "Peladeiros" )]
        public event PadraoEventHandler AntesDeGravar;

        [Description ( "Evento executado após gravar no banco" ), Category ( "Peladeiros" )]
        public event PadraoEventHandler DepoisDeGravar;

        #endregion

        #region [Construtor]

        public frmPadrao()
        {
            IniciarFormulario ();
            ControlaNavegacao ();
        }

        #endregion

        #region [Métodos]

        private void IniciarFormulario()
        {
            InitializeComponent ();
            lblMensagem.Text = "";
            lblUsuario.Text = Propriedades.UsuarioLogado;
            lblDataHora.Text = DateTime.Now.ToString ( "dd/MM/yyyy HH:mm:ss" );
        }

        private void ControlaNavegacao()
        {
            AtualizarNavegacaoComponentes ( this );
            if ( Navegacao == eModoNavegacao.navegacao )
            {
                btnGravar.Enabled = false;
                btnIncluir.Enabled = true;
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                btnSair.Enabled = true;

                if ( !tbcPadrao.TabPages.Contains ( tabPesquisa ) )
                {
                    tbcPadrao.TabPages.Remove ( tabPrincipal );
                    tbcPadrao.TabPages.Add ( tabPesquisa );
                    tbcPadrao.TabPages.Add ( tabPrincipal );
                    tbcPadrao.SelectedTab = tabPrincipal;
                }
                //Colocar na aba específica e depois tirar daqui
                //if (!tbcPadrao.TabPages.Contains(tabMensalidades))
                //    tbcPadrao.TabPages.Add(tabMensalidades);

            }
            else if ( Navegacao == eModoNavegacao.inclusao || Navegacao == eModoNavegacao.alteracao )
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnIncluir.Enabled = false;
                btnGravar.Enabled = true;
                btnSair.Enabled = false;
                btnCancelar.Enabled = true;

                if ( tbcPadrao.TabPages.Contains ( tabPesquisa ) )
                    tbcPadrao.TabPages.Remove ( tabPesquisa );
                
            }
            else if ( Navegacao == eModoNavegacao.exclusao )
            {
                //txtDesativado.Text = DateTime.Today.ToString("dd-MM-yyyy");
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = true;
                btnGravar.Enabled = false;
                btnSair.Enabled = false;
            }

        }

        private void AtualizarNavegacaoComponentes( Control pControle )
        {
            foreach ( Control controle in pControle.Controls )
            {
                if ( controle.Controls.Count > 0 )
                    AtualizarNavegacaoComponentes ( controle );

                if ( controle is IComponente )
                    ( ( IComponente ) controle ).AtualizarNavegacao ( Navegacao );
            }
        }

        /// <summary>
        /// Chama os eventos padrões
        /// </summary>
        /// <param name="pEvent"></param>
        /// <param name="pValidacao"></param>
        public bool ChamarEventos( object pEvent, bool pValidacao = false )
        {
            bool? bRetorno = true;
            if ( pValidacao )
            {
                PadraoValidarEventHandler evento = ( PadraoValidarEventHandler ) pEvent;
                bRetorno = evento?.Invoke ();//Ponto de interrogação verifica se o evento não é nulo
            }
            else
            {
                PadraoEventHandler evento = ( PadraoEventHandler ) pEvent;
                evento?.Invoke ();//Ponto de interrogação verifica se o evento não é n
            }

            return bRetorno.HasValue ? bRetorno.Value : true;
        }


        #endregion

        #region [Eventos]

        private void tmrHora_Tick( object sender, EventArgs e )
        {
            lblDataHora.Text = DateTime.Now.ToString ( "dd/MM/yyyy HH:mm:ss" );
        }

        private void btnIncluir_Click( object sender, EventArgs e )
        {
            Navegacao = eModoNavegacao.inclusao;
            bsoPadrao.AddNew ();
            ControlaNavegacao ();
            
        }

        private void btnCancelar_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show ( "Deseja cancelar a operação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
            {
                Navegacao = eModoNavegacao.navegacao;
                ControlaNavegacao ();
                btnAlterar.Enabled = true;
            }
        }

        private void btnSair_Click( object sender, EventArgs e )
        {
            Close ();
        }

        private void btnAlterar_Click( object sender, EventArgs e )
        {
            if ( Funcao.PossuiRegistro ( bsoPadrao ) )
            {
                Navegacao = eModoNavegacao.alteracao;
                bsoPadrao.EndEdit ();
                ControlaNavegacao ();
            }
            else
            {
                MessageBox.Show ( "Não há registros selecionados para alteração.", "Peladeiros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                //teste
            }
        }

        private void btnGravar_Click( object sender, EventArgs e )
        {
            if ( ChamarEventos ( ValidarGravar, true ) )
            {
                ChamarEventos ( AntesDeGravar );

                bsoPadrao.EndEdit ();

                classeDados.Atualizar ( ( ( DataSet ) bsoPadrao.DataSource ).Tables[bsoPadrao.DataMember] );

                ChamarEventos ( DepoisDeGravar );

                Navegacao = eModoNavegacao.navegacao;
                ControlaNavegacao ();
            }
        }
        private void btnExcluir_Click( object sender, EventArgs e )
        {
            if ( Funcao.PossuiRegistro ( bsoPadrao ) )
                Navegacao = eModoNavegacao.exclusao;
            bsoPadrao.RemoveCurrent ();
            ControlaNavegacao ();
            if ( MessageBox.Show ( "O registro será excluido. Deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes ) ;
        }
    
        #endregion

    }
}
