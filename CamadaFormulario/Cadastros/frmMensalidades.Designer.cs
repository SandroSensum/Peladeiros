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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensalidades));
            this.txtSaldo = new System.Windows.Forms.MaskedTextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.cboConta = new CamadaComponente.Componentes.scCombo();
            this.lblConta = new System.Windows.Forms.Label();
            this.cboJogador = new CamadaComponente.Componentes.scCombo();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtPgto = new System.Windows.Forms.MaskedTextBox();
            this.lblPgto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lbl_jogador = new System.Windows.Forms.Label();
            this.btnJogador = new System.Windows.Forms.Button();
            this.scDataGridView1 = new CamadaComponente.Componentes.scDataGridView();
            this.cODBAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATCADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODJOGADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCONTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODVALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATPGTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboBuscaValor = new CamadaComponente.Componentes.scCombo();
            this.dtsBaixas1 = new CamadaLogica.DS.dtsBaixas();
            this.baixas1 = new CamadaLogica.Classes.Baixas();
            this.txtValor = new CamadaComponente.Componentes.scMaskValor();
            this.txtPesquisaRef1 = new CamadaComponente.Componentes.scTextBox();
            this.lblPesquisaReferencia = new System.Windows.Forms.Label();
            this.dtsConta1 = new CamadaLogica.DS.dtsConta();
            this.lblA = new System.Windows.Forms.Label();
            this.txtPesquisaRef2 = new CamadaComponente.Componentes.scTextBox();
            this.lblPesquisaJogador = new System.Windows.Forms.Label();
            this.txtPesquisaJogador = new CamadaComponente.Componentes.scTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsBaixas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConta1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsoPadrao
            // 
            this.bsoPadrao.DataMember = "BAIXA_MENSALIDADES";
            this.bsoPadrao.DataSource = this.dtsBaixas1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Size = new System.Drawing.Size(550, 231);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Location = new System.Drawing.Point(3, 102);
            this.pnlResultado.Size = new System.Drawing.Size(544, 126);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.scDataGridView1);
            this.pnlGrade.Size = new System.Drawing.Size(544, 99);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.lblPesquisaJogador);
            this.pnlFiltro.Controls.Add(this.txtPesquisaJogador);
            this.pnlFiltro.Controls.Add(this.lblA);
            this.pnlFiltro.Controls.Add(this.txtPesquisaRef2);
            this.pnlFiltro.Controls.Add(this.lblPesquisaReferencia);
            this.pnlFiltro.Controls.Add(this.txtPesquisaRef1);
            this.pnlFiltro.Size = new System.Drawing.Size(544, 99);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Size = new System.Drawing.Size(544, 27);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(550, 231);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(558, 257);
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.txtValor);
            this.pnlBase.Controls.Add(this.cboBuscaValor);
            this.pnlBase.Controls.Add(this.btnJogador);
            this.pnlBase.Controls.Add(this.txtSaldo);
            this.pnlBase.Controls.Add(this.lblSaldo);
            this.pnlBase.Controls.Add(this.cboConta);
            this.pnlBase.Controls.Add(this.lblConta);
            this.pnlBase.Controls.Add(this.cboJogador);
            this.pnlBase.Controls.Add(this.txtCodigo);
            this.pnlBase.Controls.Add(this.txtCadastro);
            this.pnlBase.Controls.Add(this.lblCadastro);
            this.pnlBase.Controls.Add(this.lblCodigo);
            this.pnlBase.Controls.Add(this.txtPgto);
            this.pnlBase.Controls.Add(this.lblPgto);
            this.pnlBase.Controls.Add(this.lblValor);
            this.pnlBase.Controls.Add(this.lblReferencia);
            this.pnlBase.Controls.Add(this.lbl_jogador);
            this.pnlBase.Size = new System.Drawing.Size(544, 225);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(418, 196);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(114, 20);
            this.txtSaldo.TabIndex = 16;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(415, 180);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(80, 13);
            this.lblSaldo.TabIndex = 15;
            this.lblSaldo.Text = "Saldo em Caixa";
            // 
            // cboConta
            // 
            this.cboConta.Desabilitar = false;
            this.cboConta.FormattingEnabled = true;
            this.cboConta.Location = new System.Drawing.Point(12, 108);
            this.cboConta.Name = "cboConta";
            this.cboConta.Size = new System.Drawing.Size(280, 21);
            this.cboConta.TabIndex = 3;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(12, 92);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(78, 13);
            this.lblConta.TabIndex = 2;
            this.lblConta.Text = "Conta Corrente";
            // 
            // cboJogador
            // 
            this.cboJogador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboJogador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboJogador.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsoPadrao, "COD_JOGADOR", true));
            this.cboJogador.Desabilitar = false;
            this.cboJogador.FormattingEnabled = true;
            this.cboJogador.Location = new System.Drawing.Point(12, 68);
            this.cboJogador.Name = "cboJogador";
            this.cboJogador.Size = new System.Drawing.Size(280, 21);
            this.cboJogador.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_BAIXA", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(12, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 11;
            // 
            // txtCadastro
            // 
            this.txtCadastro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_CADASTRO", true));
            this.txtCadastro.Enabled = false;
            this.txtCadastro.Location = new System.Drawing.Point(88, 29);
            this.txtCadastro.Mask = "00/00/0000";
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.ReadOnly = true;
            this.txtCadastro.Size = new System.Drawing.Size(84, 20);
            this.txtCadastro.TabIndex = 13;
            this.txtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(87, 13);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblCadastro.TabIndex = 12;
            this.lblCadastro.Text = "Data Cadastro";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Código";
            // 
            // txtPgto
            // 
            this.txtPgto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_PGTO", true));
            this.txtPgto.Location = new System.Drawing.Point(206, 148);
            this.txtPgto.Mask = "00/00/0000";
            this.txtPgto.Name = "txtPgto";
            this.txtPgto.Size = new System.Drawing.Size(84, 20);
            this.txtPgto.TabIndex = 9;
            this.txtPgto.ValidatingType = typeof(System.DateTime);
            // 
            // lblPgto
            // 
            this.lblPgto.AutoSize = true;
            this.lblPgto.Location = new System.Drawing.Point(203, 132);
            this.lblPgto.Name = "lblPgto";
            this.lblPgto.Size = new System.Drawing.Size(87, 13);
            this.lblPgto.TabIndex = 8;
            this.lblPgto.Text = "Data Pagamento";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(87, 132);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(12, 132);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(59, 13);
            this.lblReferencia.TabIndex = 4;
            this.lblReferencia.Text = "Referencia";
            // 
            // lbl_jogador
            // 
            this.lbl_jogador.AutoSize = true;
            this.lbl_jogador.Location = new System.Drawing.Point(12, 52);
            this.lbl_jogador.Name = "lbl_jogador";
            this.lbl_jogador.Size = new System.Drawing.Size(45, 13);
            this.lbl_jogador.TabIndex = 14;
            this.lbl_jogador.Text = "Jogador";
            // 
            // btnJogador
            // 
            this.btnJogador.FlatAppearance.BorderSize = 0;
            this.btnJogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogador.Image = ((System.Drawing.Image)(resources.GetObject("btnJogador.Image")));
            this.btnJogador.Location = new System.Drawing.Point(298, 68);
            this.btnJogador.Name = "btnJogador";
            this.btnJogador.Size = new System.Drawing.Size(21, 21);
            this.btnJogador.TabIndex = 1;
            this.btnJogador.UseVisualStyleBackColor = true;
            this.btnJogador.Click += new System.EventHandler(this.button1_Click);
            // 
            // scDataGridView1
            // 
            this.scDataGridView1.AllowUserToAddRows = false;
            this.scDataGridView1.AllowUserToDeleteRows = false;
            this.scDataGridView1.AutoGenerateColumns = false;
            this.scDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODBAIXADataGridViewTextBoxColumn,
            this.dATCADASTRODataGridViewTextBoxColumn,
            this.cODJOGADORDataGridViewTextBoxColumn,
            this.cODCONTADataGridViewTextBoxColumn,
            this.cODVALORDataGridViewTextBoxColumn,
            this.dATPGTODataGridViewTextBoxColumn});
            this.scDataGridView1.DataSource = this.bsoPadrao;
            this.scDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.scDataGridView1.Name = "scDataGridView1";
            this.scDataGridView1.ReadOnly = true;
            this.scDataGridView1.Size = new System.Drawing.Size(544, 99);
            this.scDataGridView1.TabIndex = 0;
            // 
            // cODBAIXADataGridViewTextBoxColumn
            // 
            this.cODBAIXADataGridViewTextBoxColumn.DataPropertyName = "COD_BAIXA";
            this.cODBAIXADataGridViewTextBoxColumn.HeaderText = "COD_BAIXA";
            this.cODBAIXADataGridViewTextBoxColumn.Name = "cODBAIXADataGridViewTextBoxColumn";
            this.cODBAIXADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATCADASTRODataGridViewTextBoxColumn
            // 
            this.dATCADASTRODataGridViewTextBoxColumn.DataPropertyName = "DAT_CADASTRO";
            this.dATCADASTRODataGridViewTextBoxColumn.HeaderText = "DAT_CADASTRO";
            this.dATCADASTRODataGridViewTextBoxColumn.Name = "dATCADASTRODataGridViewTextBoxColumn";
            this.dATCADASTRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODJOGADORDataGridViewTextBoxColumn
            // 
            this.cODJOGADORDataGridViewTextBoxColumn.DataPropertyName = "COD_JOGADOR";
            this.cODJOGADORDataGridViewTextBoxColumn.HeaderText = "COD_JOGADOR";
            this.cODJOGADORDataGridViewTextBoxColumn.Name = "cODJOGADORDataGridViewTextBoxColumn";
            this.cODJOGADORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODCONTADataGridViewTextBoxColumn
            // 
            this.cODCONTADataGridViewTextBoxColumn.DataPropertyName = "COD_CONTA";
            this.cODCONTADataGridViewTextBoxColumn.HeaderText = "COD_CONTA";
            this.cODCONTADataGridViewTextBoxColumn.Name = "cODCONTADataGridViewTextBoxColumn";
            this.cODCONTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODVALORDataGridViewTextBoxColumn
            // 
            this.cODVALORDataGridViewTextBoxColumn.DataPropertyName = "COD_VALOR";
            this.cODVALORDataGridViewTextBoxColumn.HeaderText = "COD_VALOR";
            this.cODVALORDataGridViewTextBoxColumn.Name = "cODVALORDataGridViewTextBoxColumn";
            this.cODVALORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATPGTODataGridViewTextBoxColumn
            // 
            this.dATPGTODataGridViewTextBoxColumn.DataPropertyName = "DAT_PGTO";
            this.dATPGTODataGridViewTextBoxColumn.HeaderText = "DAT_PGTO";
            this.dATPGTODataGridViewTextBoxColumn.Name = "dATPGTODataGridViewTextBoxColumn";
            this.dATPGTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cboBuscaValor
            // 
            this.cboBuscaValor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsoPadrao, "COD_VALOR", true));
            this.cboBuscaValor.Desabilitar = false;
            this.cboBuscaValor.FormattingEnabled = true;
            this.cboBuscaValor.Location = new System.Drawing.Point(12, 148);
            this.cboBuscaValor.Name = "cboBuscaValor";
            this.cboBuscaValor.Size = new System.Drawing.Size(70, 21);
            this.cboBuscaValor.TabIndex = 17;
            this.cboBuscaValor.Leave += new System.EventHandler(this.cboBuscaValor_Leave);
            // 
            // dtsBaixas1
            // 
            this.dtsBaixas1.DataSetName = "dtsBaixas";
            this.dtsBaixas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtValor
            // 
            this.txtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_VALOR", true));
            this.txtValor.Desabilitar = false;
            this.txtValor.Location = new System.Drawing.Point(88, 148);
            this.txtValor.Mask = "00.00";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(68, 20);
            this.txtValor.TabIndex = 18;
            this.txtValor.TabStop = false;
            this.txtValor.Text = "0000";
            // 
            // txtPesquisaRef1
            // 
            this.txtPesquisaRef1.Location = new System.Drawing.Point(20, 29);
            this.txtPesquisaRef1.Name = "txtPesquisaRef1";
            this.txtPesquisaRef1.Size = new System.Drawing.Size(56, 20);
            this.txtPesquisaRef1.TabIndex = 0;
            // 
            // lblPesquisaReferencia
            // 
            this.lblPesquisaReferencia.AutoSize = true;
            this.lblPesquisaReferencia.Location = new System.Drawing.Point(17, 13);
            this.lblPesquisaReferencia.Name = "lblPesquisaReferencia";
            this.lblPesquisaReferencia.Size = new System.Drawing.Size(43, 13);
            this.lblPesquisaReferencia.TabIndex = 1;
            this.lblPesquisaReferencia.Text = "Periodo";
            // 
            // dtsConta1
            // 
            this.dtsConta1.DataSetName = "dtsConta";
            this.dtsConta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(82, 33);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "a";
            // 
            // txtPesquisaRef2
            // 
            this.txtPesquisaRef2.Location = new System.Drawing.Point(101, 29);
            this.txtPesquisaRef2.Name = "txtPesquisaRef2";
            this.txtPesquisaRef2.Size = new System.Drawing.Size(56, 20);
            this.txtPesquisaRef2.TabIndex = 2;
            // 
            // lblPesquisaJogador
            // 
            this.lblPesquisaJogador.AutoSize = true;
            this.lblPesquisaJogador.Location = new System.Drawing.Point(17, 52);
            this.lblPesquisaJogador.Name = "lblPesquisaJogador";
            this.lblPesquisaJogador.Size = new System.Drawing.Size(43, 13);
            this.lblPesquisaJogador.TabIndex = 5;
            this.lblPesquisaJogador.Text = "Periodo";
            // 
            // txtPesquisaJogador
            // 
            this.txtPesquisaJogador.Location = new System.Drawing.Point(20, 68);
            this.txtPesquisaJogador.Name = "txtPesquisaJogador";
            this.txtPesquisaJogador.Size = new System.Drawing.Size(286, 20);
            this.txtPesquisaJogador.TabIndex = 4;
            // 
            // frmMensalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClasseDados = this.baixas1;
            this.ClientSize = new System.Drawing.Size(558, 319);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMensalidades";
            this.Text = "Baixa de Mensalidades";
            this.Load += new System.EventHandler(this.frmMensalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.pnlResultado.ResumeLayout(false);
            this.pnlGrade.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.tbcPadrao.ResumeLayout(false);
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsBaixas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private CamadaComponente.Componentes.scCombo cboConta;
        private System.Windows.Forms.Label lblConta;
        private CamadaComponente.Componentes.scCombo cboJogador;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtCadastro;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox txtPgto;
        private System.Windows.Forms.Label lblPgto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lbl_jogador;
        private System.Windows.Forms.Button btnJogador;
        private CamadaComponente.Componentes.scDataGridView scDataGridView1;
        private CamadaComponente.Componentes.scCombo cboBuscaValor;
        private CamadaLogica.DS.dtsBaixas dtsBaixas1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODBAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATCADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODJOGADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCONTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODVALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATPGTODataGridViewTextBoxColumn;
        private CamadaLogica.Classes.Baixas baixas1;
        private CamadaComponente.Componentes.scMaskValor txtValor;
        private System.Windows.Forms.Label lblPesquisaJogador;
        private CamadaComponente.Componentes.scTextBox txtPesquisaJogador;
        private System.Windows.Forms.Label lblA;
        private CamadaComponente.Componentes.scTextBox txtPesquisaRef2;
        private System.Windows.Forms.Label lblPesquisaReferencia;
        private CamadaComponente.Componentes.scTextBox txtPesquisaRef1;
        private CamadaLogica.DS.dtsConta dtsConta1;
    }
}
