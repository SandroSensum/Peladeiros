namespace CamadaFormulario.Cadastros
{
    partial class frmJogador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogador));
            this.jogador1 = new CamadaLogica.Classes.Jogador();
            this.dtsJogador1 = new CamadaLogica.DS.dtsJogador();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDesativado = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblCelular1 = new System.Windows.Forms.Label();
            this.lblCelular2 = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular1 = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular2 = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.ckEnviaEmail = new System.Windows.Forms.CheckBox();
            this.ckMensalista = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtgResultpesquisa = new System.Windows.Forms.DataGridView();
            this.cODJOGADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMJOGADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATNASCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSJOGADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATCADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATDESATIVADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cELULAR1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cELULAR2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lGCENVIAEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lGCMENSALISTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.btnInformeInativo = new System.Windows.Forms.Button();
            this.btnInformeNome = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsJogador1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultpesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // bsoPadrao
            // 
            this.bsoPadrao.DataMember = "JOGADOR";
            this.bsoPadrao.DataSource = this.dtsJogador1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.ckMensalista);
            this.tabPrincipal.Controls.Add(this.ckEnviaEmail);
            this.tabPrincipal.Controls.Add(this.lblEmail);
            this.tabPrincipal.Controls.Add(this.txtEmail);
            this.tabPrincipal.Controls.Add(this.txtCelular2);
            this.tabPrincipal.Controls.Add(this.txtCelular1);
            this.tabPrincipal.Controls.Add(this.txtFone);
            this.tabPrincipal.Controls.Add(this.lblCelular2);
            this.tabPrincipal.Controls.Add(this.lblCelular1);
            this.tabPrincipal.Controls.Add(this.lblFone);
            this.tabPrincipal.Controls.Add(this.label11);
            this.tabPrincipal.Controls.Add(this.label10);
            this.tabPrincipal.Controls.Add(this.txtDesativado);
            this.tabPrincipal.Controls.Add(this.label9);
            this.tabPrincipal.Controls.Add(this.txtCadastro);
            this.tabPrincipal.Controls.Add(this.txtObs);
            this.tabPrincipal.Controls.Add(this.label1);
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            this.tabPrincipal.Controls.Add(this.label2);
            this.tabPrincipal.Controls.Add(this.txtNome);
            this.tabPrincipal.Controls.Add(this.label3);
            this.tabPrincipal.Controls.Add(this.label7);
            this.tabPrincipal.Controls.Add(this.groupBox1);
            this.tabPrincipal.Controls.Add(this.label4);
            this.tabPrincipal.Controls.Add(this.txtNasc);
            this.tabPrincipal.Size = new System.Drawing.Size(675, 292);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.dataGridView1);
            this.pnlResultado.Location = new System.Drawing.Point(3, 63);
            this.pnlResultado.Size = new System.Drawing.Size(669, 226);
            this.pnlResultado.Controls.SetChildIndex(this.pnlPesquisar, 0);
            this.pnlResultado.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnlResultado.Controls.SetChildIndex(this.pnlGrade, 0);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.dtgResultpesquisa);
            this.pnlGrade.Size = new System.Drawing.Size(669, 199);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.btnInformeNome);
            this.pnlFiltro.Controls.Add(this.txtNomePesquisa);
            this.pnlFiltro.Controls.Add(this.label5);
            this.pnlFiltro.Size = new System.Drawing.Size(669, 60);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Controls.Add(this.btnInformeInativo);
            this.pnlPesquisar.Size = new System.Drawing.Size(669, 27);
            this.pnlPesquisar.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.pnlPesquisar.Controls.SetChildIndex(this.ckAtivos, 0);
            this.pnlPesquisar.Controls.SetChildIndex(this.btnInformeInativo, 0);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Size = new System.Drawing.Size(675, 292);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(683, 318);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(683, 318);
            // 
            // ckAtivos
            // 
            this.ckAtivos.TabIndex = 1;
            // 
            // dtsJogador1
            // 
            this.dtsJogador1.DataSetName = "dtsJogador";
            this.dtsJogador1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(544, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(544, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Data Desativado";
            // 
            // txtDesativado
            // 
            this.txtDesativado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_DESATIVADO", true));
            this.txtDesativado.Location = new System.Drawing.Point(547, 146);
            this.txtDesativado.Mask = "00/00/0000";
            this.txtDesativado.Name = "txtDesativado";
            this.txtDesativado.Size = new System.Drawing.Size(84, 20);
            this.txtDesativado.TabIndex = 42;
            this.txtDesativado.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(544, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Data Cadastro";
            // 
            // txtCadastro
            // 
            this.txtCadastro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_CADASTRO", true));
            this.txtCadastro.Location = new System.Drawing.Point(547, 101);
            this.txtCadastro.Mask = "00/00/0000";
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(84, 20);
            this.txtCadastro.TabIndex = 40;
            this.txtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtObs
            // 
            this.txtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "OBS_JOGADOR", true));
            this.txtObs.Location = new System.Drawing.Point(17, 199);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(496, 73);
            this.txtObs.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_JOGADOR", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(17, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "NOM_JOGADOR", true));
            this.txtNome.Location = new System.Drawing.Point(17, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(388, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "OBS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInativo);
            this.groupBox1.Controls.Add(this.rbAtivo);
            this.groupBox1.Location = new System.Drawing.Point(547, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 52);
            this.groupBox1.TabIndex = 39;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nasc";
            // 
            // txtNasc
            // 
            this.txtNasc.AllowPromptAsInput = false;
            this.txtNasc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_NASC", true));
            this.txtNasc.Location = new System.Drawing.Point(429, 72);
            this.txtNasc.Mask = "00/00/0000";
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(84, 20);
            this.txtNasc.TabIndex = 1;
            this.txtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(17, 95);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(31, 13);
            this.lblFone.TabIndex = 46;
            this.lblFone.Text = "Fone";
            // 
            // lblCelular1
            // 
            this.lblCelular1.AutoSize = true;
            this.lblCelular1.Location = new System.Drawing.Point(157, 95);
            this.lblCelular1.Name = "lblCelular1";
            this.lblCelular1.Size = new System.Drawing.Size(45, 13);
            this.lblCelular1.TabIndex = 48;
            this.lblCelular1.Text = "Celular1";
            // 
            // lblCelular2
            // 
            this.lblCelular2.AutoSize = true;
            this.lblCelular2.Location = new System.Drawing.Point(305, 95);
            this.lblCelular2.Name = "lblCelular2";
            this.lblCelular2.Size = new System.Drawing.Size(45, 13);
            this.lblCelular2.TabIndex = 50;
            this.lblCelular2.Text = "Celular2";
            // 
            // txtFone
            // 
            this.txtFone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "FONE", true));
            this.txtFone.Location = new System.Drawing.Point(17, 111);
            this.txtFone.Mask = "(99) 000-0000";
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(100, 20);
            this.txtFone.TabIndex = 2;
            // 
            // txtCelular1
            // 
            this.txtCelular1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "CELULAR1", true));
            this.txtCelular1.Location = new System.Drawing.Point(157, 111);
            this.txtCelular1.Mask = "(99) 0000-0000";
            this.txtCelular1.Name = "txtCelular1";
            this.txtCelular1.Size = new System.Drawing.Size(100, 20);
            this.txtCelular1.TabIndex = 3;
            // 
            // txtCelular2
            // 
            this.txtCelular2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "CELULAR2", true));
            this.txtCelular2.Location = new System.Drawing.Point(305, 111);
            this.txtCelular2.Mask = "(99) 0000-0000";
            this.txtCelular2.Name = "txtCelular2";
            this.txtCelular2.Size = new System.Drawing.Size(100, 20);
            this.txtCelular2.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 55;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "EMAIL", true));
            this.txtEmail.Location = new System.Drawing.Point(17, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(388, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // ckEnviaEmail
            // 
            this.ckEnviaEmail.AutoSize = true;
            this.ckEnviaEmail.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsoPadrao, "LGC_ENVIA_EMAIL", true));
            this.ckEnviaEmail.Location = new System.Drawing.Point(547, 182);
            this.ckEnviaEmail.Name = "ckEnviaEmail";
            this.ckEnviaEmail.Size = new System.Drawing.Size(81, 17);
            this.ckEnviaEmail.TabIndex = 7;
            this.ckEnviaEmail.Text = "Envia Email";
            this.ckEnviaEmail.UseVisualStyleBackColor = true;
            // 
            // ckMensalista
            // 
            this.ckMensalista.AutoSize = true;
            this.ckMensalista.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsoPadrao, "LGC_MENSALISTA", true));
            this.ckMensalista.Location = new System.Drawing.Point(547, 205);
            this.ckMensalista.Name = "ckMensalista";
            this.ckMensalista.Size = new System.Drawing.Size(76, 17);
            this.ckMensalista.TabIndex = 8;
            this.ckMensalista.Text = "Mensalista";
            this.ckMensalista.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(294, 156);
            this.dataGridView1.TabIndex = 0;
            // 
            // dtgResultpesquisa
            // 
            this.dtgResultpesquisa.AllowUserToAddRows = false;
            this.dtgResultpesquisa.AllowUserToDeleteRows = false;
            this.dtgResultpesquisa.AutoGenerateColumns = false;
            this.dtgResultpesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultpesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODJOGADORDataGridViewTextBoxColumn,
            this.nOMJOGADORDataGridViewTextBoxColumn,
            this.dATNASCDataGridViewTextBoxColumn,
            this.oBSJOGADORDataGridViewTextBoxColumn,
            this.dATCADASTRODataGridViewTextBoxColumn,
            this.dATDESATIVADODataGridViewTextBoxColumn,
            this.fONEDataGridViewTextBoxColumn,
            this.cELULAR1DataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.cELULAR2DataGridViewTextBoxColumn,
            this.lGCENVIAEMAILDataGridViewTextBoxColumn,
            this.lGCMENSALISTADataGridViewTextBoxColumn});
            this.dtgResultpesquisa.DataSource = this.bsoPadrao;
            this.dtgResultpesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgResultpesquisa.Location = new System.Drawing.Point(0, 0);
            this.dtgResultpesquisa.Name = "dtgResultpesquisa";
            this.dtgResultpesquisa.Size = new System.Drawing.Size(669, 199);
            this.dtgResultpesquisa.TabIndex = 0;
            this.dtgResultpesquisa.DoubleClick += new System.EventHandler(this.dtgResultpesquisa_DoubleClick);
            // 
            // cODJOGADORDataGridViewTextBoxColumn
            // 
            this.cODJOGADORDataGridViewTextBoxColumn.DataPropertyName = "COD_JOGADOR";
            this.cODJOGADORDataGridViewTextBoxColumn.HeaderText = "COD_JOGADOR";
            this.cODJOGADORDataGridViewTextBoxColumn.Name = "cODJOGADORDataGridViewTextBoxColumn";
            // 
            // nOMJOGADORDataGridViewTextBoxColumn
            // 
            this.nOMJOGADORDataGridViewTextBoxColumn.DataPropertyName = "NOM_JOGADOR";
            this.nOMJOGADORDataGridViewTextBoxColumn.HeaderText = "NOM_JOGADOR";
            this.nOMJOGADORDataGridViewTextBoxColumn.Name = "nOMJOGADORDataGridViewTextBoxColumn";
            // 
            // dATNASCDataGridViewTextBoxColumn
            // 
            this.dATNASCDataGridViewTextBoxColumn.DataPropertyName = "DAT_NASC";
            this.dATNASCDataGridViewTextBoxColumn.HeaderText = "DAT_NASC";
            this.dATNASCDataGridViewTextBoxColumn.Name = "dATNASCDataGridViewTextBoxColumn";
            // 
            // oBSJOGADORDataGridViewTextBoxColumn
            // 
            this.oBSJOGADORDataGridViewTextBoxColumn.DataPropertyName = "OBS_JOGADOR";
            this.oBSJOGADORDataGridViewTextBoxColumn.HeaderText = "OBS_JOGADOR";
            this.oBSJOGADORDataGridViewTextBoxColumn.Name = "oBSJOGADORDataGridViewTextBoxColumn";
            // 
            // dATCADASTRODataGridViewTextBoxColumn
            // 
            this.dATCADASTRODataGridViewTextBoxColumn.DataPropertyName = "DAT_CADASTRO";
            this.dATCADASTRODataGridViewTextBoxColumn.HeaderText = "DAT_CADASTRO";
            this.dATCADASTRODataGridViewTextBoxColumn.Name = "dATCADASTRODataGridViewTextBoxColumn";
            // 
            // dATDESATIVADODataGridViewTextBoxColumn
            // 
            this.dATDESATIVADODataGridViewTextBoxColumn.DataPropertyName = "DAT_DESATIVADO";
            this.dATDESATIVADODataGridViewTextBoxColumn.HeaderText = "DAT_DESATIVADO";
            this.dATDESATIVADODataGridViewTextBoxColumn.Name = "dATDESATIVADODataGridViewTextBoxColumn";
            // 
            // fONEDataGridViewTextBoxColumn
            // 
            this.fONEDataGridViewTextBoxColumn.DataPropertyName = "FONE";
            this.fONEDataGridViewTextBoxColumn.HeaderText = "FONE";
            this.fONEDataGridViewTextBoxColumn.Name = "fONEDataGridViewTextBoxColumn";
            // 
            // cELULAR1DataGridViewTextBoxColumn
            // 
            this.cELULAR1DataGridViewTextBoxColumn.DataPropertyName = "CELULAR1";
            this.cELULAR1DataGridViewTextBoxColumn.HeaderText = "CELULAR1";
            this.cELULAR1DataGridViewTextBoxColumn.Name = "cELULAR1DataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // cELULAR2DataGridViewTextBoxColumn
            // 
            this.cELULAR2DataGridViewTextBoxColumn.DataPropertyName = "CELULAR2";
            this.cELULAR2DataGridViewTextBoxColumn.HeaderText = "CELULAR2";
            this.cELULAR2DataGridViewTextBoxColumn.Name = "cELULAR2DataGridViewTextBoxColumn";
            // 
            // lGCENVIAEMAILDataGridViewTextBoxColumn
            // 
            this.lGCENVIAEMAILDataGridViewTextBoxColumn.DataPropertyName = "LGC_ENVIA_EMAIL";
            this.lGCENVIAEMAILDataGridViewTextBoxColumn.HeaderText = "LGC_ENVIA_EMAIL";
            this.lGCENVIAEMAILDataGridViewTextBoxColumn.Name = "lGCENVIAEMAILDataGridViewTextBoxColumn";
            // 
            // lGCMENSALISTADataGridViewTextBoxColumn
            // 
            this.lGCMENSALISTADataGridViewTextBoxColumn.DataPropertyName = "LGC_MENSALISTA";
            this.lGCMENSALISTADataGridViewTextBoxColumn.HeaderText = "LGC_MENSALISTA";
            this.lGCMENSALISTADataGridViewTextBoxColumn.Name = "lGCMENSALISTADataGridViewTextBoxColumn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome";
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(20, 26);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(426, 20);
            this.txtNomePesquisa.TabIndex = 0;
            this.txtNomePesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomePesquisa_KeyDown);
            this.txtNomePesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomePesquisa_KeyPress);
            // 
            // btnInformeInativo
            // 
            this.btnInformeInativo.FlatAppearance.BorderSize = 0;
            this.btnInformeInativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeInativo.Image = ((System.Drawing.Image)(resources.GetObject("btnInformeInativo.Image")));
            this.btnInformeInativo.Location = new System.Drawing.Point(204, 2);
            this.btnInformeInativo.Name = "btnInformeInativo";
            this.btnInformeInativo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInformeInativo.Size = new System.Drawing.Size(23, 23);
            this.btnInformeInativo.TabIndex = 2;
            this.btnInformeInativo.UseVisualStyleBackColor = true;
            this.btnInformeInativo.Click += new System.EventHandler(this.btnInformeInativo_Click);
            // 
            // btnInformeNome
            // 
            this.btnInformeNome.FlatAppearance.BorderSize = 0;
            this.btnInformeNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeNome.Image = ((System.Drawing.Image)(resources.GetObject("btnInformeNome.Image")));
            this.btnInformeNome.Location = new System.Drawing.Point(452, 25);
            this.btnInformeNome.Name = "btnInformeNome";
            this.btnInformeNome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInformeNome.Size = new System.Drawing.Size(23, 23);
            this.btnInformeNome.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnInformeNome, "Informe o nome para pesquisar um jogador!");
            this.btnInformeNome.UseVisualStyleBackColor = true;
            this.btnInformeNome.Click += new System.EventHandler(this.btnInformeNome_Click);
            // 
            // frmJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClasseDados = this.jogador1;
            this.ClientSize = new System.Drawing.Size(683, 380);
            this.Name = "frmJogador";
            this.Text = "Cadastro de Jogadores";
            this.ValidarGravar += new CamadaFuncao.Delegates.Delegates.PadraoValidarEventHandler(this.frmJogador_ValidarGravar);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtsJogador1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultpesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CamadaLogica.Classes.Jogador jogador1;
        private CamadaLogica.DS.dtsJogador dtsJogador1;
        private System.Windows.Forms.Label lblCelular2;
        private System.Windows.Forms.Label lblCelular1;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtDesativado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCadastro;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtNasc;
        private System.Windows.Forms.CheckBox ckMensalista;
        private System.Windows.Forms.CheckBox ckEnviaEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtCelular2;
        private System.Windows.Forms.MaskedTextBox txtCelular1;
        private System.Windows.Forms.MaskedTextBox txtFone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dtgResultpesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODJOGADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMJOGADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATNASCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSJOGADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATCADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATDESATIVADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cELULAR1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cELULAR2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lGCENVIAEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lGCMENSALISTADataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInformeInativo;
        private System.Windows.Forms.Button btnInformeNome;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}