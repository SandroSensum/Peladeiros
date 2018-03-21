namespace CamadaFormulario.Cadastros
{
    partial class frmContas
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
            this.label11 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDesativado = new System.Windows.Forms.MaskedTextBox();
            this.gpAtivo = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtgPesquisaConta = new System.Windows.Forms.DataGridView();
            this.dESCONTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATDESATIVADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtsConta1 = new CamadaLogica.DS.dtsConta();
            this.contas1 = new CamadaLogica.Classes.Contas();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            this.gpAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConta1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsoPadrao
            // 
            this.bsoPadrao.DataMember = "CONTAS";
            this.bsoPadrao.DataSource = this.dtsConta1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.label11);
            this.tabPrincipal.Controls.Add(this.lbNome);
            this.tabPrincipal.Controls.Add(this.txtNome);
            this.tabPrincipal.Controls.Add(this.label10);
            this.tabPrincipal.Controls.Add(this.txtDesativado);
            this.tabPrincipal.Controls.Add(this.gpAtivo);
            this.tabPrincipal.Controls.Add(this.label1);
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Location = new System.Drawing.Point(3, 56);
            this.pnlResultado.Size = new System.Drawing.Size(554, 136);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.dtgPesquisaConta);
            this.pnlGrade.Size = new System.Drawing.Size(554, 109);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Size = new System.Drawing.Size(554, 53);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Size = new System.Drawing.Size(554, 27);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(560, 195);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(568, 221);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(423, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Status";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(18, 64);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 13);
            this.lbNome.TabIndex = 39;
            this.lbNome.Text = "Descrição";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DES_CONTA", true));
            this.txtNome.Location = new System.Drawing.Point(21, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(388, 20);
            this.txtNome.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Data Desativado";
            // 
            // txtDesativado
            // 
            this.txtDesativado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_DESATIVADO", true));
            this.txtDesativado.Location = new System.Drawing.Point(426, 102);
            this.txtDesativado.Mask = "00/00/0000";
            this.txtDesativado.Name = "txtDesativado";
            this.txtDesativado.Size = new System.Drawing.Size(84, 20);
            this.txtDesativado.TabIndex = 41;
            this.txtDesativado.ValidatingType = typeof(System.DateTime);
            // 
            // gpAtivo
            // 
            this.gpAtivo.Controls.Add(this.rbInativo);
            this.gpAtivo.Controls.Add(this.rbAtivo);
            this.gpAtivo.Location = new System.Drawing.Point(426, 31);
            this.gpAtivo.Name = "gpAtivo";
            this.gpAtivo.Size = new System.Drawing.Size(102, 52);
            this.gpAtivo.TabIndex = 40;
            this.gpAtivo.TabStop = false;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(6, 31);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(6, 9);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_CONTA", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(21, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 37;
            // 
            // dtgPesquisaConta
            // 
            this.dtgPesquisaConta.AllowUserToAddRows = false;
            this.dtgPesquisaConta.AllowUserToDeleteRows = false;
            this.dtgPesquisaConta.AutoGenerateColumns = false;
            this.dtgPesquisaConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisaConta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dESCONTADataGridViewTextBoxColumn,
            this.dATDESATIVADODataGridViewTextBoxColumn});
            this.dtgPesquisaConta.DataSource = this.bsoPadrao;
            this.dtgPesquisaConta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPesquisaConta.Location = new System.Drawing.Point(0, 0);
            this.dtgPesquisaConta.Name = "dtgPesquisaConta";
            this.dtgPesquisaConta.ReadOnly = true;
            this.dtgPesquisaConta.Size = new System.Drawing.Size(554, 109);
            this.dtgPesquisaConta.TabIndex = 0;
            this.dtgPesquisaConta.DoubleClick += new System.EventHandler(this.dtgPesquisaConta_DoubleClick);
            // 
            // dESCONTADataGridViewTextBoxColumn
            // 
            this.dESCONTADataGridViewTextBoxColumn.DataPropertyName = "DES_CONTA";
            this.dESCONTADataGridViewTextBoxColumn.HeaderText = "CONTA";
            this.dESCONTADataGridViewTextBoxColumn.Name = "dESCONTADataGridViewTextBoxColumn";
            this.dESCONTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATDESATIVADODataGridViewTextBoxColumn
            // 
            this.dATDESATIVADODataGridViewTextBoxColumn.DataPropertyName = "DAT_DESATIVADO";
            this.dATDESATIVADODataGridViewTextBoxColumn.HeaderText = "DESATIVADO";
            this.dATDESATIVADODataGridViewTextBoxColumn.Name = "dATDESATIVADODataGridViewTextBoxColumn";
            this.dATDESATIVADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtsConta1
            // 
            this.dtsConta1.DataSetName = "dtsConta";
            this.dtsConta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClasseDados = this.contas1;
            this.ClientSize = new System.Drawing.Size(568, 283);
            this.Name = "frmContas";
            this.Text = "Cadastro de Contas";
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.pnlResultado.ResumeLayout(false);
            this.pnlGrade.ResumeLayout(false);
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.tbcPadrao.ResumeLayout(false);
            this.gpAtivo.ResumeLayout(false);
            this.gpAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtDesativado;
        private System.Windows.Forms.GroupBox gpAtivo;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private CamadaLogica.DS.dtsConta dtsConta1;
        private System.Windows.Forms.DataGridView dtgPesquisaConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCONTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATDESATIVADODataGridViewTextBoxColumn;
        private CamadaLogica.Classes.Contas contas1;
    }
}
