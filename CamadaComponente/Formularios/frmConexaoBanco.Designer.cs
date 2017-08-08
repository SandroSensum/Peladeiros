namespace CamadaComponente.Formularios
{
    partial class frmConexaoBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConexaoBanco));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlFerramentas = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCaminho = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCaminhoBanco = new System.Windows.Forms.TextBox();
            this.grpTipoConexao = new System.Windows.Forms.GroupBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.radRede = new System.Windows.Forms.RadioButton();
            this.radLocal = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlPrincipal.SuspendLayout();
            this.pnlFerramentas.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.grpCaminho.SuspendLayout();
            this.grpTipoConexao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlFerramentas);
            this.pnlPrincipal.Controls.Add(this.pnlStatus);
            this.pnlPrincipal.Controls.Add(this.grpLogin);
            this.pnlPrincipal.Controls.Add(this.grpCaminho);
            this.pnlPrincipal.Controls.Add(this.grpTipoConexao);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(442, 315);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlFerramentas
            // 
            this.pnlFerramentas.Controls.Add(this.panel3);
            this.pnlFerramentas.Controls.Add(this.panel1);
            this.pnlFerramentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFerramentas.Location = new System.Drawing.Point(0, 254);
            this.pnlFerramentas.Name = "pnlFerramentas";
            this.pnlFerramentas.Padding = new System.Windows.Forms.Padding(5);
            this.pnlFerramentas.Size = new System.Drawing.Size(442, 37);
            this.pnlFerramentas.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAplicar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(258, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 27);
            this.panel3.TabIndex = 0;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAplicar.ImageKey = "check2.ico";
            this.btnAplicar.ImageList = this.imageList1;
            this.btnAplicar.Location = new System.Drawing.Point(6, 0);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(84, 27);
            this.btnAplicar.TabIndex = 0;
            this.btnAplicar.Text = "&Aplicar";
            this.btnAplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_gear.ico");
            this.imageList1.Images.SetKeyName(1, "check2.ico");
            this.imageList1.Images.SetKeyName(2, "delete2.ico");
            this.imageList1.Images.SetKeyName(3, "checks.ico");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(348, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 27);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.ImageKey = "delete2.ico";
            this.btnCancelar.ImageList = this.imageList1;
            this.btnCancelar.Location = new System.Drawing.Point(5, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 27);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.statusStrip1);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 291);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(442, 24);
            this.pnlStatus.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 2);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(442, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.btnTestarConexao);
            this.grpLogin.Controls.Add(this.txtSenha);
            this.grpLogin.Controls.Add(this.txtUsuario);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Location = new System.Drawing.Point(3, 131);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(196, 113);
            this.grpLogin.TabIndex = 2;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login Banco de Dados";
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.ImageKey = "checks.ico";
            this.btnTestarConexao.ImageList = this.imageList1;
            this.btnTestarConexao.Location = new System.Drawing.Point(58, 74);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(129, 23);
            this.btnTestarConexao.TabIndex = 2;
            this.btnTestarConexao.Text = "Testar Conexão";
            this.btnTestarConexao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(58, 48);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(129, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(58, 23);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(129, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuário";
            // 
            // grpCaminho
            // 
            this.grpCaminho.Controls.Add(this.button1);
            this.grpCaminho.Controls.Add(this.txtCaminhoBanco);
            this.grpCaminho.Location = new System.Drawing.Point(3, 74);
            this.grpCaminho.Name = "grpCaminho";
            this.grpCaminho.Size = new System.Drawing.Size(429, 51);
            this.grpCaminho.TabIndex = 1;
            this.grpCaminho.TabStop = false;
            this.grpCaminho.Text = "Caminho do Banco de Dados";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(385, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button1, "Localizar caminho");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCaminhoBanco
            // 
            this.txtCaminhoBanco.Location = new System.Drawing.Point(9, 19);
            this.txtCaminhoBanco.Name = "txtCaminhoBanco";
            this.txtCaminhoBanco.Size = new System.Drawing.Size(370, 20);
            this.txtCaminhoBanco.TabIndex = 0;
            // 
            // grpTipoConexao
            // 
            this.grpTipoConexao.Controls.Add(this.lblServidor);
            this.grpTipoConexao.Controls.Add(this.txtServidor);
            this.grpTipoConexao.Controls.Add(this.radRede);
            this.grpTipoConexao.Controls.Add(this.radLocal);
            this.grpTipoConexao.Location = new System.Drawing.Point(3, 3);
            this.grpTipoConexao.Name = "grpTipoConexao";
            this.grpTipoConexao.Size = new System.Drawing.Size(429, 65);
            this.grpTipoConexao.TabIndex = 0;
            this.grpTipoConexao.TabStop = false;
            this.grpTipoConexao.Text = "Tipo de Conexão";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(116, 23);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(46, 13);
            this.lblServidor.TabIndex = 1;
            this.lblServidor.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(119, 39);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(215, 20);
            this.txtServidor.TabIndex = 0;
            // 
            // radRede
            // 
            this.radRede.AutoSize = true;
            this.radRede.Location = new System.Drawing.Point(9, 42);
            this.radRede.Name = "radRede";
            this.radRede.Size = new System.Drawing.Size(51, 17);
            this.radRede.TabIndex = 2;
            this.radRede.Text = "Rede";
            this.radRede.UseVisualStyleBackColor = true;
            // 
            // radLocal
            // 
            this.radLocal.AutoSize = true;
            this.radLocal.Location = new System.Drawing.Point(9, 19);
            this.radLocal.Name = "radLocal";
            this.radLocal.Size = new System.Drawing.Size(51, 17);
            this.radLocal.TabIndex = 0;
            this.radLocal.Text = "Local";
            this.radLocal.UseVisualStyleBackColor = true;
            // 
            // frmConexaoBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 315);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "frmConexaoBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações de Conexão";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlFerramentas.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpCaminho.ResumeLayout(false);
            this.grpCaminho.PerformLayout();
            this.grpTipoConexao.ResumeLayout(false);
            this.grpTipoConexao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.GroupBox grpCaminho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtCaminhoBanco;
        private System.Windows.Forms.GroupBox grpTipoConexao;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.RadioButton radRede;
        private System.Windows.Forms.RadioButton radLocal;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel pnlFerramentas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
    }
}