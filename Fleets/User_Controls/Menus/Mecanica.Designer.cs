namespace Fleets.Controls.Menus
{
    partial class Mecanica
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
            this.btnBuscarMecanica = new System.Windows.Forms.Button();
            this.txtBuscaMacanica = new System.Windows.Forms.TextBox();
            this.btnCadMecanica = new System.Windows.Forms.Button();
            this.imgFleets = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCodMecanicaAlterar = new System.Windows.Forms.Label();
            this.txtCodMecanicaAlterar = new System.Windows.Forms.TextBox();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.lblCodMecanicaExluir = new System.Windows.Forms.Label();
            this.txtCodManutencaoExcluir = new System.Windows.Forms.TextBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.listMecanicas = new System.Windows.Forms.ListView();
            this.cadastroMecanica1 = new Fleets.Controls.Cadastros.CadastroMecanica();
            this.lblAtualizar = new System.Windows.Forms.Label();
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
            this.lblNomeCidade.Size = new System.Drawing.Size(197, 24);
            this.lblNomeCidade.TabIndex = 13;
            this.lblNomeCidade.Text = "Nome da Mecânica:";
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
            // btnBuscarMecanica
            // 
            this.btnBuscarMecanica.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscarMecanica.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscarMecanica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMecanica.FlatAppearance.BorderSize = 0;
            this.btnBuscarMecanica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarMecanica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMecanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMecanica.ForeColor = System.Drawing.Color.DimGray;
            this.btnBuscarMecanica.Location = new System.Drawing.Point(663, 200);
            this.btnBuscarMecanica.Name = "btnBuscarMecanica";
            this.btnBuscarMecanica.Size = new System.Drawing.Size(123, 36);
            this.btnBuscarMecanica.TabIndex = 10;
            this.btnBuscarMecanica.Text = "Buscar Mecânica";
            this.btnBuscarMecanica.UseVisualStyleBackColor = false;
            // 
            // txtBuscaMacanica
            // 
            this.txtBuscaMacanica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaMacanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtBuscaMacanica.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscaMacanica.Location = new System.Drawing.Point(297, 200);
            this.txtBuscaMacanica.Name = "txtBuscaMacanica";
            this.txtBuscaMacanica.Size = new System.Drawing.Size(360, 35);
            this.txtBuscaMacanica.TabIndex = 9;
            // 
            // btnCadMecanica
            // 
            this.btnCadMecanica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadMecanica.BackColor = System.Drawing.Color.Yellow;
            this.btnCadMecanica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadMecanica.FlatAppearance.BorderSize = 0;
            this.btnCadMecanica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadMecanica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadMecanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCadMecanica.ForeColor = System.Drawing.Color.DimGray;
            this.btnCadMecanica.Location = new System.Drawing.Point(98, 518);
            this.btnCadMecanica.Name = "btnCadMecanica";
            this.btnCadMecanica.Size = new System.Drawing.Size(162, 39);
            this.btnCadMecanica.TabIndex = 8;
            this.btnCadMecanica.Text = "Cadastrar Mecânica";
            this.btnCadMecanica.UseVisualStyleBackColor = false;
            this.btnCadMecanica.Click += new System.EventHandler(this.btnCadMecanica_Click);
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
            // lblCodMecanicaAlterar
            // 
            this.lblCodMecanicaAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodMecanicaAlterar.AutoSize = true;
            this.lblCodMecanicaAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodMecanicaAlterar.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodMecanicaAlterar.Location = new System.Drawing.Point(515, 403);
            this.lblCodMecanicaAlterar.Name = "lblCodMecanicaAlterar";
            this.lblCodMecanicaAlterar.Size = new System.Drawing.Size(157, 20);
            this.lblCodMecanicaAlterar.TabIndex = 45;
            this.lblCodMecanicaAlterar.Text = "Código da Mecânica:";
            // 
            // txtCodMecanicaAlterar
            // 
            this.txtCodMecanicaAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodMecanicaAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodMecanicaAlterar.Location = new System.Drawing.Point(520, 426);
            this.txtCodMecanicaAlterar.Name = "txtCodMecanicaAlterar";
            this.txtCodMecanicaAlterar.Size = new System.Drawing.Size(266, 26);
            this.txtCodMecanicaAlterar.TabIndex = 44;
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
            // lblCodMecanicaExluir
            // 
            this.lblCodMecanicaExluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodMecanicaExluir.AutoSize = true;
            this.lblCodMecanicaExluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodMecanicaExluir.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodMecanicaExluir.Location = new System.Drawing.Point(515, 275);
            this.lblCodMecanicaExluir.Name = "lblCodMecanicaExluir";
            this.lblCodMecanicaExluir.Size = new System.Drawing.Size(157, 20);
            this.lblCodMecanicaExluir.TabIndex = 42;
            this.lblCodMecanicaExluir.Text = "Código da Mecânica:";
            // 
            // txtCodManutencaoExcluir
            // 
            this.txtCodManutencaoExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodManutencaoExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodManutencaoExcluir.Location = new System.Drawing.Point(520, 298);
            this.txtCodManutencaoExcluir.Name = "txtCodManutencaoExcluir";
            this.txtCodManutencaoExcluir.Size = new System.Drawing.Size(266, 26);
            this.txtCodManutencaoExcluir.TabIndex = 41;
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
            // listMecanicas
            // 
            this.listMecanicas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMecanicas.HideSelection = false;
            this.listMecanicas.Location = new System.Drawing.Point(98, 247);
            this.listMecanicas.Name = "listMecanicas";
            this.listMecanicas.Size = new System.Drawing.Size(416, 244);
            this.listMecanicas.TabIndex = 48;
            this.listMecanicas.UseCompatibleStateImageBehavior = false;
            // 
            // cadastroMecanica1
            // 
            this.cadastroMecanica1.BackColor = System.Drawing.Color.DimGray;
            this.cadastroMecanica1.Location = new System.Drawing.Point(-656, -122);
            this.cadastroMecanica1.Name = "cadastroMecanica1";
            this.cadastroMecanica1.Size = new System.Drawing.Size(748, 637);
            this.cadastroMecanica1.TabIndex = 15;
            // 
            // lblAtualizar
            // 
            this.lblAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAtualizar.AutoSize = true;
            this.lblAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAtualizar.ForeColor = System.Drawing.Color.Yellow;
            this.lblAtualizar.Location = new System.Drawing.Point(98, 494);
            this.lblAtualizar.Name = "lblAtualizar";
            this.lblAtualizar.Size = new System.Drawing.Size(54, 15);
            this.lblAtualizar.TabIndex = 53;
            this.lblAtualizar.Text = "Atualizar";
            this.lblAtualizar.Click += new System.EventHandler(this.lblAtualizar_Click);
            // 
            // Mecanica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.cadastroMecanica1);
            this.Controls.Add(this.lblAtualizar);
            this.Controls.Add(this.listMecanicas);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblCodMecanicaAlterar);
            this.Controls.Add(this.txtCodMecanicaAlterar);
            this.Controls.Add(this.lblAlterar);
            this.Controls.Add(this.lblCodMecanicaExluir);
            this.Controls.Add(this.txtCodManutencaoExcluir);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.lblNomeCidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.imgFleets);
            this.Controls.Add(this.btnBuscarMecanica);
            this.Controls.Add(this.txtBuscaMacanica);
            this.Controls.Add(this.btnCadMecanica);
            this.Name = "Mecanica";
            this.Size = new System.Drawing.Size(880, 576);
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeCidade;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox imgFleets;
        private System.Windows.Forms.Button btnBuscarMecanica;
        private System.Windows.Forms.TextBox txtBuscaMacanica;
        private System.Windows.Forms.Button btnCadMecanica;
        private Cadastros.CadastroMecanica cadastroMecanica1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCodMecanicaAlterar;
        private System.Windows.Forms.TextBox txtCodMecanicaAlterar;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.Label lblCodMecanicaExluir;
        private System.Windows.Forms.TextBox txtCodManutencaoExcluir;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.ListView listMecanicas;
        private System.Windows.Forms.Label lblAtualizar;
    }
}
