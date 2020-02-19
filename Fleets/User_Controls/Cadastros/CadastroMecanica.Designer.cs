namespace Fleets.Controls.Cadastros
{
    partial class CadastroMecanica
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
            this.lblDadosPessoais = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblManutencao = new System.Windows.Forms.Label();
            this.txtRegistroMecanica = new System.Windows.Forms.TextBox();
            this.lblRegistroMecanica = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCadastroMecanica = new System.Windows.Forms.Label();
            this.imgFleets = new System.Windows.Forms.PictureBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.cbCidade = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.TextBox();
            this.cbManutencoes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDadosPessoais
            // 
            this.lblDadosPessoais.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDadosPessoais.AutoSize = true;
            this.lblDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDadosPessoais.ForeColor = System.Drawing.Color.Yellow;
            this.lblDadosPessoais.Location = new System.Drawing.Point(30, 225);
            this.lblDadosPessoais.Name = "lblDadosPessoais";
            this.lblDadosPessoais.Size = new System.Drawing.Size(200, 24);
            this.lblDadosPessoais.TabIndex = 83;
            this.lblDadosPessoais.Text = "Dados da Mecânica:";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Yellow;
            this.lblCidade.Location = new System.Drawing.Point(462, 368);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 81;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Yellow;
            this.lblEstado.Location = new System.Drawing.Point(192, 366);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 79;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCep
            // 
            this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(83, 362);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 29);
            this.txtCep.TabIndex = 78;
            // 
            // lblCEP
            // 
            this.lblCEP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.Yellow;
            this.lblCEP.Location = new System.Drawing.Point(32, 366);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(45, 20);
            this.lblCEP.TabIndex = 77;
            this.lblCEP.Text = "CEP:";
            // 
            // lblManutencao
            // 
            this.lblManutencao.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblManutencao.AutoSize = true;
            this.lblManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManutencao.ForeColor = System.Drawing.Color.Yellow;
            this.lblManutencao.Location = new System.Drawing.Point(460, 254);
            this.lblManutencao.Name = "lblManutencao";
            this.lblManutencao.Size = new System.Drawing.Size(102, 20);
            this.lblManutencao.TabIndex = 75;
            this.lblManutencao.Text = "Manutenção:";
            // 
            // txtRegistroMecanica
            // 
            this.txtRegistroMecanica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistroMecanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroMecanica.Location = new System.Drawing.Point(181, 251);
            this.txtRegistroMecanica.MaxLength = 10;
            this.txtRegistroMecanica.Name = "txtRegistroMecanica";
            this.txtRegistroMecanica.Size = new System.Drawing.Size(273, 26);
            this.txtRegistroMecanica.TabIndex = 74;
            // 
            // lblRegistroMecanica
            // 
            this.lblRegistroMecanica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRegistroMecanica.AutoSize = true;
            this.lblRegistroMecanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroMecanica.ForeColor = System.Drawing.Color.Yellow;
            this.lblRegistroMecanica.Location = new System.Drawing.Point(30, 257);
            this.lblRegistroMecanica.Name = "lblRegistroMecanica";
            this.lblRegistroMecanica.Size = new System.Drawing.Size(145, 20);
            this.lblRegistroMecanica.TabIndex = 73;
            this.lblRegistroMecanica.Text = "Registro Mecânica:";
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
            this.btnCadastrar.Location = new System.Drawing.Point(603, 589);
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
            this.btnVoltar.Location = new System.Drawing.Point(37, 589);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 37);
            this.btnVoltar.TabIndex = 71;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCadastroMecanica
            // 
            this.lblCadastroMecanica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroMecanica.AutoSize = true;
            this.lblCadastroMecanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroMecanica.ForeColor = System.Drawing.Color.Yellow;
            this.lblCadastroMecanica.Location = new System.Drawing.Point(227, 174);
            this.lblCadastroMecanica.Name = "lblCadastroMecanica";
            this.lblCadastroMecanica.Size = new System.Drawing.Size(357, 37);
            this.lblCadastroMecanica.TabIndex = 70;
            this.lblCadastroMecanica.Text = "Cadastro de Mecânica";
            // 
            // imgFleets
            // 
            this.imgFleets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgFleets.BackgroundImage = global::Fleets.Properties.Resources._1;
            this.imgFleets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFleets.Location = new System.Drawing.Point(276, 11);
            this.imgFleets.Name = "imgFleets";
            this.imgFleets.Size = new System.Drawing.Size(259, 160);
            this.imgFleets.TabIndex = 69;
            this.imgFleets.TabStop = false;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.ForeColor = System.Drawing.Color.Yellow;
            this.lblLogradouro.Location = new System.Drawing.Point(33, 487);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(95, 20);
            this.lblLogradouro.TabIndex = 85;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(134, 484);
            this.txtLogradouro.MaxLength = 25;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(582, 26);
            this.txtLogradouro.TabIndex = 86;
            // 
            // cbCidade
            // 
            this.cbCidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidade.Location = new System.Drawing.Point(531, 363);
            this.cbCidade.MaxLength = 15;
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(185, 26);
            this.cbCidade.TabIndex = 87;
            // 
            // cbEstado
            // 
            this.cbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.Location = new System.Drawing.Point(253, 363);
            this.cbEstado.MaxLength = 2;
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(203, 26);
            this.cbEstado.TabIndex = 88;
            // 
            // cbManutencoes
            // 
            this.cbManutencoes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbManutencoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManutencoes.Location = new System.Drawing.Point(568, 251);
            this.cbManutencoes.MaxLength = 15;
            this.cbManutencoes.Name = "cbManutencoes";
            this.cbManutencoes.Size = new System.Drawing.Size(148, 26);
            this.cbManutencoes.TabIndex = 89;
            // 
            // CadastroMecanica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.cbManutencoes);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblDadosPessoais);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblManutencao);
            this.Controls.Add(this.txtRegistroMecanica);
            this.Controls.Add(this.lblRegistroMecanica);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblCadastroMecanica);
            this.Controls.Add(this.imgFleets);
            this.Name = "CadastroMecanica";
            this.Size = new System.Drawing.Size(748, 637);
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDadosPessoais;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblManutencao;
        private System.Windows.Forms.TextBox txtRegistroMecanica;
        private System.Windows.Forms.Label lblRegistroMecanica;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCadastroMecanica;
        private System.Windows.Forms.PictureBox imgFleets;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox cbCidade;
        private System.Windows.Forms.TextBox cbEstado;
        private System.Windows.Forms.TextBox cbManutencoes;
    }
}
