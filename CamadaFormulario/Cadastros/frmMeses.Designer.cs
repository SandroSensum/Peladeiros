namespace CamadaFormulario.Cadastros
{
    partial class frmMeses
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
            this.txtMes = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.dtsMes1 = new CamadaLogica.DS.dtsMes();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDEMESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEANODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMesPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisaMes = new System.Windows.Forms.Label();
            this.txtAnoPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisaAno = new System.Windows.Forms.Label();
            this.mes1 = new CamadaLogica.Classes.Mes();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsMes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsoPadrao
            // 
            this.bsoPadrao.DataMember = "MES";
            this.bsoPadrao.DataSource = this.dtsMes1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.txtMes);
            this.tabPrincipal.Controls.Add(this.lblMes);
            this.tabPrincipal.Controls.Add(this.txtAno);
            this.tabPrincipal.Controls.Add(this.label1);
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            this.tabPrincipal.Controls.Add(this.lblAno);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Location = new System.Drawing.Point(3, 58);
            this.pnlResultado.Size = new System.Drawing.Size(492, 104);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.dataGridView1);
            this.pnlGrade.Size = new System.Drawing.Size(492, 77);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.txtAnoPesquisa);
            this.pnlFiltro.Controls.Add(this.lblPesquisaAno);
            this.pnlFiltro.Controls.Add(this.txtMesPesquisa);
            this.pnlFiltro.Controls.Add(this.lblPesquisaMes);
            this.pnlFiltro.Size = new System.Drawing.Size(492, 55);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Size = new System.Drawing.Size(492, 27);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(498, 165);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(506, 191);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(506, 191);
            // 
            // txtMes
            // 
            this.txtMes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "IDE_MES", true));
            this.txtMes.Location = new System.Drawing.Point(23, 82);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(39, 20);
            this.txtMes.TabIndex = 36;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(23, 66);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 37;
            this.lblMes.Text = "Mes";
            // 
            // txtAno
            // 
            this.txtAno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "IDE_ANO", true));
            this.txtAno.Location = new System.Drawing.Point(23, 121);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(53, 20);
            this.txtAno.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_MES", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(22, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 34;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(23, 105);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 35;
            this.lblAno.Text = "Ano";
            // 
            // dtsMes1
            // 
            this.dtsMes1.DataSetName = "dtsMes";
            this.dtsMes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEMESDataGridViewTextBoxColumn,
            this.iDEANODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsoPadrao;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(492, 77);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDEMESDataGridViewTextBoxColumn
            // 
            this.iDEMESDataGridViewTextBoxColumn.DataPropertyName = "IDE_MES";
            this.iDEMESDataGridViewTextBoxColumn.HeaderText = "MES";
            this.iDEMESDataGridViewTextBoxColumn.Name = "iDEMESDataGridViewTextBoxColumn";
            this.iDEMESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDEANODataGridViewTextBoxColumn
            // 
            this.iDEANODataGridViewTextBoxColumn.DataPropertyName = "IDE_ANO";
            this.iDEANODataGridViewTextBoxColumn.HeaderText = "ANO";
            this.iDEANODataGridViewTextBoxColumn.Name = "iDEANODataGridViewTextBoxColumn";
            this.iDEANODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtMesPesquisa
            // 
            this.txtMesPesquisa.Location = new System.Drawing.Point(20, 27);
            this.txtMesPesquisa.Name = "txtMesPesquisa";
            this.txtMesPesquisa.Size = new System.Drawing.Size(32, 20);
            this.txtMesPesquisa.TabIndex = 1;
            // 
            // lblPesquisaMes
            // 
            this.lblPesquisaMes.AutoSize = true;
            this.lblPesquisaMes.Location = new System.Drawing.Point(17, 11);
            this.lblPesquisaMes.Name = "lblPesquisaMes";
            this.lblPesquisaMes.Size = new System.Drawing.Size(27, 13);
            this.lblPesquisaMes.TabIndex = 2;
            this.lblPesquisaMes.Text = "Mês";
            // 
            // txtAnoPesquisa
            // 
            this.txtAnoPesquisa.Location = new System.Drawing.Point(77, 27);
            this.txtAnoPesquisa.Name = "txtAnoPesquisa";
            this.txtAnoPesquisa.Size = new System.Drawing.Size(47, 20);
            this.txtAnoPesquisa.TabIndex = 3;
            // 
            // lblPesquisaAno
            // 
            this.lblPesquisaAno.AutoSize = true;
            this.lblPesquisaAno.Location = new System.Drawing.Point(74, 11);
            this.lblPesquisaAno.Name = "lblPesquisaAno";
            this.lblPesquisaAno.Size = new System.Drawing.Size(26, 13);
            this.lblPesquisaAno.TabIndex = 4;
            this.lblPesquisaAno.Text = "Ano";
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClasseDados = this.mes1;
            this.ClientSize = new System.Drawing.Size(506, 253);
            this.Name = "frmMeses";
            this.Text = "Cadastro de Meses";
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
            ((System.ComponentModel.ISupportInitialize)(this.dtsMes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblAno;
        private CamadaLogica.DS.dtsMes dtsMes1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEMESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEANODataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAnoPesquisa;
        private System.Windows.Forms.Label lblPesquisaAno;
        private System.Windows.Forms.TextBox txtMesPesquisa;
        private System.Windows.Forms.Label lblPesquisaMes;
        private CamadaLogica.Classes.Mes mes1;
    }
}
