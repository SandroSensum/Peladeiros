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
            this.bsoJogado = new System.Windows.Forms.BindingSource(this.components);
            this.dtsJogador = new CamadaLogica.DS.dtsJogador();
            ((System.ComponentModel.ISupportInitialize)(this.bsoJogado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // bsoJogado
            // 
            this.bsoJogado.DataMember = "JOGADOR";
            this.bsoJogado.DataSource = this.dtsJogador;
            // 
            // dtsJogador
            // 
            this.dtsJogador.DataSetName = "dtsJogador";
            this.dtsJogador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 378);
            this.Name = "frmJogador";
            this.Text = "frmJogador";
            this.Load += new System.EventHandler(this.frmJogador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsoJogado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsJogador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsoJogado;
        private CamadaLogica.DS.dtsJogador dtsJogador;
    }
}