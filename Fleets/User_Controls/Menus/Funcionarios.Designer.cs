namespace Fleets.Controls.Menus
{
    partial class Funcionarios
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
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.imgFleets = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtCodFuncAlterar = new System.Windows.Forms.TextBox();
            this.lblCodFuncionario = new System.Windows.Forms.Label();
            this.txtCodFuncExcluir = new System.Windows.Forms.TextBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.listFuncionario = new System.Windows.Forms.ListView();
            this.lblAtualizar = new System.Windows.Forms.Label();
            this.cadastroFuncionario1 = new Fleets.Controls.Cadastros.CadastroFuncionario();
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
            this.lblNomeCidade.Size = new System.Drawing.Size(231, 24);
            this.lblNomeCidade.TabIndex = 13;
            this.lblNomeCidade.Text = "Código do Funcionário:";
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
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadFuncionario.BackColor = System.Drawing.Color.Yellow;
            this.btnCadFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCadFuncionario.ForeColor = System.Drawing.Color.DimGray;
            this.btnCadFuncionario.Location = new System.Drawing.Point(98, 518);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(151, 33);
            this.btnCadFuncionario.TabIndex = 8;
            this.btnCadFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadFuncionario.UseVisualStyleBackColor = false;
            this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
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
            this.btnAlterar.Location = new System.Drawing.Point(592, 202);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(194, 33);
            this.btnAlterar.TabIndex = 39;
            this.btnAlterar.Text = "Buscar";
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
            // txtCodFuncAlterar
            // 
            this.txtCodFuncAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodFuncAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCodFuncAlterar.Location = new System.Drawing.Point(331, 204);
            this.txtCodFuncAlterar.Name = "txtCodFuncAlterar";
            this.txtCodFuncAlterar.Size = new System.Drawing.Size(255, 29);
            this.txtCodFuncAlterar.TabIndex = 36;
            // 
            // lblCodFuncionario
            // 
            this.lblCodFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodFuncionario.AutoSize = true;
            this.lblCodFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFuncionario.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodFuncionario.Location = new System.Drawing.Point(515, 275);
            this.lblCodFuncionario.Name = "lblCodFuncionario";
            this.lblCodFuncionario.Size = new System.Drawing.Size(172, 20);
            this.lblCodFuncionario.TabIndex = 34;
            this.lblCodFuncionario.Text = "Código do Funcionário:";
            // 
            // txtCodFuncExcluir
            // 
            this.txtCodFuncExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodFuncExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFuncExcluir.Location = new System.Drawing.Point(520, 298);
            this.txtCodFuncExcluir.MaxLength = 11;
            this.txtCodFuncExcluir.Name = "txtCodFuncExcluir";
            this.txtCodFuncExcluir.Size = new System.Drawing.Size(266, 26);
            this.txtCodFuncExcluir.TabIndex = 33;
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
            // listFuncionario
            // 
            this.listFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFuncionario.HideSelection = false;
            this.listFuncionario.Location = new System.Drawing.Point(98, 247);
            this.listFuncionario.Name = "listFuncionario";
            this.listFuncionario.Size = new System.Drawing.Size(411, 244);
            this.listFuncionario.TabIndex = 40;
            this.listFuncionario.UseCompatibleStateImageBehavior = false;
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
            this.lblAtualizar.TabIndex = 41;
            this.lblAtualizar.Text = "Atualizar";
            this.lblAtualizar.Click += new System.EventHandler(this.lblAtualizar_Click);
            // 
            // cadastroFuncionario1
            // 
            this.cadastroFuncionario1.BackColor = System.Drawing.Color.DimGray;
            this.cadastroFuncionario1.Location = new System.Drawing.Point(-656, 69);
            this.cadastroFuncionario1.Name = "cadastroFuncionario1";
            this.cadastroFuncionario1.Size = new System.Drawing.Size(748, 637);
            this.cadastroFuncionario1.TabIndex = 15;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.cadastroFuncionario1);
            this.Controls.Add(this.lblAtualizar);
            this.Controls.Add(this.listFuncionario);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtCodFuncAlterar);
            this.Controls.Add(this.lblCodFuncionario);
            this.Controls.Add(this.txtCodFuncExcluir);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.lblNomeCidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.imgFleets);
            this.Controls.Add(this.btnCadFuncionario);
            this.Name = "Funcionarios";
            this.Size = new System.Drawing.Size(880, 576);
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeCidade;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox imgFleets;
        private System.Windows.Forms.Button btnCadFuncionario;
        private Cadastros.CadastroFuncionario cadastroFuncionario1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtCodFuncAlterar;
        private System.Windows.Forms.Label lblCodFuncionario;
        private System.Windows.Forms.TextBox txtCodFuncExcluir;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.ListView listFuncionario;
        private System.Windows.Forms.Label lblAtualizar;
    }
}
