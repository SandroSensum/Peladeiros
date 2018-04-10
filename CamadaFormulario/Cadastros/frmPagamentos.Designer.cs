namespace CamadaFormulario.Cadastros
{
    partial class frmPagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamentos));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ckMensalista = new System.Windows.Forms.CheckBox();
            this.btnInformeNome = new System.Windows.Forms.Button();
            this.scDataGridView1 = new CamadaComponente.Componentes.scDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.btnInformeNome);
            this.tabPrincipal.Controls.Add(this.ckMensalista);
            this.tabPrincipal.Controls.Add(this.txtNome);
            this.tabPrincipal.Controls.Add(this.label4);
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
            this.tabPrincipal.Size = new System.Drawing.Size(505, 239);
            this.tabPrincipal.Controls.SetChildIndex(this.lbl_jogador, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.lblReferencia, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.lblValor, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.lblPgto, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.txtPgto, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.txtReferencia, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.label1, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.lblCadastro, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.txtCadastro, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.txtCodigo, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.cboJogador, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.txtValor, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.label2, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.comboBox1, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.label3, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.maskedTextBox1, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.label4, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.ckMensalista, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.btnInformeNome, 0);
            this.tabPrincipal.Controls.SetChildIndex(this.pnlBase, 0);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Location = new System.Drawing.Point(3, 70);
            this.pnlResultado.Size = new System.Drawing.Size(499, 166);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.scDataGridView1);
            this.pnlGrade.Size = new System.Drawing.Size(499, 139);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Size = new System.Drawing.Size(499, 67);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Size = new System.Drawing.Size(499, 27);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(505, 239);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(513, 265);
            // 
            // pnlBase
            // 
            this.pnlBase.Size = new System.Drawing.Size(499, 233);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 21);
            this.comboBox1.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Conta Corrente";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(33, 206);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(114, 20);
            this.txtValor.TabIndex = 62;
            // 
            // cboJogador
            // 
            this.cboJogador.FormattingEnabled = true;
            this.cboJogador.Location = new System.Drawing.Point(33, 84);
            this.cboJogador.Name = "cboJogador";
            this.cboJogador.Size = new System.Drawing.Size(280, 21);
            this.cboJogador.TabIndex = 59;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(33, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 60;
            // 
            // txtCadastro
            // 
            this.txtCadastro.Location = new System.Drawing.Point(352, 34);
            this.txtCadastro.Mask = "00/00/0000";
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(84, 20);
            this.txtCadastro.TabIndex = 70;
            this.txtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(349, 18);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblCadastro.TabIndex = 69;
            this.lblCadastro.Text = "Data Cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Código";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(322, 166);
            this.txtReferencia.Mask = "00/0000";
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(70, 20);
            this.txtReferencia.TabIndex = 61;
            // 
            // txtPgto
            // 
            this.txtPgto.Location = new System.Drawing.Point(153, 206);
            this.txtPgto.Mask = "00/00/0000";
            this.txtPgto.Name = "txtPgto";
            this.txtPgto.Size = new System.Drawing.Size(84, 20);
            this.txtPgto.TabIndex = 67;
            this.txtPgto.ValidatingType = typeof(System.DateTime);
            // 
            // lblPgto
            // 
            this.lblPgto.AutoSize = true;
            this.lblPgto.Location = new System.Drawing.Point(150, 190);
            this.lblPgto.Name = "lblPgto";
            this.lblPgto.Size = new System.Drawing.Size(87, 13);
            this.lblPgto.TabIndex = 66;
            this.lblPgto.Text = "Data Pagamento";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(30, 190);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 65;
            this.lblValor.Text = "Valor";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(319, 150);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(59, 13);
            this.lblReferencia.TabIndex = 64;
            this.lblReferencia.Text = "Referencia";
            // 
            // lbl_jogador
            // 
            this.lbl_jogador.AutoSize = true;
            this.lbl_jogador.Location = new System.Drawing.Point(30, 68);
            this.lbl_jogador.Name = "lbl_jogador";
            this.lbl_jogador.Size = new System.Drawing.Size(49, 13);
            this.lbl_jogador.TabIndex = 63;
            this.lbl_jogador.Text = "Despesa";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(322, 124);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(114, 20);
            this.maskedTextBox1.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "NF ou Coupm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Fornecedor";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "NOM_JOGADOR", true));
            this.txtNome.Location = new System.Drawing.Point(36, 124);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 20);
            this.txtNome.TabIndex = 77;
            // 
            // ckMensalista
            // 
            this.ckMensalista.AutoSize = true;
            this.ckMensalista.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsoPadrao, "LGC_MENSALISTA", true));
            this.ckMensalista.Location = new System.Drawing.Point(322, 84);
            this.ckMensalista.Name = "ckMensalista";
            this.ckMensalista.Size = new System.Drawing.Size(95, 17);
            this.ckMensalista.TabIndex = 79;
            this.ckMensalista.Text = "Coparticpação";
            this.ckMensalista.UseVisualStyleBackColor = true;
            // 
            // btnInformeNome
            // 
            this.btnInformeNome.FlatAppearance.BorderSize = 0;
            this.btnInformeNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeNome.Image = ((System.Drawing.Image)(resources.GetObject("btnInformeNome.Image")));
            this.btnInformeNome.Location = new System.Drawing.Point(413, 82);
            this.btnInformeNome.Name = "btnInformeNome";
            this.btnInformeNome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInformeNome.Size = new System.Drawing.Size(23, 23);
            this.btnInformeNome.TabIndex = 80;
            this.btnInformeNome.UseVisualStyleBackColor = true;
            // 
            // scDataGridView1
            // 
            this.scDataGridView1.AllowUserToAddRows = false;
            this.scDataGridView1.AllowUserToDeleteRows = false;
            this.scDataGridView1.AutoGenerateColumns = false;
            this.scDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scDataGridView1.DataSource = this.bsoPadrao;
            this.scDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.scDataGridView1.Name = "scDataGridView1";
            this.scDataGridView1.ReadOnly = true;
            this.scDataGridView1.Size = new System.Drawing.Size(499, 139);
            this.scDataGridView1.TabIndex = 0;
            // 
            // frmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(513, 327);
            this.Name = "frmPagamentos";
            this.Text = "Pagamentos";
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.pnlResultado.ResumeLayout(false);
            this.pnlGrade.ResumeLayout(false);
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.tbcPadrao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox ckMensalista;
        private System.Windows.Forms.Button btnInformeNome;
        private CamadaComponente.Componentes.scDataGridView scDataGridView1;
    }
}
