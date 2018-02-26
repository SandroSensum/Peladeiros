namespace CamadaFormulario
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDesativado = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.dtsUsuarios1 = new CamadaLogica.DS.dtsUsuarios();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInformeNome = new System.Windows.Forms.Button();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.usuario1 = new CamadaLogica.Classes.Usuario();
            this.cODUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATDESATIVADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsUsuarios1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsoPadrao
            // 
            this.bsoPadrao.DataMember = "USUARIOS";
            this.bsoPadrao.DataSource = this.dtsUsuarios1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.lblSenha);
            this.tabPrincipal.Controls.Add(this.txtSenha);
            this.tabPrincipal.Controls.Add(this.lblUsuario);
            this.tabPrincipal.Controls.Add(this.txtUsuario);
            this.tabPrincipal.Controls.Add(this.label11);
            this.tabPrincipal.Controls.Add(this.label10);
            this.tabPrincipal.Controls.Add(this.txtDesativado);
            this.tabPrincipal.Controls.Add(this.lblCodigo);
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            this.tabPrincipal.Controls.Add(this.lblNome);
            this.tabPrincipal.Controls.Add(this.txtNome);
            this.tabPrincipal.Controls.Add(this.groupBox1);
            this.tabPrincipal.Size = new System.Drawing.Size(519, 196);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Location = new System.Drawing.Point(3, 59);
            this.pnlResultado.Size = new System.Drawing.Size(513, 134);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.dataGridView1);
            this.pnlGrade.Size = new System.Drawing.Size(513, 107);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.btnInformeNome);
            this.pnlFiltro.Controls.Add(this.txtNomePesquisa);
            this.pnlFiltro.Controls.Add(this.lbNome);
            this.pnlFiltro.Size = new System.Drawing.Size(513, 56);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Size = new System.Drawing.Size(513, 27);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(519, 196);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(527, 222);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(527, 222);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(397, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Data Desativado";
            // 
            // txtDesativado
            // 
            this.txtDesativado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_DESATIVADO", true));
            this.txtDesativado.Location = new System.Drawing.Point(400, 98);
            this.txtDesativado.Mask = "00/00/0000";
            this.txtDesativado.Name = "txtDesativado";
            this.txtDesativado.Size = new System.Drawing.Size(84, 20);
            this.txtDesativado.TabIndex = 74;
            this.txtDesativado.ValidatingType = typeof(System.DateTime);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 11);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 65;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_USUARIO", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(17, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 66;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 67;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "NOM_USUARIO", true));
            this.txtNome.Location = new System.Drawing.Point(17, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 20);
            this.txtNome.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInativo);
            this.groupBox1.Controls.Add(this.rbAtivo);
            this.groupBox1.Location = new System.Drawing.Point(400, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 52);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
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
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(17, 93);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 82;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "IDE_USUARIO", true));
            this.txtUsuario.Location = new System.Drawing.Point(17, 109);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(185, 20);
            this.txtUsuario.TabIndex = 81;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(17, 132);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 84;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "SENHA", true));
            this.txtSenha.Location = new System.Drawing.Point(17, 148);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(185, 20);
            this.txtSenha.TabIndex = 83;
            // 
            // dtsUsuarios1
            // 
            this.dtsUsuarios1.DataSetName = "dtsUsuarios";
            this.dtsUsuarios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODUSUARIODataGridViewTextBoxColumn,
            this.dATDESATIVADODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsoPadrao;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 107);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnInformeNome
            // 
            this.btnInformeNome.FlatAppearance.BorderSize = 0;
            this.btnInformeNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeNome.Image = ((System.Drawing.Image)(resources.GetObject("btnInformeNome.Image")));
            this.btnInformeNome.Location = new System.Drawing.Point(451, 24);
            this.btnInformeNome.Name = "btnInformeNome";
            this.btnInformeNome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInformeNome.Size = new System.Drawing.Size(23, 23);
            this.btnInformeNome.TabIndex = 6;
            this.btnInformeNome.UseVisualStyleBackColor = true;
            this.btnInformeNome.Click += new System.EventHandler(this.btnInformeNome_Click);
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(19, 25);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(426, 20);
            this.txtNomePesquisa.TabIndex = 4;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(16, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome";
            // 
            // cODUSUARIODataGridViewTextBoxColumn
            // 
            this.cODUSUARIODataGridViewTextBoxColumn.DataPropertyName = "COD_USUARIO";
            this.cODUSUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO";
            this.cODUSUARIODataGridViewTextBoxColumn.Name = "cODUSUARIODataGridViewTextBoxColumn";
            // 
            // dATDESATIVADODataGridViewTextBoxColumn
            // 
            this.dATDESATIVADODataGridViewTextBoxColumn.DataPropertyName = "DAT_DESATIVADO";
            this.dATDESATIVADODataGridViewTextBoxColumn.HeaderText = "DESATIVADO";
            this.dATDESATIVADODataGridViewTextBoxColumn.Name = "dATDESATIVADODataGridViewTextBoxColumn";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClasseDados = this.usuario1;
            this.ClientSize = new System.Drawing.Size(527, 284);
            this.Name = "frmUsuario";
            this.Text = "Cadastro de Usuarios";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsUsuarios1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtDesativado;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private CamadaLogica.DS.dtsUsuarios dtsUsuarios1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInformeNome;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Label lbNome;
        private CamadaLogica.Classes.Usuario usuario1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATDESATIVADODataGridViewTextBoxColumn;
    }
}