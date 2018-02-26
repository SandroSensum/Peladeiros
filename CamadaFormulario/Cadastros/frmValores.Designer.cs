namespace CamadaFormulario.Cadastros
{
    partial class frmValores
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblMes;
            System.Windows.Forms.Label lblCadastro;
            System.Windows.Forms.Label lblValor;
            System.Windows.Forms.Label lblAno;
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.txtCadastro = new System.Windows.Forms.MaskedTextBox();
            lblMes = new System.Windows.Forms.Label();
            lblCadastro = new System.Windows.Forms.Label();
            lblValor = new System.Windows.Forms.Label();
            lblAno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbcPadrao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.txtValor);
            this.tabPrincipal.Controls.Add(this.txtAno);
            this.tabPrincipal.Controls.Add(this.cboMes);
            this.tabPrincipal.Controls.Add(lblMes);
            this.tabPrincipal.Controls.Add(this.txtCadastro);
            this.tabPrincipal.Controls.Add(lblCadastro);
            this.tabPrincipal.Controls.Add(lblValor);
            this.tabPrincipal.Controls.Add(lblAno);
            this.tabPrincipal.Controls.Add(this.lblCodigo);
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            this.tabPrincipal.Size = new System.Drawing.Size(499, 198);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(507, 224);
            // 
            // tbcPadrao
            // 
            this.tbcPadrao.Size = new System.Drawing.Size(507, 224);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 56;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPadrao, "COD_JOGADOR", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(20, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 57;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(20, 160);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(97, 20);
            this.txtValor.TabIndex = 60;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(20, 121);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(71, 20);
            this.txtAno.TabIndex = 59;
            // 
            // cboMes
            // 
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(19, 83);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(50, 21);
            this.cboMes.TabIndex = 58;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new System.Drawing.Point(19, 67);
            lblMes.Name = "lblMes";
            lblMes.Size = new System.Drawing.Size(27, 13);
            lblMes.TabIndex = 65;
            lblMes.Text = "Mês";
            // 
            // txtCadastro
            // 
            this.txtCadastro.Enabled = false;
            this.txtCadastro.Location = new System.Drawing.Point(123, 160);
            this.txtCadastro.Mask = "00/00/0000";
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.ReadOnly = true;
            this.txtCadastro.Size = new System.Drawing.Size(84, 20);
            this.txtCadastro.TabIndex = 64;
            this.txtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Location = new System.Drawing.Point(120, 144);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new System.Drawing.Size(75, 13);
            lblCadastro.TabIndex = 63;
            lblCadastro.Text = "Data Cadastro";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new System.Drawing.Point(19, 144);
            lblValor.Name = "lblValor";
            lblValor.Size = new System.Drawing.Size(31, 13);
            lblValor.TabIndex = 62;
            lblValor.Text = "Valor";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new System.Drawing.Point(20, 105);
            lblAno.Name = "lblAno";
            lblAno.Size = new System.Drawing.Size(26, 13);
            lblAno.TabIndex = 61;
            lblAno.Text = "Ano";
            // 
            // frmValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(507, 286);
            this.Name = "frmValores";
            this.Text = "Cadastro de Valores";
            ((System.ComponentModel.ISupportInitialize)(this.bsoPadrao)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.pnlResultado.ResumeLayout(false);
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tbcPadrao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.MaskedTextBox txtCadastro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}
