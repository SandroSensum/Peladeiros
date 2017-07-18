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
            this.grpTipoConexao = new System.Windows.Forms.GroupBox();
            this.radLocal = new System.Windows.Forms.RadioButton();
            this.radRede = new System.Windows.Forms.RadioButton();
            this.txtCaminhoServidor = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.grpCaminho = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.pnlPrincipal.SuspendLayout();
            this.grpTipoConexao.SuspendLayout();
            this.grpCaminho.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.grpLogin);
            this.pnlPrincipal.Controls.Add(this.grpCaminho);
            this.pnlPrincipal.Controls.Add(this.grpTipoConexao);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(524, 315);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // grpTipoConexao
            // 
            this.grpTipoConexao.Controls.Add(this.lblServidor);
            this.grpTipoConexao.Controls.Add(this.txtCaminhoServidor);
            this.grpTipoConexao.Controls.Add(this.radRede);
            this.grpTipoConexao.Controls.Add(this.radLocal);
            this.grpTipoConexao.Location = new System.Drawing.Point(3, 3);
            this.grpTipoConexao.Name = "grpTipoConexao";
            this.grpTipoConexao.Size = new System.Drawing.Size(518, 65);
            this.grpTipoConexao.TabIndex = 0;
            this.grpTipoConexao.TabStop = false;
            this.grpTipoConexao.Text = "Tipo de Conexão";
            // 
            // radLocal
            // 
            this.radLocal.AutoSize = true;
            this.radLocal.Location = new System.Drawing.Point(9, 19);
            this.radLocal.Name = "radLocal";
            this.radLocal.Size = new System.Drawing.Size(51, 17);
            this.radLocal.TabIndex = 0;
            this.radLocal.TabStop = true;
            this.radLocal.Text = "Local";
            this.radLocal.UseVisualStyleBackColor = true;
            // 
            // radRede
            // 
            this.radRede.AutoSize = true;
            this.radRede.Location = new System.Drawing.Point(9, 42);
            this.radRede.Name = "radRede";
            this.radRede.Size = new System.Drawing.Size(51, 17);
            this.radRede.TabIndex = 1;
            this.radRede.TabStop = true;
            this.radRede.Text = "Rede";
            this.radRede.UseVisualStyleBackColor = true;
            // 
            // txtCaminhoServidor
            // 
            this.txtCaminhoServidor.Location = new System.Drawing.Point(119, 39);
            this.txtCaminhoServidor.Name = "txtCaminhoServidor";
            this.txtCaminhoServidor.Size = new System.Drawing.Size(215, 20);
            this.txtCaminhoServidor.TabIndex = 2;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(116, 23);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(46, 13);
            this.lblServidor.TabIndex = 3;
            this.lblServidor.Text = "Servidor";
            // 
            // grpCaminho
            // 
            this.grpCaminho.Controls.Add(this.button1);
            this.grpCaminho.Controls.Add(this.textBox1);
            this.grpCaminho.Location = new System.Drawing.Point(3, 74);
            this.grpCaminho.Name = "grpCaminho";
            this.grpCaminho.Size = new System.Drawing.Size(518, 51);
            this.grpCaminho.TabIndex = 1;
            this.grpCaminho.TabStop = false;
            this.grpCaminho.Text = "Caminho do Banco de Dados";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(474, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button1, "Localizar caminho");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_gear.ico");
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(58, 23);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(129, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(58, 48);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(129, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Location = new System.Drawing.Point(69, 74);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(104, 23);
            this.btnTestarConexao.TabIndex = 7;
            this.btnTestarConexao.Text = "Testar Conexão";
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            // 
            // frmConexaoBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 315);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "frmConexaoBanco";
            this.Text = "frmConexaoBanco";
            this.pnlPrincipal.ResumeLayout(false);
            this.grpTipoConexao.ResumeLayout(false);
            this.grpTipoConexao.PerformLayout();
            this.grpCaminho.ResumeLayout(false);
            this.grpCaminho.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.GroupBox grpCaminho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpTipoConexao;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtCaminhoServidor;
        private System.Windows.Forms.RadioButton radRede;
        private System.Windows.Forms.RadioButton radLocal;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}