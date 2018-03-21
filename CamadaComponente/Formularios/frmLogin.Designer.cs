namespace CamadaComponente.Formularios
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFerramentas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlIncluir = new System.Windows.Forms.Panel();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.pnlSair = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFerramentas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlIncluir.SuspendLayout();
            this.pnlSair.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 188);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(138, 88);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(186, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(138, 40);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(186, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario";
            // 
            // pnlFerramentas
            // 
            this.pnlFerramentas.Controls.Add(this.panel2);
            this.pnlFerramentas.Controls.Add(this.pnlIncluir);
            this.pnlFerramentas.Controls.Add(this.pnlSair);
            this.pnlFerramentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFerramentas.Location = new System.Drawing.Point(0, 151);
            this.pnlFerramentas.Name = "pnlFerramentas";
            this.pnlFerramentas.Padding = new System.Windows.Forms.Padding(5);
            this.pnlFerramentas.Size = new System.Drawing.Size(347, 37);
            this.pnlFerramentas.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfigurar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 27);
            this.panel2.TabIndex = 36;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConfigurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurar.ImageKey = "gear.ico";
            this.btnConfigurar.ImageList = this.imageList1;
            this.btnConfigurar.Location = new System.Drawing.Point(0, 0);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(58, 27);
            this.btnConfigurar.TabIndex = 0;
            this.btnConfigurar.Text = "&Conf";
            this.btnConfigurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "gear.ico");
            // 
            // pnlIncluir
            // 
            this.pnlIncluir.Controls.Add(this.btnAcessar);
            this.pnlIncluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlIncluir.Location = new System.Drawing.Point(180, 5);
            this.pnlIncluir.Name = "pnlIncluir";
            this.pnlIncluir.Size = new System.Drawing.Size(82, 27);
            this.pnlIncluir.TabIndex = 0;
            // 
            // btnAcessar
            // 
            this.btnAcessar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAcessar.ImageList = this.imageList1;
            this.btnAcessar.Location = new System.Drawing.Point(8, 0);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(74, 27);
            this.btnAcessar.TabIndex = 0;
            this.btnAcessar.Text = "&Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // pnlSair
            // 
            this.pnlSair.Controls.Add(this.btnCancelar);
            this.pnlSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSair.Location = new System.Drawing.Point(262, 5);
            this.pnlSair.Name = "pnlSair";
            this.pnlSair.Size = new System.Drawing.Size(80, 27);
            this.pnlSair.TabIndex = 1;
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 188);
            this.Controls.Add(this.pnlFerramentas);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Acesso";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFerramentas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlIncluir.ResumeLayout(false);
            this.pnlSair.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlFerramentas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Panel pnlIncluir;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Panel pnlSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}