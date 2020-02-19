namespace Fleets.Controls.Cadastros
{
    partial class CadastroVeiculos
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
            this.lblDadosVeiculo = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtRenavam = new System.Windows.Forms.TextBox();
            this.lblCadastroVeículos = new System.Windows.Forms.Label();
            this.lblRenavam = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.imgFleets = new System.Windows.Forms.PictureBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.cbCombustivel = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.gbSeguro = new System.Windows.Forms.GroupBox();
            this.rbSeguroNao = new System.Windows.Forms.RadioButton();
            this.rbSeguroSim = new System.Windows.Forms.RadioButton();
            this.lblAdaptado = new System.Windows.Forms.Label();
            this.gbAdaptado = new System.Windows.Forms.GroupBox();
            this.rbAdaptadoNao = new System.Windows.Forms.RadioButton();
            this.rbAdaptadoSim = new System.Windows.Forms.RadioButton();
            this.lblInfracoes = new System.Windows.Forms.Label();
            this.txtInfracoes = new System.Windows.Forms.TextBox();
            this.lblFrota = new System.Windows.Forms.Label();
            this.cbFrota = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).BeginInit();
            this.gbSeguro.SuspendLayout();
            this.gbAdaptado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnCadastrar.TabIndex = 66;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnVoltar.TabIndex = 65;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // lblDadosVeiculo
            // 
            this.lblDadosVeiculo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDadosVeiculo.AutoSize = true;
            this.lblDadosVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosVeiculo.ForeColor = System.Drawing.Color.Yellow;
            this.lblDadosVeiculo.Location = new System.Drawing.Point(41, 236);
            this.lblDadosVeiculo.Name = "lblDadosVeiculo";
            this.lblDadosVeiculo.Size = new System.Drawing.Size(182, 24);
            this.lblDadosVeiculo.TabIndex = 46;
            this.lblDadosVeiculo.Text = "Dados do Veículo:";
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.Yellow;
            this.lblModelo.Location = new System.Drawing.Point(276, 341);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(65, 20);
            this.lblModelo.TabIndex = 42;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtRenavam
            // 
            this.txtRenavam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRenavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenavam.Location = new System.Drawing.Point(130, 269);
            this.txtRenavam.MaxLength = 11;
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.Size = new System.Drawing.Size(245, 26);
            this.txtRenavam.TabIndex = 41;
            // 
            // lblCadastroVeículos
            // 
            this.lblCadastroVeículos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroVeículos.AutoSize = true;
            this.lblCadastroVeículos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroVeículos.ForeColor = System.Drawing.Color.Yellow;
            this.lblCadastroVeículos.Location = new System.Drawing.Point(227, 183);
            this.lblCadastroVeículos.Name = "lblCadastroVeículos";
            this.lblCadastroVeículos.Size = new System.Drawing.Size(342, 37);
            this.lblCadastroVeículos.TabIndex = 40;
            this.lblCadastroVeículos.Text = "Cadastro de Veículos";
            // 
            // lblRenavam
            // 
            this.lblRenavam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRenavam.AutoSize = true;
            this.lblRenavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenavam.ForeColor = System.Drawing.Color.Yellow;
            this.lblRenavam.Location = new System.Drawing.Point(41, 272);
            this.lblRenavam.Name = "lblRenavam";
            this.lblRenavam.Size = new System.Drawing.Size(93, 20);
            this.lblRenavam.TabIndex = 39;
            this.lblRenavam.Text = "RENAVAM:";
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(95, 338);
            this.txtMarca.MaxLength = 15;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(175, 26);
            this.txtMarca.TabIndex = 38;
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Yellow;
            this.lblMarca.Location = new System.Drawing.Point(42, 341);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 20);
            this.lblMarca.TabIndex = 37;
            this.lblMarca.Text = "Marca:";
            // 
            // imgFleets
            // 
            this.imgFleets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgFleets.BackgroundImage = global::Fleets.Properties.Resources._1;
            this.imgFleets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFleets.Location = new System.Drawing.Point(275, 11);
            this.imgFleets.Name = "imgFleets";
            this.imgFleets.Size = new System.Drawing.Size(259, 160);
            this.imgFleets.TabIndex = 36;
            this.imgFleets.TabStop = false;
            // 
            // lblPlaca
            // 
            this.lblPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlaca.Location = new System.Drawing.Point(377, 272);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(52, 20);
            this.lblPlaca.TabIndex = 67;
            this.lblPlaca.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(427, 269);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(116, 26);
            this.txtPlaca.TabIndex = 68;
            // 
            // lblAno
            // 
            this.lblAno.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.Color.Yellow;
            this.lblAno.Location = new System.Drawing.Point(549, 272);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(42, 20);
            this.lblAno.TabIndex = 69;
            this.lblAno.Text = "Ano:";
            // 
            // txtAno
            // 
            this.txtAno.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(590, 269);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(118, 26);
            this.txtAno.TabIndex = 70;
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(341, 338);
            this.txtModelo.MaxLength = 15;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(158, 26);
            this.txtModelo.TabIndex = 71;
            // 
            // lblCor
            // 
            this.lblCor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.ForeColor = System.Drawing.Color.Yellow;
            this.lblCor.Location = new System.Drawing.Point(41, 416);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(38, 20);
            this.lblCor.TabIndex = 72;
            this.lblCor.Text = "Cor:";
            // 
            // txtCor
            // 
            this.txtCor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(85, 413);
            this.txtCor.MaxLength = 10;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(126, 26);
            this.txtCor.TabIndex = 73;
            // 
            // lblKm
            // 
            this.lblKm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.ForeColor = System.Drawing.Color.Yellow;
            this.lblKm.Location = new System.Drawing.Point(217, 416);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(110, 20);
            this.lblKm.TabIndex = 74;
            this.lblKm.Text = "Kilometragem:";
            // 
            // txtKm
            // 
            this.txtKm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm.Location = new System.Drawing.Point(325, 413);
            this.txtKm.MaxLength = 5;
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(113, 26);
            this.txtKm.TabIndex = 75;
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustivel.ForeColor = System.Drawing.Color.Yellow;
            this.lblCombustivel.Location = new System.Drawing.Point(438, 416);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(99, 20);
            this.lblCombustivel.TabIndex = 76;
            this.lblCombustivel.Text = "Combustivel:";
            // 
            // cbCombustivel
            // 
            this.cbCombustivel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCombustivel.FormattingEnabled = true;
            this.cbCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "GNV",
            "Etanol",
            "Diesel"});
            this.cbCombustivel.Location = new System.Drawing.Point(537, 411);
            this.cbCombustivel.Name = "cbCombustivel";
            this.cbCombustivel.Size = new System.Drawing.Size(171, 28);
            this.cbCombustivel.TabIndex = 77;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Yellow;
            this.lblCategoria.Location = new System.Drawing.Point(508, 341);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 20);
            this.lblCategoria.TabIndex = 78;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Compacto",
            "Sedã",
            "Hatch",
            "Picape",
            "SUV",
            "Van",
            "Furgão",
            "Caminhão"});
            this.cbCategoria.Location = new System.Drawing.Point(591, 338);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(116, 28);
            this.cbCategoria.TabIndex = 79;
            // 
            // lblSeguro
            // 
            this.lblSeguro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.ForeColor = System.Drawing.Color.Yellow;
            this.lblSeguro.Location = new System.Drawing.Point(45, 487);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(65, 20);
            this.lblSeguro.TabIndex = 80;
            this.lblSeguro.Text = "Seguro:";
            // 
            // gbSeguro
            // 
            this.gbSeguro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbSeguro.Controls.Add(this.rbSeguroNao);
            this.gbSeguro.Controls.Add(this.rbSeguroSim);
            this.gbSeguro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSeguro.Location = new System.Drawing.Point(116, 476);
            this.gbSeguro.Name = "gbSeguro";
            this.gbSeguro.Size = new System.Drawing.Size(110, 36);
            this.gbSeguro.TabIndex = 81;
            this.gbSeguro.TabStop = false;
            // 
            // rbSeguroNao
            // 
            this.rbSeguroNao.AutoSize = true;
            this.rbSeguroNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSeguroNao.ForeColor = System.Drawing.Color.Yellow;
            this.rbSeguroNao.Location = new System.Drawing.Point(55, 9);
            this.rbSeguroNao.Name = "rbSeguroNao";
            this.rbSeguroNao.Size = new System.Drawing.Size(56, 24);
            this.rbSeguroNao.TabIndex = 1;
            this.rbSeguroNao.TabStop = true;
            this.rbSeguroNao.Text = "Não";
            this.rbSeguroNao.UseVisualStyleBackColor = true;
            // 
            // rbSeguroSim
            // 
            this.rbSeguroSim.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbSeguroSim.AutoSize = true;
            this.rbSeguroSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbSeguroSim.ForeColor = System.Drawing.Color.Yellow;
            this.rbSeguroSim.Location = new System.Drawing.Point(6, 8);
            this.rbSeguroSim.Name = "rbSeguroSim";
            this.rbSeguroSim.Size = new System.Drawing.Size(54, 24);
            this.rbSeguroSim.TabIndex = 0;
            this.rbSeguroSim.TabStop = true;
            this.rbSeguroSim.Text = "Sim";
            this.rbSeguroSim.UseVisualStyleBackColor = true;
            // 
            // lblAdaptado
            // 
            this.lblAdaptado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdaptado.AutoSize = true;
            this.lblAdaptado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaptado.ForeColor = System.Drawing.Color.Yellow;
            this.lblAdaptado.Location = new System.Drawing.Point(279, 487);
            this.lblAdaptado.Name = "lblAdaptado";
            this.lblAdaptado.Size = new System.Drawing.Size(83, 20);
            this.lblAdaptado.TabIndex = 82;
            this.lblAdaptado.Text = "Adaptado:";
            // 
            // gbAdaptado
            // 
            this.gbAdaptado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbAdaptado.Controls.Add(this.rbAdaptadoNao);
            this.gbAdaptado.Controls.Add(this.rbAdaptadoSim);
            this.gbAdaptado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAdaptado.Location = new System.Drawing.Point(379, 476);
            this.gbAdaptado.Name = "gbAdaptado";
            this.gbAdaptado.Size = new System.Drawing.Size(110, 36);
            this.gbAdaptado.TabIndex = 82;
            this.gbAdaptado.TabStop = false;
            // 
            // rbAdaptadoNao
            // 
            this.rbAdaptadoNao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbAdaptadoNao.AutoSize = true;
            this.rbAdaptadoNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdaptadoNao.ForeColor = System.Drawing.Color.Yellow;
            this.rbAdaptadoNao.Location = new System.Drawing.Point(55, 9);
            this.rbAdaptadoNao.Name = "rbAdaptadoNao";
            this.rbAdaptadoNao.Size = new System.Drawing.Size(56, 24);
            this.rbAdaptadoNao.TabIndex = 1;
            this.rbAdaptadoNao.TabStop = true;
            this.rbAdaptadoNao.Text = "Não";
            this.rbAdaptadoNao.UseVisualStyleBackColor = true;
            // 
            // rbAdaptadoSim
            // 
            this.rbAdaptadoSim.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbAdaptadoSim.AutoSize = true;
            this.rbAdaptadoSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbAdaptadoSim.ForeColor = System.Drawing.Color.Yellow;
            this.rbAdaptadoSim.Location = new System.Drawing.Point(6, 8);
            this.rbAdaptadoSim.Name = "rbAdaptadoSim";
            this.rbAdaptadoSim.Size = new System.Drawing.Size(54, 24);
            this.rbAdaptadoSim.TabIndex = 0;
            this.rbAdaptadoSim.TabStop = true;
            this.rbAdaptadoSim.Text = "Sim";
            this.rbAdaptadoSim.UseVisualStyleBackColor = true;
            // 
            // lblInfracoes
            // 
            this.lblInfracoes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInfracoes.AutoSize = true;
            this.lblInfracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfracoes.ForeColor = System.Drawing.Color.Yellow;
            this.lblInfracoes.Location = new System.Drawing.Point(568, 486);
            this.lblInfracoes.Name = "lblInfracoes";
            this.lblInfracoes.Size = new System.Drawing.Size(80, 20);
            this.lblInfracoes.TabIndex = 83;
            this.lblInfracoes.Text = "Infrações:";
            // 
            // txtInfracoes
            // 
            this.txtInfracoes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtInfracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfracoes.Location = new System.Drawing.Point(646, 482);
            this.txtInfracoes.MaxLength = 3;
            this.txtInfracoes.Name = "txtInfracoes";
            this.txtInfracoes.Size = new System.Drawing.Size(62, 26);
            this.txtInfracoes.TabIndex = 84;
            // 
            // lblFrota
            // 
            this.lblFrota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFrota.AutoSize = true;
            this.lblFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrota.ForeColor = System.Drawing.Color.Yellow;
            this.lblFrota.Location = new System.Drawing.Point(45, 541);
            this.lblFrota.Name = "lblFrota";
            this.lblFrota.Size = new System.Drawing.Size(51, 20);
            this.lblFrota.TabIndex = 85;
            this.lblFrota.Text = "Frota:";
            // 
            // cbFrota
            // 
            this.cbFrota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrota.FormattingEnabled = true;
            this.cbFrota.Items.AddRange(new object[] {
            "Vivo",
            "Oi",
            "Tim",
            "Claro"});
            this.cbFrota.Location = new System.Drawing.Point(99, 538);
            this.cbFrota.Name = "cbFrota";
            this.cbFrota.Size = new System.Drawing.Size(608, 28);
            this.cbFrota.TabIndex = 86;
            // 
            // CadastroVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.cbFrota);
            this.Controls.Add(this.lblFrota);
            this.Controls.Add(this.txtInfracoes);
            this.Controls.Add(this.lblInfracoes);
            this.Controls.Add(this.gbAdaptado);
            this.Controls.Add(this.lblAdaptado);
            this.Controls.Add(this.gbSeguro);
            this.Controls.Add(this.lblSeguro);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbCombustivel);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblDadosVeiculo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtRenavam);
            this.Controls.Add(this.lblCadastroVeículos);
            this.Controls.Add(this.lblRenavam);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.imgFleets);
            this.Name = "CadastroVeiculos";
            this.Size = new System.Drawing.Size(748, 637);
            ((System.ComponentModel.ISupportInitialize)(this.imgFleets)).EndInit();
            this.gbSeguro.ResumeLayout(false);
            this.gbSeguro.PerformLayout();
            this.gbAdaptado.ResumeLayout(false);
            this.gbAdaptado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblDadosVeiculo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtRenavam;
        private System.Windows.Forms.Label lblCadastroVeículos;
        private System.Windows.Forms.Label lblRenavam;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.PictureBox imgFleets;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.ComboBox cbCombustivel;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.GroupBox gbSeguro;
        private System.Windows.Forms.RadioButton rbSeguroNao;
        private System.Windows.Forms.RadioButton rbSeguroSim;
        private System.Windows.Forms.Label lblAdaptado;
        private System.Windows.Forms.GroupBox gbAdaptado;
        private System.Windows.Forms.RadioButton rbAdaptadoNao;
        private System.Windows.Forms.RadioButton rbAdaptadoSim;
        private System.Windows.Forms.Label lblInfracoes;
        private System.Windows.Forms.TextBox txtInfracoes;
        private System.Windows.Forms.Label lblFrota;
        private System.Windows.Forms.ComboBox cbFrota;
    }
}
