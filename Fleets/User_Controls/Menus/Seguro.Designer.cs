namespace Fleets.Controls.Menus
{
    partial class Seguro
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
            this.lblNomeCidade = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscarSeguro = new System.Windows.Forms.Button();
            this.txtBuscaSeguro = new System.Windows.Forms.TextBox();
            this.btnCadSeguro = new System.Windows.Forms.Button();
            this.imgFleets = new System.Windows.Forms.PictureBox();
            this.cadastroSeguro1 = new Fleets.Controls.Menus.CadastroSeguro();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCodSeguroAlterar = new System.Windows.Forms.Label();
            this.txtCodSeguroAlterar = new System.Windows.Forms.TextBox();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.lblCodSeguroExcluir = new System.Windows.Forms.Label();
            this.txtCodSeguroExcluir = new System.Windows.Forms.TextBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.listSeguros = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCidade
            // 
            this.lblNomeCidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNomeCidade.AutoSize = true;
            this.lblNomeCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNomeCidade.ForeColor = System.Drawing.Color.Yellow;
            this.lblNomeCidade.Location = new System.Drawing.Point(94, 206);
            this.lblNomeCidade.Name = "lblNomeCidade";
            this.lblNomeCidade.Size = new System.Drawing.Size(85, 24);
            this.lblNomeCidade.TabIndex = 13;
            this.lblNomeCidade.Text = "Sinistro:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            // btnBuscarSeguro
            // 
            this.btnBuscarSeguro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscarSeguro.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscarSeguro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarSeguro.FlatAppearance.BorderSize = 0;
            this.btnBuscarSeguro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarSeguro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSeguro.ForeColor = System.Drawing.Color.DimGray;
            this.btnBuscarSeguro.Location = new System.Drawing.Point(663, 200);
            this.btnBuscarSeguro.Name = "btnBuscarSeguro";
            this.btnBuscarSeguro.Size = new System.Drawing.Size(123, 36);
            this.btnBuscarSeguro.TabIndex = 10;
            this.btnBuscarSeguro.Text = "Buscar Seguro";
            this.btnBuscarSeguro.UseVisualStyleBackColor = false;
            // 
            // txtBuscaSeguro
            // 
            this.txtBuscaSeguro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtBuscaSeguro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscaSeguro.Location = new System.Drawing.Point(185, 200);
            this.txtBuscaSeguro.Name = "txtBuscaSeguro";
            this.txtBuscaSeguro.Size = new System.Drawing.Size(472, 35);
            this.txtBuscaSeguro.TabIndex = 9;
            // 
            // btnCadSeguro
            // 
            this.btnCadSeguro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadSeguro.BackColor = System.Drawing.Color.Yellow;
            this.btnCadSeguro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadSeguro.FlatAppearance.BorderSize = 0;
            this.btnCadSeguro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadSeguro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCadSeguro.ForeColor = System.Drawing.Color.DimGray;
            this.btnCadSeguro.Location = new System.Drawing.Point(98, 518);
            this.btnCadSeguro.Name = "btnCadSeguro";
            this.btnCadSeguro.Size = new System.Drawing.Size(162, 39);
            this.btnCadSeguro.TabIndex = 8;
            this.btnCadSeguro.Text = "Cadastrar Seguro";
            this.btnCadSeguro.UseVisualStyleBackColor = false;
            this.btnCadSeguro.Click += new System.EventHandler(this.btnCadSeguro_Click);
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
            // cadastroSeguro1
            // 
            this.cadastroSeguro1.BackColor = System.Drawing.Color.DimGray;
            this.cadastroSeguro1.Location = new System.Drawing.Point(-769, -61);
            this.cadastroSeguro1.Name = "cadastroSeguro1";
            this.cadastroSeguro1.Size = new System.Drawing.Size(880, 576);
            this.cadastroSeguro1.TabIndex = 15;
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
            this.btnExcluir.Location = new System.Drawing.Point(520, 330);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(266, 33);
            this.btnExcluir.TabIndex = 46;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblCodSeguroAlterar
            // 
            this.lblCodSeguroAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodSeguroAlterar.AutoSize = true;
            this.lblCodSeguroAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodSeguroAlterar.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodSeguroAlterar.Location = new System.Drawing.Point(515, 403);
            this.lblCodSeguroAlterar.Name = "lblCodSeguroAlterar";
            this.lblCodSeguroAlterar.Size = new System.Drawing.Size(141, 20);
            this.lblCodSeguroAlterar.TabIndex = 45;
            this.lblCodSeguroAlterar.Text = "Código do Seguro:";
            // 
            // txtCodSeguroAlterar
            // 
            this.txtCodSeguroAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodSeguroAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSeguroAlterar.Location = new System.Drawing.Point(520, 426);
            this.txtCodSeguroAlterar.Name = "txtCodSeguroAlterar";
            this.txtCodSeguroAlterar.Size = new System.Drawing.Size(266, 26);
            this.txtCodSeguroAlterar.TabIndex = 44;
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
            this.lblAlterar.TabIndex = 43;
            this.lblAlterar.Text = "Alterar";
            // 
            // lblCodSeguroExcluir
            // 
            this.lblCodSeguroExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodSeguroExcluir.AutoSize = true;
            this.lblCodSeguroExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodSeguroExcluir.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodSeguroExcluir.Location = new System.Drawing.Point(515, 275);
            this.lblCodSeguroExcluir.Name = "lblCodSeguroExcluir";
            this.lblCodSeguroExcluir.Size = new System.Drawing.Size(141, 20);
            this.lblCodSeguroExcluir.TabIndex = 42;
            this.lblCodSeguroExcluir.Text = "Código do Seguro:";
            // 
            // txtCodSeguroExcluir
            // 
            this.txtCodSeguroExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodSeguroExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSeguroExcluir.Location = new System.Drawing.Point(520, 298);
            this.txtCodSeguroExcluir.Name = "txtCodSeguroExcluir";
            this.txtCodSeguroExcluir.Size = new System.Drawing.Size(266, 26);
            this.txtCodSeguroExcluir.TabIndex = 41;
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
            this.lblExcluir.TabIndex = 40;
            this.lblExcluir.Text = "Excluir";
            // 
            // listSeguros
            // 
            this.listSeguros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSeguros.HideSelection = false;
            this.listSeguros.Location = new System.Drawing.Point(98, 247);
            this.listSeguros.Name = "listSeguros";
            this.listSeguros.Size = new System.Drawing.Size(416, 244);
            this.listSeguros.TabIndex = 48;
            this.listSeguros.UseCompatibleStateImageBehavior = false;
            // 
            // Seguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.cadastroSeguro1);
            this.Controls.Add(this.listSeguros);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblCodSeguroAlterar);
            this.Controls.Add(this.txtCodSeguroAlterar);
            this.Controls.Add(this.lblAlterar);
            this.Controls.Add(this.lblCodSeguroExcluir);
            this.Controls.Add(this.txtCodSeguroExcluir);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.lblNomeCidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.imgFleets);
            this.Controls.Add(this.btnBuscarSeguro);
            this.Controls.Add(this.txtBuscaSeguro);
            this.Controls.Add(this.btnCadSeguro);
            this.Name = "Seguro";
            this.Size = new System.Drawing.Size(880, 576);
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeCidade;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox imgFleets;
        private System.Windows.Forms.Button btnBuscarSeguro;
        private System.Windows.Forms.TextBox txtBuscaSeguro;
        private System.Windows.Forms.Button btnCadSeguro;
        private CadastroSeguro cadastroSeguro1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCodSeguroAlterar;
        private System.Windows.Forms.TextBox txtCodSeguroAlterar;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.Label lblCodSeguroExcluir;
        private System.Windows.Forms.TextBox txtCodSeguroExcluir;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.ListView listSeguros;
    }
}
