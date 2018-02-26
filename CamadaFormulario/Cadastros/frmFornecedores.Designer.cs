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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtsFornecedor1 = new CamadaLogica.DS.dtsFornecedor();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nOMFORNECEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
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
            // 
            // pnlResultado
            // 
            this.pnlResultado.Location = new System.Drawing.Point(3, 62);
            this.pnlResultado.Size = new System.Drawing.Size(501, 76);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.dataGridView1);
            this.pnlGrade.Size = new System.Drawing.Size(501, 49);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.txtNomePesquisa);
            this.pnlFiltro.Controls.Add(this.lblPesquisa);
            this.pnlFiltro.Size = new System.Drawing.Size(501, 59);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Size = new System.Drawing.Size(501, 27);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(507, 141);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(515, 167);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(515, 167);
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
            this.nOMFORNECEDORDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsoPadrao;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(501, 49);
            this.dataGridView1.TabIndex = 0;
            // 
            // nOMFORNECEDORDataGridViewTextBoxColumn
            // 
            this.nOMFORNECEDORDataGridViewTextBoxColumn.DataPropertyName = "NOM_FORNECEDOR";
            this.nOMFORNECEDORDataGridViewTextBoxColumn.HeaderText = "FORNECEDOR";
            this.nOMFORNECEDORDataGridViewTextBoxColumn.Name = "nOMFORNECEDORDataGridViewTextBoxColumn";
            this.nOMFORNECEDORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(515, 229);
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
            this.panel3.ResumeLayout(false);
            this.tbcPadrao.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMFORNECEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Label lblPesquisa;
    }
}
