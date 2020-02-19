namespace Fleets.Controls.Menus
{
    partial class Veiculos
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
            this.components = new System.ComponentModel.Container();
            this.vEICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fleetsDataSet = new Fleets.fleetsDataSet();
            this.lblNomeCidade = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscarVeículo = new System.Windows.Forms.Button();
            this.txtBuscaVeiculo = new System.Windows.Forms.TextBox();
            this.btnCadVeiculo = new System.Windows.Forms.Button();
            this.imgFleets = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCodVeiculoAlterar = new System.Windows.Forms.Label();
            this.txtCodVeiculoAlterar = new System.Windows.Forms.TextBox();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.lblCodVeiculoExcluir = new System.Windows.Forms.Label();
            this.txtCodVeiculoExcluir = new System.Windows.Forms.TextBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.vEICULOTableAdapter = new Fleets.fleetsDataSetTableAdapters.VEICULOTableAdapter();
            this.lvVeiculos = new System.Windows.Forms.ListView();
            this.lblAtualizar = new System.Windows.Forms.Label();
            this.cadastroVeiculos1 = new Fleets.Controls.Cadastros.CadastroVeiculos();
            ((System.ComponentModel.ISupportInitialize)(this.vEICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).BeginInit();
            this.SuspendLayout();
            // 
            // vEICULOBindingSource
            // 
            this.vEICULOBindingSource.DataMember = "VEICULO";
            this.vEICULOBindingSource.DataSource = this.fleetsDataSet;
            // 
            // fleetsDataSet
            // 
            this.fleetsDataSet.DataSetName = "fleetsDataSet";
            this.fleetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNomeCidade
            // 
            this.lblNomeCidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNomeCidade.AutoSize = true;
            this.lblNomeCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNomeCidade.ForeColor = System.Drawing.Color.Yellow;
            this.lblNomeCidade.Location = new System.Drawing.Point(94, 206);
            this.lblNomeCidade.Name = "lblNomeCidade";
            this.lblNomeCidade.Size = new System.Drawing.Size(87, 24);
            this.lblNomeCidade.TabIndex = 13;
            this.lblNomeCidade.Text = "Veículo:";
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
            // btnBuscarVeículo
            // 
            this.btnBuscarVeículo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscarVeículo.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscarVeículo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarVeículo.FlatAppearance.BorderSize = 0;
            this.btnBuscarVeículo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarVeículo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVeículo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVeículo.ForeColor = System.Drawing.Color.DimGray;
            this.btnBuscarVeículo.Location = new System.Drawing.Point(663, 200);
            this.btnBuscarVeículo.Name = "btnBuscarVeículo";
            this.btnBuscarVeículo.Size = new System.Drawing.Size(123, 36);
            this.btnBuscarVeículo.TabIndex = 10;
            this.btnBuscarVeículo.Text = "Buscar Veículo";
            this.btnBuscarVeículo.UseVisualStyleBackColor = false;
            // 
            // txtBuscaVeiculo
            // 
            this.txtBuscaVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtBuscaVeiculo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscaVeiculo.Location = new System.Drawing.Point(187, 200);
            this.txtBuscaVeiculo.Name = "txtBuscaVeiculo";
            this.txtBuscaVeiculo.Size = new System.Drawing.Size(470, 35);
            this.txtBuscaVeiculo.TabIndex = 9;
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadVeiculo.BackColor = System.Drawing.Color.Yellow;
            this.btnCadVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadVeiculo.FlatAppearance.BorderSize = 0;
            this.btnCadVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCadVeiculo.ForeColor = System.Drawing.Color.DimGray;
            this.btnCadVeiculo.Location = new System.Drawing.Point(98, 518);
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(162, 39);
            this.btnCadVeiculo.TabIndex = 8;
            this.btnCadVeiculo.Text = "Cadastrar Veículo";
            this.btnCadVeiculo.UseVisualStyleBackColor = false;
            this.btnCadVeiculo.Click += new System.EventHandler(this.BtnCadVeiculo_Click);
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
            // lblCodVeiculoAlterar
            // 
            this.lblCodVeiculoAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodVeiculoAlterar.AutoSize = true;
            this.lblCodVeiculoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodVeiculoAlterar.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodVeiculoAlterar.Location = new System.Drawing.Point(515, 403);
            this.lblCodVeiculoAlterar.Name = "lblCodVeiculoAlterar";
            this.lblCodVeiculoAlterar.Size = new System.Drawing.Size(141, 20);
            this.lblCodVeiculoAlterar.TabIndex = 45;
            this.lblCodVeiculoAlterar.Text = "Código do Veiculo:";
            // 
            // txtCodVeiculoAlterar
            // 
            this.txtCodVeiculoAlterar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodVeiculoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVeiculoAlterar.Location = new System.Drawing.Point(520, 426);
            this.txtCodVeiculoAlterar.Name = "txtCodVeiculoAlterar";
            this.txtCodVeiculoAlterar.Size = new System.Drawing.Size(266, 26);
            this.txtCodVeiculoAlterar.TabIndex = 44;
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
            // lblCodVeiculoExcluir
            // 
            this.lblCodVeiculoExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodVeiculoExcluir.AutoSize = true;
            this.lblCodVeiculoExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodVeiculoExcluir.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodVeiculoExcluir.Location = new System.Drawing.Point(515, 275);
            this.lblCodVeiculoExcluir.Name = "lblCodVeiculoExcluir";
            this.lblCodVeiculoExcluir.Size = new System.Drawing.Size(141, 20);
            this.lblCodVeiculoExcluir.TabIndex = 42;
            this.lblCodVeiculoExcluir.Text = "Código do Veículo:";
            // 
            // txtCodVeiculoExcluir
            // 
            this.txtCodVeiculoExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCodVeiculoExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVeiculoExcluir.Location = new System.Drawing.Point(520, 298);
            this.txtCodVeiculoExcluir.Name = "txtCodVeiculoExcluir";
            this.txtCodVeiculoExcluir.Size = new System.Drawing.Size(266, 26);
            this.txtCodVeiculoExcluir.TabIndex = 41;
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
            // vEICULOTableAdapter
            // 
            this.vEICULOTableAdapter.ClearBeforeFill = true;
            // 
            // lvVeiculos
            // 
            this.lvVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVeiculos.HideSelection = false;
            this.lvVeiculos.Location = new System.Drawing.Point(98, 247);
            this.lvVeiculos.Name = "lvVeiculos";
            this.lvVeiculos.Size = new System.Drawing.Size(411, 244);
            this.lvVeiculos.TabIndex = 50;
            this.lvVeiculos.UseCompatibleStateImageBehavior = false;
            // 
            // lblAtualizar
            // 
            this.lblAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAtualizar.AutoSize = true;
            this.lblAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAtualizar.ForeColor = System.Drawing.Color.Yellow;
            this.lblAtualizar.Location = new System.Drawing.Point(95, 494);
            this.lblAtualizar.Name = "lblAtualizar";
            this.lblAtualizar.Size = new System.Drawing.Size(54, 15);
            this.lblAtualizar.TabIndex = 51;
            this.lblAtualizar.Text = "Atualizar";
            this.lblAtualizar.Click += new System.EventHandler(this.lblAtualizar_Click);
            // 
            // cadastroVeiculos1
            // 
            this.cadastroVeiculos1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cadastroVeiculos1.BackColor = System.Drawing.Color.DimGray;
            this.cadastroVeiculos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastroVeiculos1.Location = new System.Drawing.Point(0, 0);
            this.cadastroVeiculos1.Name = "cadastroVeiculos1";
            this.cadastroVeiculos1.Size = new System.Drawing.Size(880, 576);
            this.cadastroVeiculos1.TabIndex = 48;
            this.cadastroVeiculos1.Load += new System.EventHandler(this.cadastroVeiculos1_Load_1);
            // 
            // Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.lblAtualizar);
            this.Controls.Add(this.lvVeiculos);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblCodVeiculoAlterar);
            this.Controls.Add(this.txtCodVeiculoAlterar);
            this.Controls.Add(this.lblAlterar);
            this.Controls.Add(this.lblCodVeiculoExcluir);
            this.Controls.Add(this.txtCodVeiculoExcluir);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.lblNomeCidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.imgFleets);
            this.Controls.Add(this.btnBuscarVeículo);
            this.Controls.Add(this.txtBuscaVeiculo);
            this.Controls.Add(this.btnCadVeiculo);
            this.Controls.Add(this.cadastroVeiculos1);
            this.Name = "Veiculos";
            this.Size = new System.Drawing.Size(880, 576);
            ((System.ComponentModel.ISupportInitialize)(this.vEICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeCidade;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox imgFleets;
        private System.Windows.Forms.Button btnBuscarVeículo;
        private System.Windows.Forms.TextBox txtBuscaVeiculo;
        private System.Windows.Forms.Button btnCadVeiculo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCodVeiculoAlterar;
        private System.Windows.Forms.TextBox txtCodVeiculoAlterar;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.Label lblCodVeiculoExcluir;
        private System.Windows.Forms.TextBox txtCodVeiculoExcluir;
        private System.Windows.Forms.Label lblExcluir;
        private Cadastros.CadastroVeiculos cadastroVeiculos1;
        private System.Windows.Forms.BindingSource vEICULOBindingSource;
        private fleetsDataSet fleetsDataSet;
        private fleetsDataSetTableAdapters.VEICULOTableAdapter vEICULOTableAdapter;
        private System.Windows.Forms.ListView lvVeiculos;
        private System.Windows.Forms.Label lblAtualizar;
    }
}
