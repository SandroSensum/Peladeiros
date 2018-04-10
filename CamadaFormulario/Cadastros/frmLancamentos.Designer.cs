namespace CamadaFormulario.Cadastros
{
    partial class frmLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamentos));
            this.txtDescricaoLcto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lbl_jogador = new System.Windows.Forms.Label();
            this.btnConta = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.cboJogador = new System.Windows.Forms.ComboBox();
            this.txtPgto = new System.Windows.Forms.MaskedTextBox();
            this.lblPgto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.dtsLancamentos1 = new CamadaLogica.DS.dtsLancamentos();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsLancamentos1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsoPadrao
            // 
            this.bsoPadrao.DataMember = "LANCAMENTOS";
            this.bsoPadrao.DataSource = this.dtsLancamentos1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Size = new System.Drawing.Size(507, 212);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Location = new System.Drawing.Point(3, 55);
            this.pnlResultado.Size = new System.Drawing.Size(501, 154);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Size = new System.Drawing.Size(501, 127);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Size = new System.Drawing.Size(501, 52);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Size = new System.Drawing.Size(501, 27);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(507, 212);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(515, 238);
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.btnConta);
            this.pnlBase.Controls.Add(this.txtValor);
            this.pnlBase.Controls.Add(this.cboJogador);
            this.pnlBase.Controls.Add(this.txtPgto);
            this.pnlBase.Controls.Add(this.lblPgto);
            this.pnlBase.Controls.Add(this.lblValor);
            this.pnlBase.Controls.Add(this.txtDescricaoLcto);
            this.pnlBase.Controls.Add(this.label2);
            this.pnlBase.Controls.Add(this.txtCodigo);
            this.pnlBase.Controls.Add(this.txtCadastro);
            this.pnlBase.Controls.Add(this.lblCadastro);
            this.pnlBase.Controls.Add(this.lblCodigo);
            this.pnlBase.Controls.Add(this.lbl_jogador);
            this.pnlBase.Size = new System.Drawing.Size(501, 206);
            // 
            // txtDescricaoLcto
            // 
            this.txtDescricaoLcto.Location = new System.Drawing.Point(18, 122);
            this.txtDescricaoLcto.Name = "txtDescricaoLcto";
            this.txtDescricaoLcto.Size = new System.Drawing.Size(280, 20);
            this.txtDescricaoLcto.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Descrição do Lançamento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_LCTO", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(18, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 43;
            // 
            // txtCadastro
            // 
            this.txtCadastro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_CADASTRO", true));
            this.txtCadastro.Location = new System.Drawing.Point(94, 32);
            this.txtCadastro.Mask = "00/00/0000";
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.ReadOnly = true;
            this.txtCadastro.Size = new System.Drawing.Size(84, 20);
            this.txtCadastro.TabIndex = 45;
            this.txtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(93, 16);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblCadastro.TabIndex = 44;
            this.lblCadastro.Text = "Data Cadastro";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 42;
            this.lblCodigo.Text = "Código";
            // 
            // lbl_jogador
            // 
            this.lbl_jogador.AutoSize = true;
            this.lbl_jogador.Location = new System.Drawing.Point(18, 65);
            this.lbl_jogador.Name = "lbl_jogador";
            this.lbl_jogador.Size = new System.Drawing.Size(35, 13);
            this.lbl_jogador.TabIndex = 46;
            this.lbl_jogador.Text = "Conta";
            // 
            // btnConta
            // 
            this.btnConta.FlatAppearance.BorderSize = 0;
            this.btnConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConta.Image = ((System.Drawing.Image)(resources.GetObject("btnConta.Image")));
            this.btnConta.Location = new System.Drawing.Point(304, 79);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(21, 21);
            this.btnConta.TabIndex = 56;
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(19, 161);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(71, 20);
            this.txtValor.TabIndex = 62;
            // 
            // cboJogador
            // 
            this.cboJogador.FormattingEnabled = true;
            this.cboJogador.Location = new System.Drawing.Point(18, 79);
            this.cboJogador.Name = "cboJogador";
            this.cboJogador.Size = new System.Drawing.Size(280, 21);
            this.cboJogador.TabIndex = 55;
            // 
            // txtPgto
            // 
            this.txtPgto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_LCTO", true));
            this.txtPgto.Location = new System.Drawing.Point(96, 161);
            this.txtPgto.Mask = "00/00/0000";
            this.txtPgto.Name = "txtPgto";
            this.txtPgto.Size = new System.Drawing.Size(84, 20);
            this.txtPgto.TabIndex = 64;
            this.txtPgto.ValidatingType = typeof(System.DateTime);
            // 
            // lblPgto
            // 
            this.lblPgto.AutoSize = true;
            this.lblPgto.Location = new System.Drawing.Point(93, 145);
            this.lblPgto.Name = "lblPgto";
            this.lblPgto.Size = new System.Drawing.Size(30, 13);
            this.lblPgto.TabIndex = 63;
            this.lblPgto.Text = "Data";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(18, 145);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 61;
            this.lblValor.Text = "Valor";
            // 
            // dtsLancamentos1
            // 
            this.dtsLancamentos1.DataSetName = "dtsLancamentos";
            this.dtsLancamentos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(515, 300);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLancamentos";
            this.Text = "Lançamentos";
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.pnlResultado.ResumeLayout(false);
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.tbcPadrao.ResumeLayout(false);
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsLancamentos1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtDescricaoLcto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtCadastro;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lbl_jogador;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.ComboBox cboJogador;
        private System.Windows.Forms.MaskedTextBox txtPgto;
        private System.Windows.Forms.Label lblPgto;
        private System.Windows.Forms.Label lblValor;
        private CamadaLogica.DS.dtsLancamentos dtsLancamentos1;
    }
}
