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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtsValor1 = new CamadaLogica.DS.dtsValor();
            this.valor1 = new CamadaLogica.Classes.Valor();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODVALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATVALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATCADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.valor2 = new CamadaLogica.Classes.Valor();
            this.txtReferencia = new System.Windows.Forms.MaskedTextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.txtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.scMaskValor1 = new CamadaComponente.Componentes.scMaskValor();
            this.txtValorPesquisa = new System.Windows.Forms.MaskedTextBox();
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
            this.pnlBase.SuspendLayout();
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
            this.tabPrincipal.Size = new System.Drawing.Size(503, 201);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Location = new System.Drawing.Point(3, 59);
            this.pnlResultado.Size = new System.Drawing.Size(497, 139);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.dataGridView1);
            this.pnlGrade.Size = new System.Drawing.Size(497, 112);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.txtValorPesquisa);
            this.pnlFiltro.Controls.Add(this.lblPesquisa);
            this.pnlFiltro.Size = new System.Drawing.Size(497, 56);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Size = new System.Drawing.Size(497, 27);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(503, 201);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(511, 227);
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.scMaskValor1);
            this.pnlBase.Controls.Add(this.txtReferencia);
            this.pnlBase.Controls.Add(this.lblReferencia);
            this.pnlBase.Controls.Add(this.txtCadastro);
            this.pnlBase.Controls.Add(lblCadastro);
            this.pnlBase.Controls.Add(lblValor);
            this.pnlBase.Controls.Add(this.lblCodigo);
            this.pnlBase.Controls.Add(this.txtCodigo);
            this.pnlBase.Size = new System.Drawing.Size(497, 195);
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Location = new System.Drawing.Point(90, 11);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new System.Drawing.Size(75, 13);
            lblCadastro.TabIndex = 2;
            lblCadastro.Text = "Data Cadastro";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new System.Drawing.Point(14, 52);
            lblValor.Name = "lblValor";
            lblValor.Size = new System.Drawing.Size(31, 13);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor";
            // 
            // dtsValor1
            // 
            this.dtsValor1.DataSetName = "dtsValor";
            this.dtsValor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dataGridView1.Size = new System.Drawing.Size(497, 112);
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
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0,00";
            this.vALORDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.vALORDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            this.vALORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATVALORDataGridViewTextBoxColumn
            // 
            this.dATVALORDataGridViewTextBoxColumn.DataPropertyName = "DAT_VALOR";
            dataGridViewCellStyle2.Format = "00/0000";
            dataGridViewCellStyle2.NullValue = "00/0000";
            this.dATVALORDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dATVALORDataGridViewTextBoxColumn.HeaderText = "DAT_VALOR";
            this.dATVALORDataGridViewTextBoxColumn.Name = "dATVALORDataGridViewTextBoxColumn";
            this.dATVALORDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATVALORDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dATCADASTRODataGridViewTextBoxColumn
            // 
            this.dATCADASTRODataGridViewTextBoxColumn.DataPropertyName = "DAT_CADASTRO";
            this.dATCADASTRODataGridViewTextBoxColumn.HeaderText = "DAT_CADASTRO";
            this.dATCADASTRODataGridViewTextBoxColumn.Name = "dATCADASTRODataGridViewTextBoxColumn";
            this.dATCADASTRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(13, 9);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(51, 13);
            this.lblPesquisa.TabIndex = 2;
            this.lblPesquisa.Text = "Mês/Ano";
            // 
            // txtReferencia
            // 
            this.txtReferencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_VALOR", true));
            this.txtReferencia.Location = new System.Drawing.Point(15, 107);
            this.txtReferencia.Mask = "00/0000";
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(70, 20);
            this.txtReferencia.TabIndex = 7;
            this.txtReferencia.Leave += new System.EventHandler(this.txtReferencia_Leave);
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(15, 91);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(59, 13);
            this.lblReferencia.TabIndex = 6;
            this.lblReferencia.Text = "Referencia";
            // 
            // txtCadastro
            // 
            this.txtCadastro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_CADASTRO", true));
            this.txtCadastro.Enabled = false;
            this.txtCadastro.Location = new System.Drawing.Point(93, 27);
            this.txtCadastro.Mask = "00/00/0000";
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.ReadOnly = true;
            this.txtCadastro.Size = new System.Drawing.Size(84, 20);
            this.txtCadastro.TabIndex = 3;
            this.txtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 11);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_VALOR", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(15, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // scMaskValor1
            // 
            this.scMaskValor1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "VALOR", true));
            this.scMaskValor1.Desabilitar = false;
            this.scMaskValor1.Location = new System.Drawing.Point(15, 68);
            this.scMaskValor1.Mask = "00.00";
            this.scMaskValor1.Name = "scMaskValor1";
            this.scMaskValor1.Size = new System.Drawing.Size(70, 20);
            this.scMaskValor1.TabIndex = 5;
            this.scMaskValor1.Text = "000";
            // 
            // txtValorPesquisa
            // 
            this.txtValorPesquisa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_VALOR", true));
            this.txtValorPesquisa.Location = new System.Drawing.Point(16, 25);
            this.txtValorPesquisa.Mask = "00/0000";
            this.txtValorPesquisa.Name = "txtValorPesquisa";
            this.txtValorPesquisa.Size = new System.Drawing.Size(70, 20);
            this.txtValorPesquisa.TabIndex = 8;
            // 
            // frmValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClasseDados = this.valor1;
            this.ClientSize = new System.Drawing.Size(511, 289);
            this.Name = "frmValores";
            this.Text = "Cadastro de Valores";
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
            ((System.ComponentModel.ISupportInitialize)(this.dtsValor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CamadaLogica.DS.dtsValor dtsValor1;
        private CamadaLogica.Classes.Valor valor1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPesquisa;
        private CamadaLogica.Classes.Valor valor2;
        private System.Windows.Forms.MaskedTextBox txtReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.MaskedTextBox txtCadastro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private CamadaComponente.Componentes.scMaskValor scMaskValor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODVALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATVALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATCADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox txtValorPesquisa;
    }
}
