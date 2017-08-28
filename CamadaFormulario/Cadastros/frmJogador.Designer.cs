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
            this.jogador1 = new CamadaLogica.Classes.Jogador();
            this.dtsJogador1 = new CamadaLogica.DS.dtsJogador();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsJogador1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsoPadrao
            // 
            this.bsoPadrao.DataMember = "JOGADOR";
            this.bsoPadrao.DataSource = this.dtsJogador1;
            // 
            // dtsJogador1
            // 
            this.dtsJogador1.DataSetName = "dtsJogador";
            this.dtsJogador1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClasseDados = this.jogador1;
            this.ClientSize = new System.Drawing.Size(827, 446);
            this.Name = "frmJogador";
            this.Text = "frmJogador";
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsJogador1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CamadaLogica.Classes.Jogador jogador1;
        private CamadaLogica.DS.dtsJogador dtsJogador1;
    }
}