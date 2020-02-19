namespace Fleets
{
    partial class Viagens
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
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.btnBuscarViagem = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtBuscaViagem = new System.Windows.Forms.TextBox();
            this.lblNomeCidade = new System.Windows.Forms.Label();
            this.imgFleets = new System.Windows.Forms.PictureBox();
            this.cadastroViagens1 = new Fleets.Controls.Cadastros.CadastroViagens();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCodViagemAlterar = new System.Windows.Forms.Label();
            this.txtCodViagemAlterar = new System.Windows.Forms.TextBox();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.lblCodViagemExcluir = new System.Windows.Forms.Label();
            this.txtCodViagemExcluir = new System.Windows.Forms.TextBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.listViagens = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCadFuncionario.BackColor = System.Drawing.Color.Yellow;
            this.btnCadFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCadFuncionario.ForeColor = System.Drawing.Color.DimGray;
            this.btnCadFuncionario.Location = new System.Drawing.Point(90, 512);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(162, 33);
            this.btnCadFuncionario.TabIndex = 0;
            this.btnCadFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadFuncionario.UseVisualStyleBackColor = false;
            this.btnCadFuncionario.Click += new System.EventHandler(this.BtnCadViagem_Click);
            // 
            // btnBuscarViagem
            // 
            this.btnBuscarViagem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscarViagem.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscarViagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarViagem.FlatAppearance.BorderSize = 0;
            this.btnBuscarViagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarViagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarViagem.ForeColor = System.Drawing.Color.DimGray;
            this.btnBuscarViagem.Location = new System.Drawing.Point(664, 193);
            this.btnBuscarViagem.Name = "btnBuscarViagem";
            this.btnBuscarViagem.Size = new System.Drawing.Size(123, 36);
            this.btnBuscarViagem.TabIndex = 2;
            this.btnBuscarViagem.Text = "Buscar Viagem";
            this.btnBuscarViagem.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVoltar.BackColor = System.Drawing.Color.Yellow;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.DimGray;
            this.btnVoltar.Location = new System.Drawing.Point(677, 512);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 33);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // txtBuscaViagem
            // 
            this.txtBuscaViagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtBuscaViagem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscaViagem.Location = new System.Drawing.Point(265, 194);
            this.txtBuscaViagem.Name = "txtBuscaViagem";
            this.txtBuscaViagem.Size = new System.Drawing.Size(393, 35);
            this.txtBuscaViagem.TabIndex = 1;
            // 
            // lblNomeCidade
            // 
            this.lblNomeCidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNomeCidade.AutoSize = true;
            this.lblNomeCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNomeCidade.ForeColor = System.Drawing.Color.Yellow;
            this.lblNomeCidade.Location = new System.Drawing.Point(86, 199);
            this.lblNomeCidade.Name = "lblNomeCidade";
            this.lblNomeCidade.Size = new System.Drawing.Size(173, 24);
            this.lblNomeCidade.TabIndex = 6;
            this.lblNomeCidade.Text = "Nome da Cidade:";
            // 
            // imgFleets
            // 
            this.imgFleets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgFleets.BackgroundImage = global::Fleets.Properties.Resources._1;
            this.imgFleets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFleets.Location = new System.Drawing.Point(318, 15);
            this.imgFleets.Name = "imgFleets";
            this.imgFleets.Size = new System.Drawing.Size(259, 160);
            this.imgFleets.TabIndex = 4;
            this.imgFleets.TabStop = false;
            // 
            // cadastroViagens1
            // 
            this.cadastroViagens1.BackColor = System.Drawing.Color.DimGray;
            this.cadastroViagens1.Location = new System.Drawing.Point(-677, -296);
            this.cadastroViagens1.Name = "cadastroViagens1";
            this.cadastroViagens1.Size = new System.Drawing.Size(748, 637);
            this.cadastroViagens1.TabIndex = 8;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAlterar.BackColor = System.Drawing.Color.Yellow;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterar.Location = new System.Drawing.Point(521, 453);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(266, 33);
            this.btnAlterar.TabIndex = 47;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExcluir.BackColor = System.Drawing.Color.Yellow;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.DimGray;
            this.btnExcluir.Location = new System.Drawing.Point(521, 325);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(266, 33);
            this.btnExcluir.TabIndex = 46;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblCodViagemAlterar
            // 
            this.lblCodViagemAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodViagemAlterar.AutoSize = true;
            this.lblCodViagemAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodViagemAlterar.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodViagemAlterar.Location = new System.Drawing.Point(516, 398);
            this.lblCodViagemAlterar.Name = "lblCodViagemAlterar";
            this.lblCodViagemAlterar.Size = new System.Drawing.Size(143, 20);
            this.lblCodViagemAlterar.TabIndex = 45;
            this.lblCodViagemAlterar.Text = "Código da Viagem:";
            // 
            // txtCodViagemAlterar
            // 
            this.txtCodViagemAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodViagemAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodViagemAlterar.Location = new System.Drawing.Point(521, 421);
            this.txtCodViagemAlterar.Name = "txtCodViagemAlterar";
            this.txtCodViagemAlterar.Size = new System.Drawing.Size(266, 26);
            this.txtCodViagemAlterar.TabIndex = 44;
            // 
            // lblAlterar
            // 
            this.lblAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAlterar.AutoSize = true;
            this.lblAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterar.ForeColor = System.Drawing.Color.Yellow;
            this.lblAlterar.Location = new System.Drawing.Point(517, 373);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(63, 20);
            this.lblAlterar.TabIndex = 43;
            this.lblAlterar.Text = "Alterar";
            // 
            // lblCodViagemExcluir
            // 
            this.lblCodViagemExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodViagemExcluir.AutoSize = true;
            this.lblCodViagemExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodViagemExcluir.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodViagemExcluir.Location = new System.Drawing.Point(516, 270);
            this.lblCodViagemExcluir.Name = "lblCodViagemExcluir";
            this.lblCodViagemExcluir.Size = new System.Drawing.Size(143, 20);
            this.lblCodViagemExcluir.TabIndex = 42;
            this.lblCodViagemExcluir.Text = "Código da Viagem:";
            // 
            // txtCodViagemExcluir
            // 
            this.txtCodViagemExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodViagemExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodViagemExcluir.Location = new System.Drawing.Point(521, 293);
            this.txtCodViagemExcluir.Name = "txtCodViagemExcluir";
            this.txtCodViagemExcluir.Size = new System.Drawing.Size(266, 26);
            this.txtCodViagemExcluir.TabIndex = 41;
            // 
            // lblExcluir
            // 
            this.lblExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.Color.Yellow;
            this.lblExcluir.Location = new System.Drawing.Point(517, 242);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(62, 20);
            this.lblExcluir.TabIndex = 40;
            this.lblExcluir.Text = "Excluir";
            // 
            // listViagens
            // 
            this.listViagens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViagens.HideSelection = false;
            this.listViagens.Location = new System.Drawing.Point(90, 242);
            this.listViagens.Name = "listViagens";
            this.listViagens.Size = new System.Drawing.Size(421, 244);
            this.listViagens.TabIndex = 48;
            this.listViagens.UseCompatibleStateImageBehavior = false;
            // 
            // Viagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.listViagens);
            this.Controls.Add(this.cadastroViagens1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblCodViagemAlterar);
            this.Controls.Add(this.txtCodViagemAlterar);
            this.Controls.Add(this.lblAlterar);
            this.Controls.Add(this.lblCodViagemExcluir);
            this.Controls.Add(this.txtCodViagemExcluir);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.lblNomeCidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.imgFleets);
            this.Controls.Add(this.btnBuscarViagem);
            this.Controls.Add(this.txtBuscaViagem);
            this.Controls.Add(this.btnCadFuncionario);
            this.Name = "Viagens";
            this.Size = new System.Drawing.Size(880, 576);
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadFuncionario;
        private System.Windows.Forms.Button btnBuscarViagem;
        private System.Windows.Forms.PictureBox imgFleets;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtBuscaViagem;
        private System.Windows.Forms.Label lblNomeCidade;
        private Controls.Cadastros.CadastroViagens cadastroViagens1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCodViagemAlterar;
        private System.Windows.Forms.TextBox txtCodViagemAlterar;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.Label lblCodViagemExcluir;
        private System.Windows.Forms.TextBox txtCodViagemExcluir;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.ListView listViagens;
    }
}
