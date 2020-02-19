namespace Fleets.Controls.Menus
{
    partial class Frotas
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
            this.btnBuscarFrota = new System.Windows.Forms.Button();
            this.txtBuscaFrota = new System.Windows.Forms.TextBox();
            this.btnCadFrota = new System.Windows.Forms.Button();
            this.imgFleets = new System.Windows.Forms.PictureBox();
            this.cadastroFrotas1 = new Fleets.Controls.Cadastros.CadastroFrotas();
            this.txtCodFrota = new System.Windows.Forms.TextBox();
            this.lblCodEmpresa = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.listFrotas = new System.Windows.Forms.ListView();
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
            this.lblNomeCidade.Size = new System.Drawing.Size(137, 24);
            this.lblNomeCidade.TabIndex = 13;
            this.lblNomeCidade.Text = "Código Frota:";
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
            this.btnVoltar.Location = new System.Drawing.Point(526, 482);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(262, 33);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnBuscarFrota
            // 
            this.btnBuscarFrota.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscarFrota.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscarFrota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarFrota.FlatAppearance.BorderSize = 0;
            this.btnBuscarFrota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarFrota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFrota.ForeColor = System.Drawing.Color.DimGray;
            this.btnBuscarFrota.Location = new System.Drawing.Point(663, 200);
            this.btnBuscarFrota.Name = "btnBuscarFrota";
            this.btnBuscarFrota.Size = new System.Drawing.Size(123, 36);
            this.btnBuscarFrota.TabIndex = 10;
            this.btnBuscarFrota.Text = "Buscar Frota";
            this.btnBuscarFrota.UseVisualStyleBackColor = false;
            // 
            // txtBuscaFrota
            // 
            this.txtBuscaFrota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtBuscaFrota.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscaFrota.Location = new System.Drawing.Point(237, 200);
            this.txtBuscaFrota.Name = "txtBuscaFrota";
            this.txtBuscaFrota.Size = new System.Drawing.Size(420, 35);
            this.txtBuscaFrota.TabIndex = 9;
            // 
            // btnCadFrota
            // 
            this.btnCadFrota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCadFrota.BackColor = System.Drawing.Color.Yellow;
            this.btnCadFrota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadFrota.FlatAppearance.BorderSize = 0;
            this.btnCadFrota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadFrota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCadFrota.ForeColor = System.Drawing.Color.DimGray;
            this.btnCadFrota.Location = new System.Drawing.Point(526, 423);
            this.btnCadFrota.Name = "btnCadFrota";
            this.btnCadFrota.Size = new System.Drawing.Size(262, 39);
            this.btnCadFrota.TabIndex = 8;
            this.btnCadFrota.Text = "Cadastrar Frota";
            this.btnCadFrota.UseVisualStyleBackColor = false;
            this.btnCadFrota.Click += new System.EventHandler(this.btnCadFrota_Click);
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
            // cadastroFrotas1
            // 
            this.cadastroFrotas1.BackColor = System.Drawing.Color.DimGray;
            this.cadastroFrotas1.Location = new System.Drawing.Point(-660, -32);
            this.cadastroFrotas1.Name = "cadastroFrotas1";
            this.cadastroFrotas1.Size = new System.Drawing.Size(748, 637);
            this.cadastroFrotas1.TabIndex = 15;
            // 
            // txtCodFrota
            // 
            this.txtCodFrota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodFrota.Location = new System.Drawing.Point(653, 247);
            this.txtCodFrota.MaxLength = 10;
            this.txtCodFrota.Name = "txtCodFrota";
            this.txtCodFrota.Size = new System.Drawing.Size(135, 26);
            this.txtCodFrota.TabIndex = 61;
            // 
            // lblCodEmpresa
            // 
            this.lblCodEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodEmpresa.AutoSize = true;
            this.lblCodEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblCodEmpresa.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEmpresa.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodEmpresa.Location = new System.Drawing.Point(521, 248);
            this.lblCodEmpresa.Name = "lblCodEmpresa";
            this.lblCodEmpresa.Size = new System.Drawing.Size(130, 25);
            this.lblCodEmpresa.TabIndex = 60;
            this.lblCodEmpresa.Text = "Código da Empresa:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.Yellow;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.DimGray;
            this.btnExcluir.Location = new System.Drawing.Point(526, 294);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(262, 33);
            this.btnExcluir.TabIndex = 59;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // listFrotas
            // 
            this.listFrotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFrotas.HideSelection = false;
            this.listFrotas.Location = new System.Drawing.Point(98, 248);
            this.listFrotas.Name = "listFrotas";
            this.listFrotas.Size = new System.Drawing.Size(417, 267);
            this.listFrotas.TabIndex = 62;
            this.listFrotas.UseCompatibleStateImageBehavior = false;
            // 
            // Frotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.listFrotas);
            this.Controls.Add(this.txtCodFrota);
            this.Controls.Add(this.lblCodEmpresa);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cadastroFrotas1);
            this.Controls.Add(this.lblNomeCidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.imgFleets);
            this.Controls.Add(this.btnBuscarFrota);
            this.Controls.Add(this.txtBuscaFrota);
            this.Controls.Add(this.btnCadFrota);
            this.Name = "Frotas";
            this.Size = new System.Drawing.Size(880, 576);
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeCidade;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox imgFleets;
        private System.Windows.Forms.Button btnBuscarFrota;
        private System.Windows.Forms.TextBox txtBuscaFrota;
        private System.Windows.Forms.Button btnCadFrota;
        private Cadastros.CadastroFrotas cadastroFrotas1;
        private System.Windows.Forms.TextBox txtCodFrota;
        private System.Windows.Forms.Label lblCodEmpresa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ListView listFrotas;
    }
}
