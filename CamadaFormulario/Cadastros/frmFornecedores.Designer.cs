namespace CamadaFormulario.Cadastros
{
    partial class frmFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedores));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtsFornecedor1 = new CamadaLogica.DS.dtsFornecedor();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.COD_FORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMFORNECEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAT_CADASTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedores1 = new CamadaLogica.Classes.Fornecedores();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblDatCadastro = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsFornecedor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsoPadrao
            // 
            this.bsoPadrao.DataMember = "FORNECEDORES";
            this.bsoPadrao.DataSource = this.dtsFornecedor1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.label1);
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            this.tabPrincipal.Controls.Add(this.label2);
            this.tabPrincipal.Controls.Add(this.txtNome);
            this.tabPrincipal.Size = new System.Drawing.Size(530, 208);
            this.tabPrincipal.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.label2, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.txtCodigo, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.label1, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.pnlBase, 0);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Location = new System.Drawing.Point(3, 62);
            this.pnlResultado.Size = new System.Drawing.Size(524, 143);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.dataGridView1);
            this.pnlGrade.Size = new System.Drawing.Size(524, 116);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.txtNomePesquisa);
            this.pnlFiltro.Controls.Add(this.lblPesquisa);
            this.pnlFiltro.Size = new System.Drawing.Size(524, 59);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Size = new System.Drawing.Size(524, 27);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(530, 208);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(538, 234);
            // 
            // ckAtivos
            // 
            this.ckAtivos.Visible = false;
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.maskedTextBox2);
            this.pnlBase.Controls.Add(this.lblDatCadastro);
            this.pnlBase.Controls.Add(this.lblCodigo);
            this.pnlBase.Controls.Add(this.textBox1);
            this.pnlBase.Controls.Add(this.lblNome);
            this.pnlBase.Controls.Add(this.textBox2);
            this.pnlBase.Size = new System.Drawing.Size(524, 202);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_FORNECEDOR", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(17, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "NOM_FORNECEDOR", true));
            this.txtNome.Location = new System.Drawing.Point(17, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(388, 20);
            this.txtNome.TabIndex = 56;
            // 
            // dtsFornecedor1
            // 
            this.dtsFornecedor1.DataSetName = "dtsFornecedor";
            this.dtsFornecedor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(21, 27);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(322, 20);
            this.txtNomePesquisa.TabIndex = 3;
            this.txtNomePesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomePesquisa_KeyDown);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(18, 11);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(35, 13);
            this.lblPesquisa.TabIndex = 4;
            this.lblPesquisa.Text = "Nome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_FORNECEDOR,
            this.nOMFORNECEDORDataGridViewTextBoxColumn,
            this.DAT_CADASTRO});
            this.dataGridView1.DataSource = this.bsoPadrao;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 116);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // COD_FORNECEDOR
            // 
            this.COD_FORNECEDOR.DataPropertyName = "COD_FORNECEDOR";
            this.COD_FORNECEDOR.HeaderText = "CODIGO";
            this.COD_FORNECEDOR.Name = "COD_FORNECEDOR";
            this.COD_FORNECEDOR.ReadOnly = true;
            this.COD_FORNECEDOR.Width = 50;
            // 
            // nOMFORNECEDORDataGridViewTextBoxColumn
            // 
            this.nOMFORNECEDORDataGridViewTextBoxColumn.DataPropertyName = "NOM_FORNECEDOR";
            this.nOMFORNECEDORDataGridViewTextBoxColumn.HeaderText = "FORNECEDOR";
            this.nOMFORNECEDORDataGridViewTextBoxColumn.Name = "nOMFORNECEDORDataGridViewTextBoxColumn";
            this.nOMFORNECEDORDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMFORNECEDORDataGridViewTextBoxColumn.Width = 300;
            // 
            // DAT_CADASTRO
            // 
            this.DAT_CADASTRO.DataPropertyName = "DAT_CADASTRO";
            this.DAT_CADASTRO.HeaderText = "CADASTRO";
            this.DAT_CADASTRO.Name = "DAT_CADASTRO";
            this.DAT_CADASTRO.ReadOnly = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_CADASTRO", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(93, 39);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(84, 20);
            this.maskedTextBox2.TabIndex = 23;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // lblDatCadastro
            // 
            this.lblDatCadastro.AutoSize = true;
            this.lblDatCadastro.Location = new System.Drawing.Point(90, 23);
            this.lblDatCadastro.Name = "lblDatCadastro";
            this.lblDatCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDatCadastro.TabIndex = 22;
            this.lblDatCadastro.Text = "Data Cadastro";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "Código";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_FORNECEDOR", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(17, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 21;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "NOM_FORNECEDOR", true));
            this.textBox2.Location = new System.Drawing.Point(17, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 20);
            this.textBox2.TabIndex = 25;
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClasseDados = this.fornecedores1;
            this.ClientSize = new System.Drawing.Size(538, 296);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFornecedores";
            this.Text = "Cadastro de Fornecedores";
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
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsFornecedor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private CamadaLogica.DS.dtsFornecedor dtsFornecedor1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private CamadaLogica.Classes.Fornecedores fornecedores1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblDatCadastro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_FORNECEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMFORNECEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAT_CADASTRO;
    }
}
