namespace Fleets.Controls.Menus
{
    partial class CadastroSeguro
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblCobertura = new System.Windows.Forms.Label();
            this.txtVigencia = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtSeguradora = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCadastroSeguro = new System.Windows.Forms.Label();
            this.imgFleets = new System.Windows.Forms.PictureBox();
            this.txtCobertura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrigem
            // 
            this.lblOrigem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblOrigem.ForeColor = System.Drawing.Color.Yellow;
            this.lblOrigem.Location = new System.Drawing.Point(95, 194);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(219, 24);
            this.lblOrigem.TabIndex = 83;
            this.lblOrigem.Text = "Dados da Seguradora:";
            // 
            // lblCobertura
            // 
            this.lblCobertura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCobertura.AutoSize = true;
            this.lblCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCobertura.ForeColor = System.Drawing.Color.Yellow;
            this.lblCobertura.Location = new System.Drawing.Point(301, 355);
            this.lblCobertura.Name = "lblCobertura";
            this.lblCobertura.Size = new System.Drawing.Size(84, 20);
            this.lblCobertura.TabIndex = 81;
            this.lblCobertura.Text = "Cobertura:";
            // 
            // txtVigencia
            // 
            this.txtVigencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVigencia.Location = new System.Drawing.Point(199, 346);
            this.txtVigencia.Mask = "00/00/0000";
            this.txtVigencia.Name = "txtVigencia";
            this.txtVigencia.Size = new System.Drawing.Size(100, 29);
            this.txtVigencia.TabIndex = 78;
            this.txtVigencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVigencia.ValidatingType = typeof(System.DateTime);
            // 
            // lblCEP
            // 
            this.lblCEP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.Yellow;
            this.lblCEP.Location = new System.Drawing.Point(96, 352);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(74, 20);
            this.lblCEP.TabIndex = 77;
            this.lblCEP.Text = "Vigência:";
            // 
            // txtSeguradora
            // 
            this.txtSeguradora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguradora.Location = new System.Drawing.Point(199, 249);
            this.txtSeguradora.MaxLength = 15;
            this.txtSeguradora.Name = "txtSeguradora";
            this.txtSeguradora.Size = new System.Drawing.Size(587, 26);
            this.txtSeguradora.TabIndex = 74;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.ForeColor = System.Drawing.Color.Yellow;
            this.lblLogradouro.Location = new System.Drawing.Point(96, 255);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(97, 20);
            this.lblLogradouro.TabIndex = 73;
            this.lblLogradouro.Text = "Seguradora:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCadastrar.BackColor = System.Drawing.Color.Yellow;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCadastrar.Location = new System.Drawing.Point(669, 530);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(113, 37);
            this.btnCadastrar.TabIndex = 72;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnVoltar.BackColor = System.Drawing.Color.Yellow;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.DimGray;
            this.btnVoltar.Location = new System.Drawing.Point(103, 530);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 37);
            this.btnVoltar.TabIndex = 71;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCadastroSeguro
            // 
            this.lblCadastroSeguro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroSeguro.AutoSize = true;
            this.lblCadastroSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroSeguro.ForeColor = System.Drawing.Color.Yellow;
            this.lblCadastroSeguro.Location = new System.Drawing.Point(293, 144);
            this.lblCadastroSeguro.Name = "lblCadastroSeguro";
            this.lblCadastroSeguro.Size = new System.Drawing.Size(339, 37);
            this.lblCadastroSeguro.TabIndex = 70;
            this.lblCadastroSeguro.Text = "Cadastro de Seguros";
            // 
            // imgFleets
            // 
            this.imgFleets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgFleets.BackgroundImage = global::Fleets.Properties.Resources._1;
            this.imgFleets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFleets.Location = new System.Drawing.Point(333, -19);
            this.imgFleets.Name = "imgFleets";
            this.imgFleets.Size = new System.Drawing.Size(259, 160);
            this.imgFleets.TabIndex = 69;
            this.imgFleets.TabStop = false;
            // 
            // txtCobertura
            // 
            this.txtCobertura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCobertura.Location = new System.Drawing.Point(391, 349);
            this.txtCobertura.MaxLength = 10;
            this.txtCobertura.Name = "txtCobertura";
            this.txtCobertura.Size = new System.Drawing.Size(395, 26);
            this.txtCobertura.TabIndex = 79;
            // 
            // CadastroSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.txtCobertura);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.lblCobertura);
            this.Controls.Add(this.txtVigencia);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtSeguradora);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblCadastroSeguro);
            this.Controls.Add(this.imgFleets);
            this.Name = "CadastroSeguro";
            this.Size = new System.Drawing.Size(880, 576);
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblCobertura;
        private System.Windows.Forms.MaskedTextBox txtVigencia;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtSeguradora;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCadastroSeguro;
        private System.Windows.Forms.PictureBox imgFleets;
        private System.Windows.Forms.TextBox txtCobertura;
    }
}
