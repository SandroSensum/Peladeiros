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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContas));
            this.cpAtivoInativo1 = new CamadaComponente.Componentes.cpAtivoInativo();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lbl_jogador = new System.Windows.Forms.Label();
            this.dtsConta1 = new CamadaLogica.DS.dtsConta();
            this.scDataGridView1 = new CamadaComponente.Componentes.scDataGridView();
            this.cODCONTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCONTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESBANCODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGENCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATCADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATDESATIVADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contas1 = new CamadaLogica.Classes.Contas();
            this.gpBanco = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new CamadaComponente.Componentes.scTextBox();
            this.txtCC = new CamadaComponente.Componentes.scTextBox();
            this.txtAgencia = new CamadaComponente.Componentes.scTextBox();
            this.txtBanco = new CamadaComponente.Componentes.scTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.txtDescricao = new CamadaComponente.Componentes.scTextBox();
            this.txtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.ckBanco = new CamadaComponente.Componentes.scCheckbox();
            this.txtContaPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scDataGridView1)).BeginInit();
            this.gpBanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsoPadrao
            // 
            this.bsoPadrao.DataMember = "CONTAS";
            this.bsoPadrao.DataSource = this.dtsConta1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Size = new System.Drawing.Size(604, 260);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Location = new System.Drawing.Point(3, 63);
            this.pnlResultado.Size = new System.Drawing.Size(598, 194);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.scDataGridView1);
            this.pnlGrade.Size = new System.Drawing.Size(598, 167);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.txtContaPesquisa);
            this.pnlFiltro.Controls.Add(this.lblPesquisa);
            this.pnlFiltro.Size = new System.Drawing.Size(598, 60);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Size = new System.Drawing.Size(598, 27);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(604, 260);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(612, 286);
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.ckBanco);
            this.pnlBase.Controls.Add(this.txtDescricao);
            this.pnlBase.Controls.Add(this.gpBanco);
            this.pnlBase.Controls.Add(this.cpAtivoInativo1);
            this.pnlBase.Controls.Add(this.txtCodigo);
            this.pnlBase.Controls.Add(this.txtCadastro);
            this.pnlBase.Controls.Add(this.lblCadastro);
            this.pnlBase.Controls.Add(this.lblCodigo);
            this.pnlBase.Controls.Add(this.lbl_jogador);
            this.pnlBase.Size = new System.Drawing.Size(598, 254);
            // 
            // cpAtivoInativo1
            // 
            this.cpAtivoInativo1.bsoAtivoInativo = this.bsoPadrao;
            this.cpAtivoInativo1.Location = new System.Drawing.Point(410, 17);
            this.cpAtivoInativo1.Name = "cpAtivoInativo1";
            this.cpAtivoInativo1.NomeCampo = "DAT_DESATIVADO";
            this.cpAtivoInativo1.Size = new System.Drawing.Size(100, 107);
            this.cpAtivoInativo1.TabIndex = 55;
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_CONTA", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(21, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 43;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(96, 17);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblCadastro.TabIndex = 44;
            this.lblCadastro.Text = "Data Cadastro";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 17);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 42;
            this.lblCodigo.Text = "Código";
            // 
            // lbl_jogador
            // 
            this.lbl_jogador.AutoSize = true;
            this.lbl_jogador.Location = new System.Drawing.Point(21, 56);
            this.lbl_jogador.Name = "lbl_jogador";
            this.lbl_jogador.Size = new System.Drawing.Size(100, 13);
            this.lbl_jogador.TabIndex = 46;
            this.lbl_jogador.Text = "Descrição da conta";
            // 
            // dtsConta1
            // 
            this.dtsConta1.DataSetName = "dtsConta";
            this.dtsConta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scDataGridView1
            // 
            this.scDataGridView1.AllowUserToAddRows = false;
            this.scDataGridView1.AllowUserToDeleteRows = false;
            this.scDataGridView1.AutoGenerateColumns = false;
            this.scDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCONTADataGridViewTextBoxColumn,
            this.dESCONTADataGridViewTextBoxColumn,
            this.dESBANCODataGridViewTextBoxColumn,
            this.aGENCIADataGridViewTextBoxColumn,
            this.cCDataGridViewTextBoxColumn,
            this.dATCADASTRODataGridViewTextBoxColumn,
            this.dATDESATIVADODataGridViewTextBoxColumn});
            this.scDataGridView1.DataSource = this.bsoPadrao;
            this.scDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.scDataGridView1.Name = "scDataGridView1";
            this.scDataGridView1.ReadOnly = true;
            this.scDataGridView1.Size = new System.Drawing.Size(598, 167);
            this.scDataGridView1.TabIndex = 0;
            // 
            // cODCONTADataGridViewTextBoxColumn
            // 
            this.cODCONTADataGridViewTextBoxColumn.DataPropertyName = "COD_CONTA";
            this.cODCONTADataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.cODCONTADataGridViewTextBoxColumn.Name = "cODCONTADataGridViewTextBoxColumn";
            this.cODCONTADataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCONTADataGridViewTextBoxColumn.Width = 50;
            // 
            // dESCONTADataGridViewTextBoxColumn
            // 
            this.dESCONTADataGridViewTextBoxColumn.DataPropertyName = "DES_CONTA";
            this.dESCONTADataGridViewTextBoxColumn.HeaderText = "DESCRICAO";
            this.dESCONTADataGridViewTextBoxColumn.Name = "dESCONTADataGridViewTextBoxColumn";
            this.dESCONTADataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCONTADataGridViewTextBoxColumn.Width = 300;
            // 
            // dESBANCODataGridViewTextBoxColumn
            // 
            this.dESBANCODataGridViewTextBoxColumn.DataPropertyName = "DES_BANCO";
            this.dESBANCODataGridViewTextBoxColumn.HeaderText = "BANCO";
            this.dESBANCODataGridViewTextBoxColumn.Name = "dESBANCODataGridViewTextBoxColumn";
            this.dESBANCODataGridViewTextBoxColumn.ReadOnly = true;
            this.dESBANCODataGridViewTextBoxColumn.Width = 300;
            // 
            // aGENCIADataGridViewTextBoxColumn
            // 
            this.aGENCIADataGridViewTextBoxColumn.DataPropertyName = "AGENCIA";
            this.aGENCIADataGridViewTextBoxColumn.HeaderText = "AGENCIA";
            this.aGENCIADataGridViewTextBoxColumn.Name = "aGENCIADataGridViewTextBoxColumn";
            this.aGENCIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCDataGridViewTextBoxColumn
            // 
            this.cCDataGridViewTextBoxColumn.DataPropertyName = "CC";
            this.cCDataGridViewTextBoxColumn.HeaderText = "CC";
            this.cCDataGridViewTextBoxColumn.Name = "cCDataGridViewTextBoxColumn";
            this.cCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATCADASTRODataGridViewTextBoxColumn
            // 
            this.dATCADASTRODataGridViewTextBoxColumn.DataPropertyName = "DAT_CADASTRO";
            this.dATCADASTRODataGridViewTextBoxColumn.HeaderText = "CADASTRO";
            this.dATCADASTRODataGridViewTextBoxColumn.Name = "dATCADASTRODataGridViewTextBoxColumn";
            this.dATCADASTRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATDESATIVADODataGridViewTextBoxColumn
            // 
            this.dATDESATIVADODataGridViewTextBoxColumn.DataPropertyName = "DAT_DESATIVADO";
            this.dATDESATIVADODataGridViewTextBoxColumn.HeaderText = "DESATIVADO";
            this.dATDESATIVADODataGridViewTextBoxColumn.Name = "dATDESATIVADODataGridViewTextBoxColumn";
            this.dATDESATIVADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gpBanco
            // 
            this.gpBanco.Controls.Add(this.txtSaldo);
            this.gpBanco.Controls.Add(this.txtCC);
            this.gpBanco.Controls.Add(this.txtAgencia);
            this.gpBanco.Controls.Add(this.txtBanco);
            this.gpBanco.Controls.Add(this.label2);
            this.gpBanco.Controls.Add(this.label1);
            this.gpBanco.Controls.Add(this.lblSaldo);
            this.gpBanco.Controls.Add(this.lblConta);
            this.gpBanco.Location = new System.Drawing.Point(21, 116);
            this.gpBanco.Name = "gpBanco";
            this.gpBanco.Size = new System.Drawing.Size(383, 118);
            this.gpBanco.TabIndex = 56;
            this.gpBanco.TabStop = false;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(259, 82);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(117, 20);
            this.txtSaldo.TabIndex = 67;
            // 
            // txtCC
            // 
            this.txtCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "CC", true));
            this.txtCC.Location = new System.Drawing.Point(76, 82);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(84, 20);
            this.txtCC.TabIndex = 66;
            // 
            // txtAgencia
            // 
            this.txtAgencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "AGENCIA", true));
            this.txtAgencia.Location = new System.Drawing.Point(6, 82);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(64, 20);
            this.txtAgencia.TabIndex = 65;
            // 
            // txtBanco
            // 
            this.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBanco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DES_BANCO", true));
            this.txtBanco.Location = new System.Drawing.Point(6, 43);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(371, 20);
            this.txtBanco.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Banco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "C/C";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(256, 66);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(80, 13);
            this.lblSaldo.TabIndex = 56;
            this.lblSaldo.Text = "Saldo da Conta";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(6, 66);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(46, 13);
            this.lblConta.TabIndex = 55;
            this.lblConta.Text = "Agencia";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DES_CONTA", true));
            this.txtDescricao.Location = new System.Drawing.Point(21, 72);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(377, 20);
            this.txtDescricao.TabIndex = 57;
            // 
            // txtCadastro
            // 
            this.txtCadastro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_CADASTRO", true));
            this.txtCadastro.Enabled = false;
            this.txtCadastro.Location = new System.Drawing.Point(97, 33);
            this.txtCadastro.Mask = "00/00/0000";
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.ReadOnly = true;
            this.txtCadastro.Size = new System.Drawing.Size(84, 20);
            this.txtCadastro.TabIndex = 45;
            this.txtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // ckBanco
            // 
            this.ckBanco.AutoSize = true;
            this.ckBanco.Location = new System.Drawing.Point(22, 105);
            this.ckBanco.Name = "ckBanco";
            this.ckBanco.Size = new System.Drawing.Size(99, 17);
            this.ckBanco.TabIndex = 64;
            this.ckBanco.Text = "Conta Bancária";
            this.ckBanco.UseVisualStyleBackColor = true;
            this.ckBanco.CheckedChanged += new System.EventHandler(this.ckBanco_CheckedChanged);
            // 
            // txtContaPesquisa
            // 
            this.txtContaPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContaPesquisa.Location = new System.Drawing.Point(20, 26);
            this.txtContaPesquisa.Name = "txtContaPesquisa";
            this.txtContaPesquisa.Size = new System.Drawing.Size(322, 20);
            this.txtContaPesquisa.TabIndex = 5;
            this.txtContaPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContaPesquisa_KeyDown);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(17, 10);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(35, 13);
            this.lblPesquisa.TabIndex = 6;
            this.lblPesquisa.Text = "Conta";
            // 
            // frmContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClasseDados = this.contas1;
            this.ClientSize = new System.Drawing.Size(612, 348);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContas";
            this.Text = "frmContas";
            this.Load += new System.EventHandler(this.frmContas_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtsConta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scDataGridView1)).EndInit();
            this.gpBanco.ResumeLayout(false);
            this.gpBanco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CamadaComponente.Componentes.cpAtivoInativo cpAtivoInativo1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lbl_jogador;
        private CamadaLogica.DS.dtsConta dtsConta1;
        private CamadaComponente.Componentes.scDataGridView scDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCONTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCONTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESBANCODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGENCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATCADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATDESATIVADODataGridViewTextBoxColumn;
        private CamadaLogica.Classes.Contas contas1;
        private System.Windows.Forms.GroupBox gpBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblConta;
        private CamadaComponente.Componentes.scTextBox txtDescricao;
        private CamadaComponente.Componentes.scTextBox txtSaldo;
        private CamadaComponente.Componentes.scTextBox txtCC;
        private CamadaComponente.Componentes.scTextBox txtAgencia;
        private CamadaComponente.Componentes.scTextBox txtBanco;
        private System.Windows.Forms.MaskedTextBox txtCadastro;
        private CamadaComponente.Componentes.scCheckbox ckBanco;
        private System.Windows.Forms.TextBox txtContaPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
    }
}
