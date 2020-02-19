namespace Fleets.Controls.Cadastros
{
    partial class CadastroFrotas
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblDadosFrota = new System.Windows.Forms.Label();
            this.lblCadastroFrotas = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtQtdMotoristas = new System.Windows.Forms.TextBox();
            this.lblQtdMotorista = new System.Windows.Forms.Label();
            this.imgFleets = new System.Windows.Forms.PictureBox();
            this.lblQtdVeiculos = new System.Windows.Forms.Label();
            this.txtQtdVeiculos = new System.Windows.Forms.TextBox();
            this.lblNomeFrota = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtNomeFrota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).BeginInit();
            this.SuspendLayout();
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
            this.btnCadastrar.Location = new System.Drawing.Point(600, 589);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(108, 37);
            this.btnCadastrar.TabIndex = 110;
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
            this.btnVoltar.Location = new System.Drawing.Point(45, 589);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 37);
            this.btnVoltar.TabIndex = 109;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblDadosFrota
            // 
            this.lblDadosFrota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDadosFrota.AutoSize = true;
            this.lblDadosFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosFrota.ForeColor = System.Drawing.Color.Yellow;
            this.lblDadosFrota.Location = new System.Drawing.Point(41, 236);
            this.lblDadosFrota.Name = "lblDadosFrota";
            this.lblDadosFrota.Size = new System.Drawing.Size(158, 24);
            this.lblDadosFrota.TabIndex = 87;
            this.lblDadosFrota.Text = "Dados da Frota:";
            // 
            // lblCadastroFrotas
            // 
            this.lblCadastroFrotas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroFrotas.AutoSize = true;
            this.lblCadastroFrotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroFrotas.ForeColor = System.Drawing.Color.Yellow;
            this.lblCadastroFrotas.Location = new System.Drawing.Point(227, 183);
            this.lblCadastroFrotas.Name = "lblCadastroFrotas";
            this.lblCadastroFrotas.Size = new System.Drawing.Size(294, 37);
            this.lblCadastroFrotas.TabIndex = 84;
            this.lblCadastroFrotas.Text = "Cadastro de Frota";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.Yellow;
            this.lblEmpresa.Location = new System.Drawing.Point(41, 296);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(77, 20);
            this.lblEmpresa.TabIndex = 83;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // txtQtdMotoristas
            // 
            this.txtQtdMotoristas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtdMotoristas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdMotoristas.Location = new System.Drawing.Point(234, 408);
            this.txtQtdMotoristas.MaxLength = 4;
            this.txtQtdMotoristas.Name = "txtQtdMotoristas";
            this.txtQtdMotoristas.Size = new System.Drawing.Size(119, 26);
            this.txtQtdMotoristas.TabIndex = 107;
            // 
            // lblQtdMotorista
            // 
            this.lblQtdMotorista.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQtdMotorista.AutoSize = true;
            this.lblQtdMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdMotorista.ForeColor = System.Drawing.Color.Yellow;
            this.lblQtdMotorista.Location = new System.Drawing.Point(43, 411);
            this.lblQtdMotorista.Name = "lblQtdMotorista";
            this.lblQtdMotorista.Size = new System.Drawing.Size(196, 20);
            this.lblQtdMotorista.TabIndex = 81;
            this.lblQtdMotorista.Text = "Quantidade de Motoristas:";
            // 
            // imgFleets
            // 
            this.imgFleets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgFleets.BackgroundImage = global::Fleets.Properties.Resources._1;
            this.imgFleets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFleets.Location = new System.Drawing.Point(245, 11);
            this.imgFleets.Name = "imgFleets";
            this.imgFleets.Size = new System.Drawing.Size(259, 160);
            this.imgFleets.TabIndex = 80;
            this.imgFleets.TabStop = false;
            // 
            // lblQtdVeiculos
            // 
            this.lblQtdVeiculos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQtdVeiculos.AutoSize = true;
            this.lblQtdVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdVeiculos.ForeColor = System.Drawing.Color.Yellow;
            this.lblQtdVeiculos.Location = new System.Drawing.Point(408, 411);
            this.lblQtdVeiculos.Name = "lblQtdVeiculos";
            this.lblQtdVeiculos.Size = new System.Drawing.Size(182, 20);
            this.lblQtdVeiculos.TabIndex = 104;
            this.lblQtdVeiculos.Text = "Quantidade de Veiculos:";
            // 
            // txtQtdVeiculos
            // 
            this.txtQtdVeiculos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtQtdVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdVeiculos.Location = new System.Drawing.Point(589, 408);
            this.txtQtdVeiculos.MaxLength = 4;
            this.txtQtdVeiculos.Name = "txtQtdVeiculos";
            this.txtQtdVeiculos.Size = new System.Drawing.Size(119, 26);
            this.txtQtdVeiculos.TabIndex = 108;
            // 
            // lblNomeFrota
            // 
            this.lblNomeFrota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNomeFrota.AutoSize = true;
            this.lblNomeFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFrota.ForeColor = System.Drawing.Color.Yellow;
            this.lblNomeFrota.Location = new System.Drawing.Point(41, 352);
            this.lblNomeFrota.Name = "lblNomeFrota";
            this.lblNomeFrota.Size = new System.Drawing.Size(119, 20);
            this.lblNomeFrota.TabIndex = 108;
            this.lblNomeFrota.Text = "Nome da Frota:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(166, 293);
            this.txtEmpresa.MaxLength = 30;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(542, 26);
            this.txtEmpresa.TabIndex = 105;
            // 
            // txtNomeFrota
            // 
            this.txtNomeFrota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFrota.Location = new System.Drawing.Point(166, 346);
            this.txtNomeFrota.MaxLength = 30;
            this.txtNomeFrota.Name = "txtNomeFrota";
            this.txtNomeFrota.Size = new System.Drawing.Size(542, 26);
            this.txtNomeFrota.TabIndex = 106;
            // 
            // CadastroFrotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.txtNomeFrota);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblNomeFrota);
            this.Controls.Add(this.txtQtdVeiculos);
            this.Controls.Add(this.lblQtdVeiculos);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblDadosFrota);
            this.Controls.Add(this.lblCadastroFrotas);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.txtQtdMotoristas);
            this.Controls.Add(this.lblQtdMotorista);
            this.Controls.Add(this.imgFleets);
            this.Name = "CadastroFrotas";
            this.Size = new System.Drawing.Size(748, 637);
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblDadosFrota;
        private System.Windows.Forms.Label lblCadastroFrotas;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtQtdMotoristas;
        private System.Windows.Forms.Label lblQtdMotorista;
        private System.Windows.Forms.PictureBox imgFleets;
        private System.Windows.Forms.Label lblQtdVeiculos;
        private System.Windows.Forms.TextBox txtQtdVeiculos;
        private System.Windows.Forms.Label lblNomeFrota;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtNomeFrota;
    }
}
