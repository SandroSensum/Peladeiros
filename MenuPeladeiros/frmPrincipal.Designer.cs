namespace MenuPeladeiros
{
    partial class frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btJogadores = new System.Windows.Forms.Button();
            this.usuariosESenhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propriedadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.propriedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeJogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mesesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menMensalidades = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menJogadores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 29);
            this.panel2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(179, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 81);
            this.button2.TabIndex = 3;
            this.button2.Text = "Atrasos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(267, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 81);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btJogadores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 87);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(91, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "Menaslidades";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btJogadores
            // 
            this.btJogadores.Image = ((System.Drawing.Image)(resources.GetObject("btJogadores.Image")));
            this.btJogadores.Location = new System.Drawing.Point(3, 3);
            this.btJogadores.Name = "btJogadores";
            this.btJogadores.Size = new System.Drawing.Size(82, 81);
            this.btJogadores.TabIndex = 0;
            this.btJogadores.Text = "Jogadores";
            this.btJogadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btJogadores.UseVisualStyleBackColor = true;
            // 
            // usuariosESenhasToolStripMenuItem
            // 
            this.usuariosESenhasToolStripMenuItem.Name = "usuariosESenhasToolStripMenuItem";
            this.usuariosESenhasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.usuariosESenhasToolStripMenuItem.Text = "Usuarios e Senhas";
            // 
            // propriedadesToolStripMenuItem1
            // 
            this.propriedadesToolStripMenuItem1.Name = "propriedadesToolStripMenuItem1";
            this.propriedadesToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.propriedadesToolStripMenuItem1.Text = "Propriedades";
            this.propriedadesToolStripMenuItem1.Click += new System.EventHandler(this.propriedadesToolStripMenuItem1_Click);
            // 
            // propriedadesToolStripMenuItem
            // 
            this.propriedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propriedadesToolStripMenuItem1,
            this.usuariosESenhasToolStripMenuItem});
            this.propriedadesToolStripMenuItem.Name = "propriedadesToolStripMenuItem";
            this.propriedadesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.propriedadesToolStripMenuItem.Text = "Configurações";
            // 
            // atrasosToolStripMenuItem
            // 
            this.atrasosToolStripMenuItem.Name = "atrasosToolStripMenuItem";
            this.atrasosToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.atrasosToolStripMenuItem.Text = "&Atrasos";
            // 
            // mensalidadesToolStripMenuItem
            // 
            this.mensalidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasosToolStripMenuItem});
            this.mensalidadesToolStripMenuItem.Name = "mensalidadesToolStripMenuItem";
            this.mensalidadesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.mensalidadesToolStripMenuItem.Text = "&Mensalidades";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeJogadoresToolStripMenuItem,
            this.mensalidadesToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "&Relatorios";
            // 
            // listaDeJogadoresToolStripMenuItem
            // 
            this.listaDeJogadoresToolStripMenuItem.Name = "listaDeJogadoresToolStripMenuItem";
            this.listaDeJogadoresToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listaDeJogadoresToolStripMenuItem.Text = "&Lista de Jogadores";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem1.Text = "Valores";
            // 
            // mesesToolStripMenuItem
            // 
            this.mesesToolStripMenuItem.Name = "mesesToolStripMenuItem";
            this.mesesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.mesesToolStripMenuItem.Text = "Meses";
            // 
            // menMensalidades
            // 
            this.menMensalidades.Name = "menMensalidades";
            this.menMensalidades.Size = new System.Drawing.Size(146, 22);
            this.menMensalidades.Text = "&Mensalidades";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menMensalidades,
            this.mesesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // menJogadores
            // 
            this.menJogadores.Name = "menJogadores";
            this.menJogadores.Size = new System.Drawing.Size(152, 22);
            this.menJogadores.Text = "&Jogadores";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menCadastros
            // 
            this.menCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.menJogadores});
            this.menCadastros.Name = "menCadastros";
            this.menCadastros.Size = new System.Drawing.Size(71, 20);
            this.menCadastros.Text = "&Cadastros";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menCadastros,
            this.financeiroToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.propriedadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peladeiros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btJogadores;
        private System.Windows.Forms.ToolStripMenuItem usuariosESenhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propriedadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem propriedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeJogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mesesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menMensalidades;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menJogadores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menCadastros;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

