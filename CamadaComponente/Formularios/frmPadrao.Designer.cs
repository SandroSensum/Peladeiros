using CamadaComponente.Componentes;

namespace CamadaComponente
{
    partial class frmPadrao
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgrBarra = new System.Windows.Forms.ToolStripProgressBar();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbcPadrao = new System.Windows.Forms.TabControl();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.pnlResultado = new CamadaComponente.Componentes.scPanel();
            this.pnlGrade = new CamadaComponente.Componentes.scPanel();
            this.pnlPesquisar = new CamadaComponente.Componentes.scPanel();
            this.ckAtivos = new System.Windows.Forms.CheckBox();
            this.btnPesquisar = new CamadaComponente.Componentes.scButton();
            this.pnlFiltro = new CamadaComponente.Componentes.scPanel();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.panelBase = new CamadaComponente.Componentes.scPanel();
            this.pnlFerramentas = new CamadaComponente.Componentes.scPanel();
            this.pnlIncluir = new CamadaComponente.Componentes.scPanel();
            this.btnIncluir = new CamadaComponente.Componentes.scButton();
            this.pnlAlterar = new CamadaComponente.Componentes.scPanel();
            this.btnAlterar = new CamadaComponente.Componentes.scButton();
            this.pnlGravar = new CamadaComponente.Componentes.scPanel();
            this.btnGravar = new CamadaComponente.Componentes.scButton();
            this.pnlCancelar = new CamadaComponente.Componentes.scPanel();
            this.btnExcluir = new CamadaComponente.Componentes.scButton();
            this.pnlExcluir = new CamadaComponente.Componentes.scPanel();
            this.btnCancelar = new CamadaComponente.Componentes.scButton();
            this.pnlSair = new CamadaComponente.Componentes.scPanel();
            this.btnSair = new CamadaComponente.Componentes.scButton();
            this.btnPesquisa = new CamadaComponente.Componentes.scButton();
            this.chkMostraInativo = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsoPadrao = new CamadaComponente.Componentes.scBso(this.components);
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.pnlFerramentas.SuspendLayout();
            this.pnlIncluir.SuspendLayout();
            this.pnlAlterar.SuspendLayout();
            this.pnlGravar.SuspendLayout();
            this.pnlCancelar.SuspendLayout();
            this.pnlExcluir.SuspendLayout();
            this.pnlSair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMensagem,
            this.pgrBarra,
            this.lblUsuario,
            this.lblDataHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(827, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMensagem
            // 
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblMensagem.Size = new System.Drawing.Size(594, 17);
            this.lblMensagem.Spring = true;
            this.lblMensagem.Text = "Mensagem";
            // 
            // pgrBarra
            // 
            this.pgrBarra.Name = "pgrBarra";
            this.pgrBarra.Size = new System.Drawing.Size(100, 16);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 17);
            this.lblUsuario.Text = "Usuário";
            // 
            // lblDataHora
            // 
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDataHora.Size = new System.Drawing.Size(69, 17);
            this.lblDataHora.Text = "Data e Hora";
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Controls.Add(this.tabPesquisa);
            this.tbcPadrao.Controls.Add(this.tabPrincipal);
            this.tbcPadrao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPadrao.Location = new System.Drawing.Point(0, 0);
            this.tbcPadrao.Name = "tbcPadrao";
            this.tbcPadrao.SelectedIndex = 0;
            this.tbcPadrao.Size = new System.Drawing.Size(827, 384);
            this.tbcPadrao.TabIndex = 0;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.pnlResultado);
            this.tabPesquisa.Controls.Add(this.pnlFiltro);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisa.Size = new System.Drawing.Size(819, 358);
            this.tabPesquisa.TabIndex = 0;
            this.tabPesquisa.Text = "Pesquisa";
            this.tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.pnlGrade);
            this.pnlResultado.Controls.Add(this.pnlPesquisar);
            this.pnlResultado.Desabilitar = false;
            this.pnlResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultado.Location = new System.Drawing.Point(3, 97);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(813, 258);
            this.pnlResultado.TabIndex = 4;
            // 
            // pnlGrade
            // 
            this.pnlGrade.Desabilitar = false;
            this.pnlGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrade.Location = new System.Drawing.Point(0, 27);
            this.pnlGrade.Name = "pnlGrade";
            this.pnlGrade.Size = new System.Drawing.Size(813, 231);
            this.pnlGrade.TabIndex = 5;
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Controls.Add(this.ckAtivos);
            this.pnlPesquisar.Controls.Add(this.btnPesquisar);
            this.pnlPesquisar.Desabilitar = false;
            this.pnlPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPesquisar.Location = new System.Drawing.Point(0, 0);
            this.pnlPesquisar.Name = "pnlPesquisar";
            this.pnlPesquisar.Size = new System.Drawing.Size(813, 27);
            this.pnlPesquisar.TabIndex = 4;
            // 
            // ckAtivos
            // 
            this.ckAtivos.AutoSize = true;
            this.ckAtivos.Location = new System.Drawing.Point(97, 6);
            this.ckAtivos.Name = "ckAtivos";
            this.ckAtivos.Size = new System.Drawing.Size(101, 17);
            this.ckAtivos.TabIndex = 12;
            this.ckAtivos.Text = "Mostrar Inativos";
            this.ckAtivos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Desabilitar = false;
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPesquisar.Location = new System.Drawing.Point(0, 0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 27);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Desabilitar = false;
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(3, 3);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(813, 94);
            this.pnlFiltro.TabIndex = 0;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.panelBase);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(819, 358);
            this.tabPrincipal.TabIndex = 1;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // panelBase
            // 
            this.panelBase.Desabilitar = false;
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(3, 3);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(813, 352);
            this.panelBase.TabIndex = 0;
            // 
            // pnlFerramentas
            // 
            this.pnlFerramentas.Controls.Add(this.pnlIncluir);
            this.pnlFerramentas.Controls.Add(this.pnlAlterar);
            this.pnlFerramentas.Controls.Add(this.pnlGravar);
            this.pnlFerramentas.Controls.Add(this.pnlCancelar);
            this.pnlFerramentas.Controls.Add(this.pnlExcluir);
            this.pnlFerramentas.Controls.Add(this.pnlSair);
            this.pnlFerramentas.Desabilitar = false;
            this.pnlFerramentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFerramentas.Location = new System.Drawing.Point(0, 384);
            this.pnlFerramentas.Name = "pnlFerramentas";
            this.pnlFerramentas.Padding = new System.Windows.Forms.Padding(5);
            this.pnlFerramentas.Size = new System.Drawing.Size(827, 40);
            this.pnlFerramentas.TabIndex = 1;
            // 
            // pnlIncluir
            // 
            this.pnlIncluir.Controls.Add(this.btnIncluir);
            this.pnlIncluir.Desabilitar = false;
            this.pnlIncluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlIncluir.Location = new System.Drawing.Point(340, 5);
            this.pnlIncluir.Name = "pnlIncluir";
            this.pnlIncluir.Size = new System.Drawing.Size(82, 30);
            this.pnlIncluir.TabIndex = 35;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIncluir.Location = new System.Drawing.Point(8, 0);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(74, 30);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // pnlAlterar
            // 
            this.pnlAlterar.Controls.Add(this.btnAlterar);
            this.pnlAlterar.Desabilitar = false;
            this.pnlAlterar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAlterar.Location = new System.Drawing.Point(422, 5);
            this.pnlAlterar.Name = "pnlAlterar";
            this.pnlAlterar.Size = new System.Drawing.Size(80, 30);
            this.pnlAlterar.TabIndex = 34;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAlterar.Location = new System.Drawing.Point(6, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(74, 30);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // pnlGravar
            // 
            this.pnlGravar.Controls.Add(this.btnGravar);
            this.pnlGravar.Desabilitar = false;
            this.pnlGravar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGravar.Location = new System.Drawing.Point(502, 5);
            this.pnlGravar.Name = "pnlGravar";
            this.pnlGravar.Size = new System.Drawing.Size(80, 30);
            this.pnlGravar.TabIndex = 33;
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGravar.Location = new System.Drawing.Point(6, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(74, 30);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // pnlCancelar
            // 
            this.pnlCancelar.Controls.Add(this.btnExcluir);
            this.pnlCancelar.Desabilitar = false;
            this.pnlCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCancelar.Location = new System.Drawing.Point(582, 5);
            this.pnlCancelar.Name = "pnlCancelar";
            this.pnlCancelar.Size = new System.Drawing.Size(80, 30);
            this.pnlCancelar.TabIndex = 32;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExcluir.Location = new System.Drawing.Point(6, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(74, 30);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pnlExcluir
            // 
            this.pnlExcluir.Controls.Add(this.btnCancelar);
            this.pnlExcluir.Desabilitar = false;
            this.pnlExcluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExcluir.Location = new System.Drawing.Point(662, 5);
            this.pnlExcluir.Name = "pnlExcluir";
            this.pnlExcluir.Size = new System.Drawing.Size(80, 30);
            this.pnlExcluir.TabIndex = 31;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(6, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 30);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlSair
            // 
            this.pnlSair.Controls.Add(this.btnSair);
            this.pnlSair.Desabilitar = false;
            this.pnlSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSair.Location = new System.Drawing.Point(742, 5);
            this.pnlSair.Name = "pnlSair";
            this.pnlSair.Size = new System.Drawing.Size(80, 30);
            this.pnlSair.TabIndex = 30;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Location = new System.Drawing.Point(6, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 30);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "&Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPesquisa.Location = new System.Drawing.Point(0, 0);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 31);
            this.btnPesquisa.TabIndex = 11;
            this.btnPesquisa.Text = "Pesquisar";
            // 
            // chkMostraInativo
            // 
            this.chkMostraInativo.AutoSize = true;
            this.chkMostraInativo.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkMostraInativo.Location = new System.Drawing.Point(75, 0);
            this.chkMostraInativo.Name = "chkMostraInativo";
            this.chkMostraInativo.Size = new System.Drawing.Size(101, 31);
            this.chkMostraInativo.TabIndex = 12;
            this.chkMostraInativo.Text = "Mostrar Inativos";
            this.chkMostraInativo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // frmPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 446);
            this.Controls.Add(this.tbcPadrao);
            this.Controls.Add(this.pnlFerramentas);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmPadrao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Padrao";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tbcPadrao.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            this.pnlResultado.ResumeLayout(false);
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            this.tabPrincipal.ResumeLayout(false);
            this.pnlFerramentas.ResumeLayout(false);
            this.pnlIncluir.ResumeLayout(false);
            this.pnlAlterar.ResumeLayout(false);
            this.pnlGravar.ResumeLayout(false);
            this.pnlCancelar.ResumeLayout(false);
            this.pnlExcluir.ResumeLayout(false);
            this.pnlSair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private CamadaComponente.Componentes.scPanel pnlFerramentas;
        private CamadaComponente.Componentes.scPanel pnlIncluir;
        private CamadaComponente.Componentes.scButton btnIncluir;
        private CamadaComponente.Componentes.scPanel pnlAlterar;
        private CamadaComponente.Componentes.scButton btnAlterar;
        private CamadaComponente.Componentes.scPanel pnlGravar;
        private CamadaComponente.Componentes.scButton btnGravar;
        private CamadaComponente.Componentes.scPanel pnlCancelar;
        private CamadaComponente.Componentes.scButton btnExcluir;
        private CamadaComponente.Componentes.scPanel pnlExcluir;
        private CamadaComponente.Componentes.scButton btnCancelar;
        private CamadaComponente.Componentes.scPanel pnlSair;
        private CamadaComponente.Componentes.scButton btnSair;
        private CamadaComponente.Componentes.scButton btnPesquisa;
        private System.Windows.Forms.CheckBox chkMostraInativo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel lblMensagem;
        private System.Windows.Forms.ToolStripProgressBar pgrBarra;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblDataHora;
        public scBso bsoPadrao;
        public System.Windows.Forms.Timer tmrHora;
        public System.Windows.Forms.TabPage tabPrincipal;
        public CamadaComponente.Componentes.scPanel pnlResultado;
        public CamadaComponente.Componentes.scPanel pnlGrade;
        public CamadaComponente.Componentes.scPanel pnlFiltro;
        public CamadaComponente.Componentes.scPanel pnlPesquisar;
        public CamadaComponente.Componentes.scButton btnPesquisar;
        public System.Windows.Forms.TabPage tabPesquisa;
        public System.Windows.Forms.TabControl tbcPadrao;
        public System.Windows.Forms.CheckBox ckAtivos;
        public scPanel panelBase;
    }
}