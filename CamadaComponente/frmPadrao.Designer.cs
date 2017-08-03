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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlFerramentas = new System.Windows.Forms.Panel();
            this.pnlIncluir = new System.Windows.Forms.Panel();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.pnlAlterar = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pnlGravar = new System.Windows.Forms.Panel();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pnlCancelar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlExcluir = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlSair = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.pnlPesquisar = new System.Windows.Forms.Panel();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.chkMostraInativo = new System.Windows.Forms.CheckBox();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.ckAtivos = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.pnlFerramentas.SuspendLayout();
            this.pnlIncluir.SuspendLayout();
            this.pnlAlterar.SuspendLayout();
            this.pnlGravar.SuspendLayout();
            this.pnlCancelar.SuspendLayout();
            this.pnlExcluir.SuspendLayout();
            this.pnlSair.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(827, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 397);
            this.panel3.TabIndex = 3;
            // 
            // pnlFerramentas
            // 
            this.pnlFerramentas.Controls.Add(this.pnlIncluir);
            this.pnlFerramentas.Controls.Add(this.pnlAlterar);
            this.pnlFerramentas.Controls.Add(this.pnlGravar);
            this.pnlFerramentas.Controls.Add(this.pnlCancelar);
            this.pnlFerramentas.Controls.Add(this.pnlExcluir);
            this.pnlFerramentas.Controls.Add(this.pnlSair);
            this.pnlFerramentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFerramentas.Location = new System.Drawing.Point(0, 397);
            this.pnlFerramentas.Name = "pnlFerramentas";
            this.pnlFerramentas.Size = new System.Drawing.Size(827, 27);
            this.pnlFerramentas.TabIndex = 1;
            // 
            // pnlIncluir
            // 
            this.pnlIncluir.Controls.Add(this.btnIncluir);
            this.pnlIncluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlIncluir.Location = new System.Drawing.Point(345, 0);
            this.pnlIncluir.Name = "pnlIncluir";
            this.pnlIncluir.Size = new System.Drawing.Size(82, 27);
            this.pnlIncluir.TabIndex = 35;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIncluir.Location = new System.Drawing.Point(8, 0);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(74, 27);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // pnlAlterar
            // 
            this.pnlAlterar.Controls.Add(this.btnAlterar);
            this.pnlAlterar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAlterar.Location = new System.Drawing.Point(427, 0);
            this.pnlAlterar.Name = "pnlAlterar";
            this.pnlAlterar.Size = new System.Drawing.Size(80, 27);
            this.pnlAlterar.TabIndex = 34;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAlterar.Location = new System.Drawing.Point(6, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(74, 27);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // pnlGravar
            // 
            this.pnlGravar.Controls.Add(this.btnGravar);
            this.pnlGravar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGravar.Location = new System.Drawing.Point(507, 0);
            this.pnlGravar.Name = "pnlGravar";
            this.pnlGravar.Size = new System.Drawing.Size(80, 27);
            this.pnlGravar.TabIndex = 33;
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGravar.Location = new System.Drawing.Point(6, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(74, 27);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // pnlCancelar
            // 
            this.pnlCancelar.Controls.Add(this.btnCancelar);
            this.pnlCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCancelar.Location = new System.Drawing.Point(587, 0);
            this.pnlCancelar.Name = "pnlCancelar";
            this.pnlCancelar.Size = new System.Drawing.Size(80, 27);
            this.pnlCancelar.TabIndex = 32;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(6, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 27);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pnlExcluir
            // 
            this.pnlExcluir.Controls.Add(this.btnExcluir);
            this.pnlExcluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExcluir.Location = new System.Drawing.Point(667, 0);
            this.pnlExcluir.Name = "pnlExcluir";
            this.pnlExcluir.Size = new System.Drawing.Size(80, 27);
            this.pnlExcluir.TabIndex = 31;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExcluir.Location = new System.Drawing.Point(6, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(74, 27);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // pnlSair
            // 
            this.pnlSair.Controls.Add(this.btnSair);
            this.pnlSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSair.Location = new System.Drawing.Point(747, 0);
            this.pnlSair.Name = "pnlSair";
            this.pnlSair.Size = new System.Drawing.Size(80, 27);
            this.pnlSair.TabIndex = 30;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Location = new System.Drawing.Point(6, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 27);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPesquisa);
            this.tabControl1.Controls.Add(this.tabPrincipal);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(819, 371);
            this.tabPrincipal.TabIndex = 1;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(3, 3);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(813, 94);
            this.pnlFiltro.TabIndex = 0;
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Controls.Add(this.ckAtivos);
            this.pnlPesquisar.Controls.Add(this.button1);
            this.pnlPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPesquisar.Location = new System.Drawing.Point(3, 97);
            this.pnlPesquisar.Name = "pnlPesquisar";
            this.pnlPesquisar.Size = new System.Drawing.Size(813, 27);
            this.pnlPesquisar.TabIndex = 3;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPesquisa.Location = new System.Drawing.Point(0, 0);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 31);
            this.btnPesquisa.TabIndex = 11;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
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
            // pnlResultado
            // 
            this.pnlResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultado.Location = new System.Drawing.Point(3, 97);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(813, 271);
            this.pnlResultado.TabIndex = 4;
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
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.pnlPesquisar);
            this.tabPesquisa.Controls.Add(this.pnlResultado);
            this.tabPesquisa.Controls.Add(this.pnlFiltro);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisa.Size = new System.Drawing.Size(819, 371);
            this.tabPesquisa.TabIndex = 0;
            this.tabPesquisa.Text = "Pesquisa";
            this.tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // ckAtivos
            // 
            this.ckAtivos.AutoSize = true;
            this.ckAtivos.Dock = System.Windows.Forms.DockStyle.Left;
            this.ckAtivos.Location = new System.Drawing.Point(75, 0);
            this.ckAtivos.Name = "ckAtivos";
            this.ckAtivos.Size = new System.Drawing.Size(101, 27);
            this.ckAtivos.TabIndex = 12;
            this.ckAtivos.Text = "Mostrar Inativos";
            this.ckAtivos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 446);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFerramentas);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmPadrao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Padrao";
            this.panel3.ResumeLayout(false);
            this.pnlFerramentas.ResumeLayout(false);
            this.pnlIncluir.ResumeLayout(false);
            this.pnlAlterar.ResumeLayout(false);
            this.pnlGravar.ResumeLayout(false);
            this.pnlCancelar.ResumeLayout(false);
            this.pnlExcluir.ResumeLayout(false);
            this.pnlSair.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPesquisa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlFerramentas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.Panel pnlPesquisar;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.Panel pnlIncluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Panel pnlAlterar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel pnlGravar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Panel pnlCancelar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlExcluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlSair;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.CheckBox chkMostraInativo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ckAtivos;
        private System.Windows.Forms.Button button1;
    }
}