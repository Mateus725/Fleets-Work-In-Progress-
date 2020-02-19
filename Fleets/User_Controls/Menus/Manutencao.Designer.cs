namespace Fleets.Controls.Menus
{
    partial class Manutencao
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
            this.listManutencao = new System.Windows.Forms.ListBox();
            this.lblCodManutencao = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscarManutencao = new System.Windows.Forms.Button();
            this.txtBuscaManutencao = new System.Windows.Forms.TextBox();
            this.btnCadManutencao = new System.Windows.Forms.Button();
            this.imgFleets = new System.Windows.Forms.PictureBox();
            this.cadastroManutencao1 = new Fleets.Controls.Cadastros.CadastroManutencao();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCodManutencaoAlterar = new System.Windows.Forms.Label();
            this.txtCodManutencaoAlterar = new System.Windows.Forms.TextBox();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.lblCodManutencaoExcluir = new System.Windows.Forms.Label();
            this.txtCodManutencaoExcluir = new System.Windows.Forms.TextBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).BeginInit();
            this.SuspendLayout();
            // 
            // listManutencao
            // 
            this.listManutencao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listManutencao.FormattingEnabled = true;
            this.listManutencao.ItemHeight = 24;
            this.listManutencao.Location = new System.Drawing.Point(98, 247);
            this.listManutencao.Name = "listManutencao";
            this.listManutencao.Size = new System.Drawing.Size(412, 244);
            this.listManutencao.TabIndex = 14;
            // 
            // lblCodManutencao
            // 
            this.lblCodManutencao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCodManutencao.AutoSize = true;
            this.lblCodManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCodManutencao.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodManutencao.Location = new System.Drawing.Point(94, 206);
            this.lblCodManutencao.Name = "lblCodManutencao";
            this.lblCodManutencao.Size = new System.Drawing.Size(204, 24);
            this.lblCodManutencao.TabIndex = 13;
            this.lblCodManutencao.Text = "Código Manutenção:";
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
            this.btnVoltar.Location = new System.Drawing.Point(676, 518);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 33);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnBuscarManutencao
            // 
            this.btnBuscarManutencao.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscarManutencao.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscarManutencao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarManutencao.FlatAppearance.BorderSize = 0;
            this.btnBuscarManutencao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarManutencao.ForeColor = System.Drawing.Color.DimGray;
            this.btnBuscarManutencao.Location = new System.Drawing.Point(663, 200);
            this.btnBuscarManutencao.Name = "btnBuscarManutencao";
            this.btnBuscarManutencao.Size = new System.Drawing.Size(123, 36);
            this.btnBuscarManutencao.TabIndex = 10;
            this.btnBuscarManutencao.Text = "Buscar Manutencao";
            this.btnBuscarManutencao.UseVisualStyleBackColor = false;
            // 
            // txtBuscaManutencao
            // 
            this.txtBuscaManutencao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtBuscaManutencao.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscaManutencao.Location = new System.Drawing.Point(298, 200);
            this.txtBuscaManutencao.Name = "txtBuscaManutencao";
            this.txtBuscaManutencao.Size = new System.Drawing.Size(359, 35);
            this.txtBuscaManutencao.TabIndex = 9;
            // 
            // btnCadManutencao
            // 
            this.btnCadManutencao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCadManutencao.BackColor = System.Drawing.Color.Yellow;
            this.btnCadManutencao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadManutencao.FlatAppearance.BorderSize = 0;
            this.btnCadManutencao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCadManutencao.ForeColor = System.Drawing.Color.DimGray;
            this.btnCadManutencao.Location = new System.Drawing.Point(98, 518);
            this.btnCadManutencao.Name = "btnCadManutencao";
            this.btnCadManutencao.Size = new System.Drawing.Size(162, 39);
            this.btnCadManutencao.TabIndex = 8;
            this.btnCadManutencao.Text = "Cadastrar Manutenção";
            this.btnCadManutencao.UseVisualStyleBackColor = false;
            this.btnCadManutencao.Click += new System.EventHandler(this.btnCadManutencao_Click);
            // 
            // imgFleets
            // 
            this.imgFleets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgFleets.BackgroundImage = global::Fleets.Properties.Resources._1;
            this.imgFleets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFleets.Location = new System.Drawing.Point(315, 20);
            this.imgFleets.Name = "imgFleets";
            this.imgFleets.Size = new System.Drawing.Size(259, 160);
            this.imgFleets.TabIndex = 11;
            this.imgFleets.TabStop = false;
            // 
            // cadastroManutencao1
            // 
            this.cadastroManutencao1.BackColor = System.Drawing.Color.DimGray;
            this.cadastroManutencao1.Location = new System.Drawing.Point(-660, -64);
            this.cadastroManutencao1.Name = "cadastroManutencao1";
            this.cadastroManutencao1.Size = new System.Drawing.Size(748, 637);
            this.cadastroManutencao1.TabIndex = 15;
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
            this.btnAlterar.Location = new System.Drawing.Point(520, 458);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(266, 33);
            this.btnAlterar.TabIndex = 39;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            this.btnExcluir.Location = new System.Drawing.Point(520, 330);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(266, 33);
            this.btnExcluir.TabIndex = 38;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblCodManutencaoAlterar
            // 
            this.lblCodManutencaoAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodManutencaoAlterar.AutoSize = true;
            this.lblCodManutencaoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodManutencaoAlterar.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodManutencaoAlterar.Location = new System.Drawing.Point(515, 403);
            this.lblCodManutencaoAlterar.Name = "lblCodManutencaoAlterar";
            this.lblCodManutencaoAlterar.Size = new System.Drawing.Size(178, 20);
            this.lblCodManutencaoAlterar.TabIndex = 37;
            this.lblCodManutencaoAlterar.Text = "Código da Manutenção:";
            // 
            // txtCodManutencaoAlterar
            // 
            this.txtCodManutencaoAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodManutencaoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodManutencaoAlterar.Location = new System.Drawing.Point(520, 426);
            this.txtCodManutencaoAlterar.Name = "txtCodManutencaoAlterar";
            this.txtCodManutencaoAlterar.Size = new System.Drawing.Size(266, 26);
            this.txtCodManutencaoAlterar.TabIndex = 36;
            // 
            // lblAlterar
            // 
            this.lblAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAlterar.AutoSize = true;
            this.lblAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterar.ForeColor = System.Drawing.Color.Yellow;
            this.lblAlterar.Location = new System.Drawing.Point(516, 378);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(63, 20);
            this.lblAlterar.TabIndex = 35;
            this.lblAlterar.Text = "Alterar";
            // 
            // lblCodManutencaoExcluir
            // 
            this.lblCodManutencaoExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodManutencaoExcluir.AutoSize = true;
            this.lblCodManutencaoExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodManutencaoExcluir.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodManutencaoExcluir.Location = new System.Drawing.Point(515, 275);
            this.lblCodManutencaoExcluir.Name = "lblCodManutencaoExcluir";
            this.lblCodManutencaoExcluir.Size = new System.Drawing.Size(178, 20);
            this.lblCodManutencaoExcluir.TabIndex = 34;
            this.lblCodManutencaoExcluir.Text = "Código da Manutenção:";
            // 
            // txtCodManutencaoExcluir
            // 
            this.txtCodManutencaoExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodManutencaoExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodManutencaoExcluir.Location = new System.Drawing.Point(520, 298);
            this.txtCodManutencaoExcluir.Name = "txtCodManutencaoExcluir";
            this.txtCodManutencaoExcluir.Size = new System.Drawing.Size(266, 26);
            this.txtCodManutencaoExcluir.TabIndex = 33;
            // 
            // lblExcluir
            // 
            this.lblExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.Color.Yellow;
            this.lblExcluir.Location = new System.Drawing.Point(516, 247);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(62, 20);
            this.lblExcluir.TabIndex = 32;
            this.lblExcluir.Text = "Excluir";
            // 
            // Manutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.cadastroManutencao1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblCodManutencaoAlterar);
            this.Controls.Add(this.txtCodManutencaoAlterar);
            this.Controls.Add(this.lblAlterar);
            this.Controls.Add(this.lblCodManutencaoExcluir);
            this.Controls.Add(this.txtCodManutencaoExcluir);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.listManutencao);
            this.Controls.Add(this.lblCodManutencao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.imgFleets);
            this.Controls.Add(this.btnBuscarManutencao);
            this.Controls.Add(this.txtBuscaManutencao);
            this.Controls.Add(this.btnCadManutencao);
            this.Name = "Manutencao";
            this.Size = new System.Drawing.Size(880, 576);
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listManutencao;
        private System.Windows.Forms.Label lblCodManutencao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox imgFleets;
        private System.Windows.Forms.Button btnBuscarManutencao;
        private System.Windows.Forms.TextBox txtBuscaManutencao;
        private System.Windows.Forms.Button btnCadManutencao;
        private Cadastros.CadastroManutencao cadastroManutencao1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCodManutencaoAlterar;
        private System.Windows.Forms.TextBox txtCodManutencaoAlterar;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.Label lblCodManutencaoExcluir;
        private System.Windows.Forms.TextBox txtCodManutencaoExcluir;
        private System.Windows.Forms.Label lblExcluir;
    }
}
