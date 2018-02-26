namespace CamadaFormulario.Cadastros
{
    partial class frmMensalidades
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.cboJogador = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.MaskedTextBox();
            this.txtPgto = new System.Windows.Forms.MaskedTextBox();
            this.lblPgto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lbl_jogador = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.maskedTextBox1);
            this.tabPrincipal.Controls.Add(this.label3);
            this.tabPrincipal.Controls.Add(this.comboBox1);
            this.tabPrincipal.Controls.Add(this.label2);
            this.tabPrincipal.Controls.Add(this.txtValor);
            this.tabPrincipal.Controls.Add(this.cboJogador);
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            this.tabPrincipal.Controls.Add(this.txtCadastro);
            this.tabPrincipal.Controls.Add(this.lblCadastro);
            this.tabPrincipal.Controls.Add(this.label1);
            this.tabPrincipal.Controls.Add(this.txtReferencia);
            this.tabPrincipal.Controls.Add(this.txtPgto);
            this.tabPrincipal.Controls.Add(this.lblPgto);
            this.tabPrincipal.Controls.Add(this.lblValor);
            this.tabPrincipal.Controls.Add(this.lblReferencia);
            this.tabPrincipal.Controls.Add(this.lbl_jogador);
            this.tabPrincipal.Size = new System.Drawing.Size(513, 203);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Size = new System.Drawing.Size(543, 82);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Size = new System.Drawing.Size(543, 55);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Size = new System.Drawing.Size(543, 94);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Size = new System.Drawing.Size(543, 27);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(549, 182);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(521, 229);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(521, 229);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(104, 161);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(114, 20);
            this.txtValor.TabIndex = 48;
            // 
            // cboJogador
            // 
            this.cboJogador.FormattingEnabled = true;
            this.cboJogador.Location = new System.Drawing.Point(28, 81);
            this.cboJogador.Name = "cboJogador";
            this.cboJogador.Size = new System.Drawing.Size(280, 21);
            this.cboJogador.TabIndex = 45;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(28, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 46;
            // 
            // txtCadastro
            // 
            this.txtCadastro.Location = new System.Drawing.Point(224, 31);
            this.txtCadastro.Mask = "00/00/0000";
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(84, 20);
            this.txtCadastro.TabIndex = 56;
            this.txtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(221, 15);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblCadastro.TabIndex = 55;
            this.lblCadastro.Text = "Data Cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Código";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(28, 161);
            this.txtReferencia.Mask = "00/0000";
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(70, 20);
            this.txtReferencia.TabIndex = 47;
            // 
            // txtPgto
            // 
            this.txtPgto.Location = new System.Drawing.Point(224, 161);
            this.txtPgto.Mask = "00/00/0000";
            this.txtPgto.Name = "txtPgto";
            this.txtPgto.Size = new System.Drawing.Size(84, 20);
            this.txtPgto.TabIndex = 53;
            this.txtPgto.ValidatingType = typeof(System.DateTime);
            // 
            // lblPgto
            // 
            this.lblPgto.AutoSize = true;
            this.lblPgto.Location = new System.Drawing.Point(221, 145);
            this.lblPgto.Name = "lblPgto";
            this.lblPgto.Size = new System.Drawing.Size(87, 13);
            this.lblPgto.TabIndex = 52;
            this.lblPgto.Text = "Data Pagamento";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(101, 145);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 51;
            this.lblValor.Text = "Valor";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(25, 145);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(59, 13);
            this.lblReferencia.TabIndex = 50;
            this.lblReferencia.Text = "Referencia";
            // 
            // lbl_jogador
            // 
            this.lbl_jogador.AutoSize = true;
            this.lbl_jogador.Location = new System.Drawing.Point(25, 65);
            this.lbl_jogador.Name = "lbl_jogador";
            this.lbl_jogador.Size = new System.Drawing.Size(45, 13);
            this.lbl_jogador.TabIndex = 49;
            this.lbl_jogador.Text = "Jogador";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 21);
            this.comboBox1.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Conta Corrente";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(388, 161);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(114, 20);
            this.maskedTextBox1.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Saldo em Caixa";
            // 
            // frmMensalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(521, 291);
            this.Name = "frmMensalidades";
            this.Text = "Baixa de Mensalidades";
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.pnlResultado.ResumeLayout(false);
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tbcPadrao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.ComboBox cboJogador;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtCadastro;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtReferencia;
        private System.Windows.Forms.MaskedTextBox txtPgto;
        private System.Windows.Forms.Label lblPgto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lbl_jogador;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
    }
}
