﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CamadaFuncao.Enumerados;

namespace CamadaComponente
{
    public partial class frmPadrao : Form
    {
        #region [Atributos]

        private eModoNavegacao Navegacao = eModoNavegacao.navegacao;

        #endregion

        #region [Construtor]

        public frmPadrao()
        {
            IniciarFormulario();
            ControlaNavegacao();
        }

        #endregion

        #region [Métodos]

        private void IniciarFormulario()
        {
            InitializeComponent();
            lblMensagem.Text = "";
            lblUsuario.Text = "Pedrinho";
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


        }

        #endregion

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void ControlaNavegacao()
        {
            if (Navegacao == eModoNavegacao.navegacao)
            {
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                btnAlterar.Enabled = false;
                btnGravar.Enabled = false;
                btnSair.Enabled = false;
                btnExcluir.Enabled = false;
                btnSair.Enabled = true;
                if (!tbcPadrao.TabPages.Contains(tabPesquisa))
                    tbcPadrao.TabPages.Add(tabPesquisa);
                //if (!tbcPadrao.TabPages.Contains(tabMensalidades))
                //    tbcPadrao.TabPages.Add(tabMensalidades);

            }
            else if (Navegacao == eModoNavegacao.inclusao || Navegacao == eModoNavegacao.alteracao)
            {
                btnCancelar.Enabled = true;
                btnAlterar.Enabled = false;
                btnGravar.Enabled = false;
                btnSair.Enabled = false;
                btnExcluir.Enabled = true;
                btnSair.Enabled = false;
                if (tbcPadrao.TabPages.Contains(tabPesquisa))
                    tbcPadrao.TabPages.Remove(tabPesquisa);

                //if (tbcPadrao.TabPages.Contains(tabMensalidades))
                //    tbcPadrao.TabPages.Remove(tabMensalidades);
            }
            else if (Navegacao == eModoNavegacao.exclusao)
            {
                //txtDesativado.Text = DateTime.Today.ToString("dd-MM-yyyy");
                btnCancelar.Enabled = false;
                btnAlterar.Enabled = true;
                btnGravar.Enabled = false;
                btnSair.Enabled = false;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //lblmensagem.Text = "";
            Navegacao = eModoNavegacao.inclusao;
            ControlaNavegacao();
            //bsoJogador.AddNew();
            //rbAtivo.Checked = true;
            //if (rbAtivo.Checked)
            //{
            //    if (bsoJogador.Count > 0)
            //    {
            //        txtCadastro.Text = DateTime.Now.ToString();
            //        ((DataRowView)bsoJogador.Current)["ATIVO"] = "A";
            //    }
            //}
            //else
            //{
            //    txtCadastro.Text = "";
            //    ((DataRowView)bsoJogador.Current)["DAT_ATIVADO"] = DBNull.Value;
            //    ((DataRowView)bsoJogador.Current)["ATIVO"] = "I";
            //}

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inativar o Jogador?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Navegacao = eModoNavegacao.navegacao;
                ControlaNavegacao();
                btnAlterar.Enabled = true;
                //dsJogadores.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Navegacao = eModoNavegacao.alteracao;
            //bsoJogador.EndEdit();
            ControlaNavegacao();
        }

        private void btnGravar_Click(object sender, EventArgs e)    
        {
        //    if (Validacao())
        //        try
        //        {
        //            if (rbInativo.Checked)
        //            {
        //                txtDesativado.Text = DateTime.Now.ToString();
        //                lblmensagem.Text = "Jogador Inativado com sucesso";
        //                lblmensagem.ForeColor = Color.Red;
        //            }
        //            else
        //            {
        //                txtDesativado.Text = "";
        //                lblmensagem.Text = "Dados gravados com sucesso";
        //                lblmensagem.ForeColor = Color.Green;
        //            }
        //            Acesso_Banco oBanco = new Acesso_Banco();
        //            Jogador oJogador = new Jogador();

        //            bsoJogador.EndEdit();
        //            bsoEmail.EndEdit();
        //            bsoTelefone.EndEdit();

        //            oBanco.Atualizar(dsJogadores.Jogador.GetChanges());

        //            int iCodJogadorAtual = 0;

        //            if (Navegacao == Enumerado.enavegacao.Inclusao)
        //            {
        //                iCodJogadorAtual = oJogador.BuscarCodigoUltimoJogador();
        //            }
        //            else
        //            {
        //                iCodJogadorAtual = Convert.ToInt32(txtCodigo.Text);
        //            }

        //            foreach (DataRowView drwTelefone in bsoTelefone)
        //            {
        //                ((DataRowView)bsoTelefone.Current)["COD_JOGADOR"] = iCodJogadorAtual;
        //                oBanco.Atualizar(dsJogadores.Telefone.GetChanges());
        //            }

        //            foreach (DataRowView drwEmail in bsoEmail)
        //            {
        //                ((DataRowView)bsoEmail.Current)["COD_JOGADOR"] = iCodJogadorAtual;
        //                oBanco.Atualizar(dsJogadores.Email.GetChanges());
        //            }

        //            if (dsJogadores.Telefone.AsEnumerable().Where(item => item.RowState == DataRowState.Deleted).Count() > 0)
        //                oBanco.Atualizar(dsJogadores.Telefone.GetChanges());

        //            if (dsJogadores.Email.AsEnumerable().Where(item => item.RowState == DataRowState.Deleted).Count() > 0)
        //                oBanco.Atualizar(dsJogadores.Email.GetChanges());

        //            dsJogadores.Jogador.Clear();
        //            int iCodJogador = oJogador.BuscarCodigoUltimoJogador();
        //            dsJogadores.Jogador.Merge(oJogador.BuscarJogador(iCodJogador));

        //        }
        //        catch (Exception ex)
        //        {
        //            lblmensagem.Text = "Anomalia: " + ex.Message;
        //            lblmensagem.ForeColor = Color.Red;
        //        }
        //    Navegacao = Enumerado.enavegacao.Navegacao;
        //    ControlaNavegacao();
        //    btnAlterar.Enabled = true;
        //}
        //private bool Validacao()
        //{
        //    string msnvalida = "";
        //    if (txtNome.Text == "")
        //        msnvalida = "Campo Nome não pode ser nulo";
        //    if (msnvalida != "")
        //        MessageBox.Show(msnvalida);
        //    return msnvalida == "";
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //{
            //    if (rbInativo.Checked)
            //    {
            //        if (MessageBox.Show("O jogador já está inativo. Operação cancelada", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK) ;

            //    }
            //    else

            //    if (MessageBox.Show("O jogador será inativado. Deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        if (Validacao())
            //        {
            //            try
            //            {
            //                rbInativo.Checked = true;
            //                ((DataRowView)bsoJogador.Current)["ATIVO"] = 'I';

            //                Acesso_Banco oBanco = new Acesso_Banco();
            //                bsoJogador.EndEdit();
            //                bsoEmail.EndEdit();
            //                bsoTelefone.EndEdit();
            //                oBanco.Atualizar(dsJogadores.Jogador.GetChanges());
            //                oBanco.Atualizar(dsJogadores.Email.GetChanges());
            //                oBanco.Atualizar(dsJogadores.Telefone.GetChanges());
            //                lblmensagem.Text = "Jogador inativado com sucesso";
            //                lblmensagem.ForeColor = Color.Red;
            //            }
            //            catch (Exception ex)
            //            {
            //                lblmensagem.Text = "Anomalia: " + ex.Message;
            //                lblmensagem.ForeColor = Color.Red;
            //            }
            //            rbInativo.Checked = true;
            //        }
            //        Navegacao = Enumerado.enavegacao.Navegacao;
            //        ControlaNavegacao();
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dsJogadores.Clear();
            //btnGravar.Enabled = false;
            //lblmensagem.Text = "";
            //Jogador oJogador = new Jogador();
            //int icodini = 0;
            //if (txtCodini.Text != "")
            //    icodini = Convert.ToInt32(txtCodini.Text);
            //int icodfim = 0;
            //if (txtCodFim.Text != "")
            //    icodfim = Convert.ToInt32(txtCodFim.Text);
        }
    }
}
