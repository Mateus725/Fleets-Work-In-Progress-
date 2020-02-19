namespace Fleets.Controls.Menus
{
    partial class Relatorio
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
            this.listRelatorios = new System.Windows.Forms.ListBox();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscarRelatorio = new System.Windows.Forms.Button();
            this.txtBuscaRelatorio = new System.Windows.Forms.TextBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.imgFleets = new System.Windows.Forms.PictureBox();
            this.gerarRelatorios1 = new Fleets.Controls.Menus.GerarRelatorios();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCodRelatorioExcluir = new System.Windows.Forms.Label();
            this.txtCodRelatorioExcluir = new System.Windows.Forms.TextBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).BeginInit();
            this.SuspendLayout();
            // 
            // listRelatorios
            // 
            this.listRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRelatorios.FormattingEnabled = true;
            this.listRelatorios.ItemHeight = 24;
            this.listRelatorios.Location = new System.Drawing.Point(98, 247);
            this.listRelatorios.Name = "listRelatorios";
            this.listRelatorios.Size = new System.Drawing.Size(412, 244);
            this.listRelatorios.TabIndex = 14;
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblRelatorio.ForeColor = System.Drawing.Color.Yellow;
            this.lblRelatorio.Location = new System.Drawing.Point(94, 206);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(99, 24);
            this.lblRelatorio.TabIndex = 13;
            this.lblRelatorio.Text = "Relatório:";
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
            // btnBuscarRelatorio
            // 
            this.btnBuscarRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscarRelatorio.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarRelatorio.FlatAppearance.BorderSize = 0;
            this.btnBuscarRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRelatorio.ForeColor = System.Drawing.Color.DimGray;
            this.btnBuscarRelatorio.Location = new System.Drawing.Point(663, 200);
            this.btnBuscarRelatorio.Name = "btnBuscarRelatorio";
            this.btnBuscarRelatorio.Size = new System.Drawing.Size(123, 36);
            this.btnBuscarRelatorio.TabIndex = 10;
            this.btnBuscarRelatorio.Text = "Buscar Relatório";
            this.btnBuscarRelatorio.UseVisualStyleBackColor = false;
            // 
            // txtBuscaRelatorio
            // 
            this.txtBuscaRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtBuscaRelatorio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscaRelatorio.Location = new System.Drawing.Point(199, 200);
            this.txtBuscaRelatorio.Name = "txtBuscaRelatorio";
            this.txtBuscaRelatorio.Size = new System.Drawing.Size(458, 35);
            this.txtBuscaRelatorio.TabIndex = 9;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.Yellow;
            this.btnGerarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarRelatorio.FlatAppearance.BorderSize = 0;
            this.btnGerarRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.DimGray;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(98, 518);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(162, 39);
            this.btnGerarRelatorio.TabIndex = 8;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
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
            // gerarRelatorios1
            // 
            this.gerarRelatorios1.BackColor = System.Drawing.Color.DimGray;
            this.gerarRelatorios1.Location = new System.Drawing.Point(-1290, -27);
            this.gerarRelatorios1.Name = "gerarRelatorios1";
            this.gerarRelatorios1.Size = new System.Drawing.Size(1382, 788);
            this.gerarRelatorios1.TabIndex = 15;
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
            this.btnExcluir.Location = new System.Drawing.Point(520, 329);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(266, 33);
            this.btnExcluir.TabIndex = 46;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblCodRelatorioExcluir
            // 
            this.lblCodRelatorioExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodRelatorioExcluir.AutoSize = true;
            this.lblCodRelatorioExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodRelatorioExcluir.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodRelatorioExcluir.Location = new System.Drawing.Point(515, 274);
            this.lblCodRelatorioExcluir.Name = "lblCodRelatorioExcluir";
            this.lblCodRelatorioExcluir.Size = new System.Drawing.Size(153, 20);
            this.lblCodRelatorioExcluir.TabIndex = 42;
            this.lblCodRelatorioExcluir.Text = "Código do Relatório:";
            // 
            // txtCodRelatorioExcluir
            // 
            this.txtCodRelatorioExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodRelatorioExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodRelatorioExcluir.Location = new System.Drawing.Point(520, 297);
            this.txtCodRelatorioExcluir.Name = "txtCodRelatorioExcluir";
            this.txtCodRelatorioExcluir.Size = new System.Drawing.Size(266, 26);
            this.txtCodRelatorioExcluir.TabIndex = 41;
            // 
            // lblExcluir
            // 
            this.lblExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.Color.Yellow;
            this.lblExcluir.Location = new System.Drawing.Point(516, 246);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(62, 20);
            this.lblExcluir.TabIndex = 40;
            this.lblExcluir.Text = "Excluir";
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.gerarRelatorios1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblCodRelatorioExcluir);
            this.Controls.Add(this.txtCodRelatorioExcluir);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.listRelatorios);
            this.Controls.Add(this.lblRelatorio);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.imgFleets);
            this.Controls.Add(this.btnBuscarRelatorio);
            this.Controls.Add(this.txtBuscaRelatorio);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Name = "Relatorio";
            this.Size = new System.Drawing.Size(880, 576);
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRelatorios;
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox imgFleets;
        private System.Windows.Forms.Button btnBuscarRelatorio;
        private System.Windows.Forms.TextBox txtBuscaRelatorio;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private GerarRelatorios gerarRelatorios1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCodRelatorioExcluir;
        private System.Windows.Forms.TextBox txtCodRelatorioExcluir;
        private System.Windows.Forms.Label lblExcluir;
    }
}
