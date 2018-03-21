namespace CamadaComponente.Componentes
{
    partial class cpAtivoInativo
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbTitulo = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDesativado = new System.Windows.Forms.MaskedTextBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gpbTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbTitulo
            // 
            this.gpbTitulo.Controls.Add(this.label10);
            this.gpbTitulo.Controls.Add(this.txtDesativado);
            this.gpbTitulo.Controls.Add(this.rbInativo);
            this.gpbTitulo.Controls.Add(this.rbAtivo);
            this.gpbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbTitulo.Location = new System.Drawing.Point(0, 0);
            this.gpbTitulo.Name = "gpbTitulo";
            this.gpbTitulo.Size = new System.Drawing.Size(100, 107);
            this.gpbTitulo.TabIndex = 46;
            this.gpbTitulo.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Data Desativado";
            // 
            // txtDesativado
            // 
            this.txtDesativado.Location = new System.Drawing.Point(6, 80);
            this.txtDesativado.Mask = "00/00/0000";
            this.txtDesativado.Name = "txtDesativado";
            this.txtDesativado.ReadOnly = true;
            this.txtDesativado.Size = new System.Drawing.Size(84, 20);
            this.txtDesativado.TabIndex = 48;
            this.txtDesativado.ValidatingType = typeof(System.DateTime);
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(6, 33);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 47;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            this.rbInativo.CheckedChanged += new System.EventHandler(this.rbInativo_CheckedChanged);
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(6, 11);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 46;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // cpAtivoInativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbTitulo);
            this.Name = "cpAtivoInativo";
            this.Size = new System.Drawing.Size(100, 107);
            this.Load += new System.EventHandler(this.cpAtivoInativo_Load);
            this.gpbTitulo.ResumeLayout(false);
            this.gpbTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtDesativado;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
    }
}
