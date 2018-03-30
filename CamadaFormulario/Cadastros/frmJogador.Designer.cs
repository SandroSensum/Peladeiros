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
            this.txtNomePesquisa = new CamadaComponente.Componentes.scTextBox();
            this.btnInformeInativo = new System.Windows.Forms.Button();
            this.btnInformeNome = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.cpAtivoInativo1 = new CamadaComponente.Componentes.cpAtivoInativo();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblAnos = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtCel2 = new System.Windows.Forms.MaskedTextBox();
            this.lblCel2 = new System.Windows.Forms.Label();
            this.txtCel1 = new System.Windows.Forms.MaskedTextBox();
            this.lblCel1 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.txtDatNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatCadastro = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsJogador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultpesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // bsoPadrao
            // 
            this.bsoPadrao.DataMember = "JOGADOR";
            this.bsoPadrao.DataSource = this.dtsJogador1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Size = new System.Drawing.Size(616, 292);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.dataGridView1);
            this.pnlResultado.Location = new System.Drawing.Point(3, 63);
            this.pnlResultado.Size = new System.Drawing.Size(610, 226);
            this.pnlResultado.Controls.SetChildIndex(this.pnlPesquisar, 0);
            this.pnlResultado.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnlResultado.Controls.SetChildIndex(this.pnlGrade, 0);
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.dtgResultpesquisa);
            this.pnlGrade.Size = new System.Drawing.Size(610, 199);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.btnInformeNome);
            this.pnlFiltro.Controls.Add(this.txtNomePesquisa);
            this.pnlFiltro.Controls.Add(this.label5);
            this.pnlFiltro.Size = new System.Drawing.Size(610, 60);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Controls.Add(this.btnInformeInativo);
            this.pnlPesquisar.Size = new System.Drawing.Size(610, 27);
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
            this.tabPesquisa.Size = new System.Drawing.Size(616, 292);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(624, 318);
            // 
            // ckAtivos
            // 
            this.ckAtivos.TabIndex = 1;
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.picFoto);
            this.pnlBase.Controls.Add(this.cpAtivoInativo1);
            this.pnlBase.Controls.Add(this.lblObs);
            this.pnlBase.Controls.Add(this.txtObs);
            this.pnlBase.Controls.Add(this.lblAnos);
            this.pnlBase.Controls.Add(this.lblIdade);
            this.pnlBase.Controls.Add(this.txtIdade);
            this.pnlBase.Controls.Add(this.txtCel2);
            this.pnlBase.Controls.Add(this.lblCel2);
            this.pnlBase.Controls.Add(this.txtCel1);
            this.pnlBase.Controls.Add(this.lblCel1);
            this.pnlBase.Controls.Add(this.maskedTextBox2);
            this.pnlBase.Controls.Add(this.txtDatNascimento);
            this.pnlBase.Controls.Add(this.label1);
            this.pnlBase.Controls.Add(this.lblDatCadastro);
            this.pnlBase.Controls.Add(this.lblEmail);
            this.pnlBase.Controls.Add(this.txtEmail);
            this.pnlBase.Controls.Add(this.lblCodigo);
            this.pnlBase.Controls.Add(this.txtCodigo);
            this.pnlBase.Controls.Add(this.lblNome);
            this.pnlBase.Controls.Add(this.txtNome);
            this.pnlBase.Size = new System.Drawing.Size(610, 286);
            // 
            // dtsJogador1
            // 
            this.dtsJogador1.DataSetName = "dtsJogador";
            this.dtsJogador1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dtgResultpesquisa.Size = new System.Drawing.Size(610, 199);
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
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(482, 22);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(119, 142);
            this.picFoto.TabIndex = 155;
            this.picFoto.TabStop = false;
            // 
            // cpAtivoInativo1
            // 
            this.cpAtivoInativo1.bsoAtivoInativo = this.bsoPadrao;
            this.cpAtivoInativo1.Location = new System.Drawing.Point(376, 57);
            this.cpAtivoInativo1.Name = "cpAtivoInativo1";
            this.cpAtivoInativo1.NomeCampo = "DAT_DESATIVADO";
            this.cpAtivoInativo1.Size = new System.Drawing.Size(100, 107);
            this.cpAtivoInativo1.TabIndex = 154;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(12, 182);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(70, 13);
            this.lblObs.TabIndex = 153;
            this.lblObs.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "OBS_JOGADOR", true));
            this.txtObs.Location = new System.Drawing.Point(12, 198);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(589, 67);
            this.txtObs.TabIndex = 152;
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Location = new System.Drawing.Point(142, 123);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(30, 13);
            this.lblAnos.TabIndex = 151;
            this.lblAnos.Text = "anos";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(103, 104);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 150;
            this.lblIdade.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdade.Location = new System.Drawing.Point(103, 120);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.ReadOnly = true;
            this.txtIdade.Size = new System.Drawing.Size(39, 20);
            this.txtIdade.TabIndex = 149;
            // 
            // txtCel2
            // 
            this.txtCel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "CELULAR2", true));
            this.txtCel2.Location = new System.Drawing.Point(278, 120);
            this.txtCel2.Mask = "(99) 00000-0000";
            this.txtCel2.Name = "txtCel2";
            this.txtCel2.Size = new System.Drawing.Size(84, 20);
            this.txtCel2.TabIndex = 138;
            // 
            // lblCel2
            // 
            this.lblCel2.AutoSize = true;
            this.lblCel2.Location = new System.Drawing.Point(275, 104);
            this.lblCel2.Name = "lblCel2";
            this.lblCel2.Size = new System.Drawing.Size(39, 13);
            this.lblCel2.TabIndex = 148;
            this.lblCel2.Text = "Celular";
            // 
            // txtCel1
            // 
            this.txtCel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "CELULAR1", true));
            this.txtCel1.Location = new System.Drawing.Point(188, 120);
            this.txtCel1.Mask = "(99) 00000-0000";
            this.txtCel1.Name = "txtCel1";
            this.txtCel1.Size = new System.Drawing.Size(84, 20);
            this.txtCel1.TabIndex = 137;
            // 
            // lblCel1
            // 
            this.lblCel1.AutoSize = true;
            this.lblCel1.Location = new System.Drawing.Point(185, 104);
            this.lblCel1.Name = "lblCel1";
            this.lblCel1.Size = new System.Drawing.Size(39, 13);
            this.lblCel1.TabIndex = 147;
            this.lblCel1.Text = "Celular";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_CADASTRO", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(88, 38);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(84, 20);
            this.maskedTextBox2.TabIndex = 146;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // txtDatNascimento
            // 
            this.txtDatNascimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "DAT_NASC", true));
            this.txtDatNascimento.Location = new System.Drawing.Point(13, 120);
            this.txtDatNascimento.Mask = "00/00/0000";
            this.txtDatNascimento.Name = "txtDatNascimento";
            this.txtDatNascimento.Size = new System.Drawing.Size(84, 20);
            this.txtDatNascimento.TabIndex = 136;
            this.txtDatNascimento.ValidatingType = typeof(System.DateTime);
            this.txtDatNascimento.Leave += new System.EventHandler(this.txtDatNascimento_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 145;
            this.label1.Text = "Nascimento";
            // 
            // lblDatCadastro
            // 
            this.lblDatCadastro.AutoSize = true;
            this.lblDatCadastro.Location = new System.Drawing.Point(85, 22);
            this.lblDatCadastro.Name = "lblDatCadastro";
            this.lblDatCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDatCadastro.TabIndex = 144;
            this.lblDatCadastro.Text = "Data Cadastro";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 143;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "EMAIL", true));
            this.txtEmail.Location = new System.Drawing.Point(12, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 20);
            this.txtEmail.TabIndex = 139;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 140;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_JOGADOR", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(12, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 141;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 142;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "NOM_JOGADOR", true));
            this.txtNome.Location = new System.Drawing.Point(12, 81);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 20);
            this.txtNome.TabIndex = 135;
            // 
            // frmJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClasseDados = this.jogador1;
            this.ClientSize = new System.Drawing.Size(624, 380);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJogador";
            this.Text = "Cadastro de Jogadores";
            this.ValidarGravar += new CamadaFuncao.Delegates.Delegates.PadraoValidarEventHandler(this.frmJogador_ValidarGravar);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtsJogador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultpesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private CamadaLogica.Classes.Jogador jogador1;
        private CamadaLogica.DS.dtsJogador dtsJogador1;
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
        private CamadaComponente.Componentes.scTextBox txtNomePesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInformeInativo;
        private System.Windows.Forms.Button btnInformeNome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picFoto;
        private CamadaComponente.Componentes.cpAtivoInativo cpAtivoInativo1;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblAnos;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.MaskedTextBox txtCel2;
        private System.Windows.Forms.Label lblCel2;
        private System.Windows.Forms.MaskedTextBox txtCel1;
        private System.Windows.Forms.Label lblCel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox txtDatNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatCadastro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
    }

}