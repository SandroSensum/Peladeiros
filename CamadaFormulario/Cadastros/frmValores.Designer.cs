namespace CamadaFormulario.Cadastros
{
    partial class frmValores
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
            System.Windows.Forms.Label lblCadastro;
            System.Windows.Forms.Label lblValor;
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.txtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.dtsValor1 = new CamadaLogica.DS.dtsValor();
            this.txtReferencia = new System.Windows.Forms.MaskedTextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.valor1 = new CamadaLogica.Classes.Valor();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODVALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATVALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATCADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValorPesquisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            lblCadastro = new System.Windows.Forms.Label();
            lblValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsValor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsoPadrao
            // 
            this.bsoPadrao.DataMember = "VALOR";
            this.bsoPadrao.DataSource = this.dtsValor1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.txtReferencia);
            this.tabPrincipal.Controls.Add(this.lblReferencia);
            this.tabPrincipal.Controls.Add(this.txtValor);
            this.tabPrincipal.Controls.Add(this.txtCadastro);
            this.tabPrincipal.Controls.Add(lblCadastro);
            this.tabPrincipal.Controls.Add(lblValor);
            this.tabPrincipal.Controls.Add(this.lblCodigo);
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            this.tabPrincipal.Size = new System.Drawing.Size(502, 139);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Location = new System.Drawing.Point(3, 59);
            this.pnlResultado.Size = new System.Drawing.Size(496, 136);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.dataGridView1);
            this.pnlGrade.Size = new System.Drawing.Size(496, 109);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.txtValorPesquisa);
            this.pnlFiltro.Controls.Add(this.label5);
            this.pnlFiltro.Size = new System.Drawing.Size(496, 56);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Size = new System.Drawing.Size(496, 27);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(502, 198);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(510, 224);
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Location = new System.Drawing.Point(95, 15);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new System.Drawing.Size(75, 13);
            lblCadastro.TabIndex = 63;
            lblCadastro.Text = "Data Cadastro";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new System.Drawing.Point(19, 56);
            lblValor.Name = "lblValor";
            lblValor.Size = new System.Drawing.Size(31, 13);
            lblValor.TabIndex = 62;
            lblValor.Text = "Valor";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 56;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_VALOR", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(20, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 57;
            // 
            // txtValor
            // 
            this.txtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_VALOR", true));
            this.txtValor.Location = new System.Drawing.Point(20, 72);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(97, 20);
            this.txtValor.TabIndex = 60;
            // 
            // txtCadastro
            // 
            this.txtCadastro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_CADASTRO", true));
            this.txtCadastro.Enabled = false;
            this.txtCadastro.Location = new System.Drawing.Point(98, 31);
            this.txtCadastro.Mask = "00/00/0000";
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.ReadOnly = true;
            this.txtCadastro.Size = new System.Drawing.Size(84, 20);
            this.txtCadastro.TabIndex = 64;
            this.txtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // dtsValor1
            // 
            this.dtsValor1.DataSetName = "dtsValor";
            this.dtsValor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtReferencia
            // 
            this.txtReferencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_VALOR", true));
            this.txtReferencia.Location = new System.Drawing.Point(126, 72);
            this.txtReferencia.Mask = "00/0000";
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(70, 20);
            this.txtReferencia.TabIndex = 66;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(123, 56);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(59, 13);
            this.lblReferencia.TabIndex = 67;
            this.lblReferencia.Text = "Referencia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODVALORDataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.dATVALORDataGridViewTextBoxColumn,
            this.dATCADASTRODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsoPadrao;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(496, 109);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // cODVALORDataGridViewTextBoxColumn
            // 
            this.cODVALORDataGridViewTextBoxColumn.DataPropertyName = "COD_VALOR";
            this.cODVALORDataGridViewTextBoxColumn.HeaderText = "COD_VALOR";
            this.cODVALORDataGridViewTextBoxColumn.Name = "cODVALORDataGridViewTextBoxColumn";
            this.cODVALORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            this.vALORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATVALORDataGridViewTextBoxColumn
            // 
            this.dATVALORDataGridViewTextBoxColumn.DataPropertyName = "DAT_VALOR";
            this.dATVALORDataGridViewTextBoxColumn.HeaderText = "DAT_VALOR";
            this.dATVALORDataGridViewTextBoxColumn.Name = "dATVALORDataGridViewTextBoxColumn";
            this.dATVALORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATCADASTRODataGridViewTextBoxColumn
            // 
            this.dATCADASTRODataGridViewTextBoxColumn.DataPropertyName = "DAT_CADASTRO";
            this.dATCADASTRODataGridViewTextBoxColumn.HeaderText = "DAT_CADASTRO";
            this.dATCADASTRODataGridViewTextBoxColumn.Name = "dATCADASTRODataGridViewTextBoxColumn";
            this.dATCADASTRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtValorPesquisa
            // 
            this.txtValorPesquisa.Location = new System.Drawing.Point(16, 25);
            this.txtValorPesquisa.Name = "txtValorPesquisa";
            this.txtValorPesquisa.Size = new System.Drawing.Size(59, 20);
            this.txtValorPesquisa.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Valor";
            // 
            // frmValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClasseDados = this.valor1;
            this.ClientSize = new System.Drawing.Size(510, 286);
            this.Name = "frmValores";
            this.Text = "Cadastro de Valores";
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.pnlResultado.ResumeLayout(false);
            this.pnlGrade.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.tbcPadrao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtsValor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.MaskedTextBox txtCadastro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private CamadaLogica.DS.dtsValor dtsValor1;
        private System.Windows.Forms.MaskedTextBox txtReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private CamadaLogica.Classes.Valor valor1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODVALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATVALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATCADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtValorPesquisa;
        private System.Windows.Forms.Label label5;
    }
}
