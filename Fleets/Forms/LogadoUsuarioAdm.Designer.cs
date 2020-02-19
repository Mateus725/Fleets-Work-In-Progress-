namespace Fleets
{
    partial class LogadoUsuario
    {
        public char nivelAcesso;
        public void NivelAcesso(char NivelAcesso)
        {
            nivelAcesso = NivelAcesso;
        }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(char nivelAcesso)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogadoUsuario));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarViagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarViagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeViagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmpresasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarManutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarManutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeManutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segurosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarSeguroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarSeguroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeSeguroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mecânicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMecânicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMecânicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeMecânicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFrotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFrotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeFrotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viagensToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioDeViagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRelatórioDeViagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioDeEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRelatórioDeEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioDeVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRelatórioDeVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoristasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioDeMotoristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRelatórioDeMotoristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioDeManutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRelatórioDeManutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segurosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioDeSegurosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRelatórioDeSegurosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mecânicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioDeMecânicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRelatórioDeMecânicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioDeFrotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRelatórioDeFrotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnFrotas = new System.Windows.Forms.Button();
            this.BtnMecanica = new System.Windows.Forms.Button();
            this.BtnSeguro = new System.Windows.Forms.Button();
            this.BtnManutencao = new System.Windows.Forms.Button();
            this.BtnRelatorios = new System.Windows.Forms.Button();
            this.BtnMotoristas = new System.Windows.Forms.Button();
            this.BtnVeiculos = new System.Windows.Forms.Button();
            this.BtnEmpresas = new System.Windows.Forms.Button();
            this.BtnViagens = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.empresa1 = new Fleets.Controls.Empresa();
            this.frotas1 = new Fleets.Controls.Menus.Frotas();
            this.funcionarios1 = new Fleets.Controls.Menus.Funcionarios();
            this.gerarRelatorios1 = new Fleets.Controls.Menus.GerarRelatorios();
            this.manutencao1 = new Fleets.Controls.Menus.Manutencao();
            this.mecanica1 = new Fleets.Controls.Menus.Mecanica();
            this.relatorio2 = new Fleets.Controls.Menus.Relatorio();
            this.relatorio1 = new Fleets.Controls.Menus.Relatorio();
            this.seguro1 = new Fleets.Controls.Menus.Seguro();
            this.veiculos1 = new Fleets.Controls.Menus.Veiculos();
            this.viagens1 = new Fleets.Viagens(nivelAcesso);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viagensToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.veículosToolStripMenuItem,
            this.motoristasToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.segurosToolStripMenuItem,
            this.mecânicaToolStripMenuItem,
            this.frotasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viagensToolStripMenuItem
            // 
            this.viagensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarViagemToolStripMenuItem,
            this.consultarViagemToolStripMenuItem,
            this.relatórioDeViagensToolStripMenuItem});
            this.viagensToolStripMenuItem.Name = "viagensToolStripMenuItem";
            this.viagensToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.viagensToolStripMenuItem.Text = "Viagens";
            // 
            // cadastrarViagemToolStripMenuItem
            // 
            this.cadastrarViagemToolStripMenuItem.Name = "cadastrarViagemToolStripMenuItem";
            this.cadastrarViagemToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cadastrarViagemToolStripMenuItem.Text = "Cadastrar Viagem";
            // 
            // consultarViagemToolStripMenuItem
            // 
            this.consultarViagemToolStripMenuItem.Name = "consultarViagemToolStripMenuItem";
            this.consultarViagemToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultarViagemToolStripMenuItem.Text = "Consultar Viagem";
            // 
            // relatórioDeViagensToolStripMenuItem
            // 
            this.relatórioDeViagensToolStripMenuItem.Name = "relatórioDeViagensToolStripMenuItem";
            this.relatórioDeViagensToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.relatórioDeViagensToolStripMenuItem.Text = "Relatório de Viagens";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEmpresasToolStripMenuItem1,
            this.relatórioDeEmpresasToolStripMenuItem});
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.empresaToolStripMenuItem.Text = "Empresas";
            // 
            // consultarEmpresasToolStripMenuItem1
            // 
            this.consultarEmpresasToolStripMenuItem1.Name = "consultarEmpresasToolStripMenuItem1";
            this.consultarEmpresasToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.consultarEmpresasToolStripMenuItem1.Text = "Consultar Empresas";
            // 
            // relatórioDeEmpresasToolStripMenuItem
            // 
            this.relatórioDeEmpresasToolStripMenuItem.Name = "relatórioDeEmpresasToolStripMenuItem";
            this.relatórioDeEmpresasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.relatórioDeEmpresasToolStripMenuItem.Text = "Relatório de Empresas";
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarVeículoToolStripMenuItem,
            this.consultarVeículoToolStripMenuItem,
            this.relatórioDeVeículoToolStripMenuItem});
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.veículosToolStripMenuItem.Text = "Veículos";
            // 
            // cadastrarVeículoToolStripMenuItem
            // 
            this.cadastrarVeículoToolStripMenuItem.Name = "cadastrarVeículoToolStripMenuItem";
            this.cadastrarVeículoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cadastrarVeículoToolStripMenuItem.Text = "Cadastrar Veículo";
            // 
            // consultarVeículoToolStripMenuItem
            // 
            this.consultarVeículoToolStripMenuItem.Name = "consultarVeículoToolStripMenuItem";
            this.consultarVeículoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.consultarVeículoToolStripMenuItem.Text = "Consultar Veículo";
            // 
            // relatórioDeVeículoToolStripMenuItem
            // 
            this.relatórioDeVeículoToolStripMenuItem.Name = "relatórioDeVeículoToolStripMenuItem";
            this.relatórioDeVeículoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.relatórioDeVeículoToolStripMenuItem.Text = "Relatório de Veículo";
            // 
            // motoristasToolStripMenuItem
            // 
            this.motoristasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarMotoristaToolStripMenuItem,
            this.consultarMotoristaToolStripMenuItem,
            this.relatórioDeMotoristaToolStripMenuItem});
            this.motoristasToolStripMenuItem.Name = "motoristasToolStripMenuItem";
            this.motoristasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.motoristasToolStripMenuItem.Text = "Motoristas";
            // 
            // cadastrarMotoristaToolStripMenuItem
            // 
            this.cadastrarMotoristaToolStripMenuItem.Name = "cadastrarMotoristaToolStripMenuItem";
            this.cadastrarMotoristaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastrarMotoristaToolStripMenuItem.Text = "Cadastrar Motorista";
            // 
            // consultarMotoristaToolStripMenuItem
            // 
            this.consultarMotoristaToolStripMenuItem.Name = "consultarMotoristaToolStripMenuItem";
            this.consultarMotoristaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultarMotoristaToolStripMenuItem.Text = "Consultar Motorista";
            // 
            // relatórioDeMotoristaToolStripMenuItem
            // 
            this.relatórioDeMotoristaToolStripMenuItem.Name = "relatórioDeMotoristaToolStripMenuItem";
            this.relatórioDeMotoristaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.relatórioDeMotoristaToolStripMenuItem.Text = "Relatório de Motorista";
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarManutençãoToolStripMenuItem,
            this.consultarManutençãoToolStripMenuItem,
            this.relatórioDeManutençãoToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // cadastrarManutençãoToolStripMenuItem
            // 
            this.cadastrarManutençãoToolStripMenuItem.Name = "cadastrarManutençãoToolStripMenuItem";
            this.cadastrarManutençãoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cadastrarManutençãoToolStripMenuItem.Text = "Cadastrar Manutenção";
            // 
            // consultarManutençãoToolStripMenuItem
            // 
            this.consultarManutençãoToolStripMenuItem.Name = "consultarManutençãoToolStripMenuItem";
            this.consultarManutençãoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.consultarManutençãoToolStripMenuItem.Text = "Consultar Manutenção";
            // 
            // relatórioDeManutençãoToolStripMenuItem
            // 
            this.relatórioDeManutençãoToolStripMenuItem.Name = "relatórioDeManutençãoToolStripMenuItem";
            this.relatórioDeManutençãoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.relatórioDeManutençãoToolStripMenuItem.Text = "Relatório de Manutenção";
            // 
            // segurosToolStripMenuItem
            // 
            this.segurosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarSeguroToolStripMenuItem,
            this.consultarSeguroToolStripMenuItem,
            this.relatórioDeSeguroToolStripMenuItem});
            this.segurosToolStripMenuItem.Name = "segurosToolStripMenuItem";
            this.segurosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.segurosToolStripMenuItem.Text = "Seguros";
            // 
            // cadastrarSeguroToolStripMenuItem
            // 
            this.cadastrarSeguroToolStripMenuItem.Name = "cadastrarSeguroToolStripMenuItem";
            this.cadastrarSeguroToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cadastrarSeguroToolStripMenuItem.Text = "Cadastrar Seguro";
            // 
            // consultarSeguroToolStripMenuItem
            // 
            this.consultarSeguroToolStripMenuItem.Name = "consultarSeguroToolStripMenuItem";
            this.consultarSeguroToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.consultarSeguroToolStripMenuItem.Text = "Consultar Seguro";
            // 
            // relatórioDeSeguroToolStripMenuItem
            // 
            this.relatórioDeSeguroToolStripMenuItem.Name = "relatórioDeSeguroToolStripMenuItem";
            this.relatórioDeSeguroToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.relatórioDeSeguroToolStripMenuItem.Text = "Relatório de Seguro";
            // 
            // mecânicaToolStripMenuItem
            // 
            this.mecânicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarMecânicaToolStripMenuItem,
            this.consultarMecânicaToolStripMenuItem,
            this.relatórioDeMecânicaToolStripMenuItem});
            this.mecânicaToolStripMenuItem.Name = "mecânicaToolStripMenuItem";
            this.mecânicaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.mecânicaToolStripMenuItem.Text = "Mecânica";
            // 
            // cadastrarMecânicaToolStripMenuItem
            // 
            this.cadastrarMecânicaToolStripMenuItem.Name = "cadastrarMecânicaToolStripMenuItem";
            this.cadastrarMecânicaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastrarMecânicaToolStripMenuItem.Text = "Cadastrar Mecânica";
            // 
            // consultarMecânicaToolStripMenuItem
            // 
            this.consultarMecânicaToolStripMenuItem.Name = "consultarMecânicaToolStripMenuItem";
            this.consultarMecânicaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultarMecânicaToolStripMenuItem.Text = "Consultar Mecânica";
            // 
            // relatórioDeMecânicaToolStripMenuItem
            // 
            this.relatórioDeMecânicaToolStripMenuItem.Name = "relatórioDeMecânicaToolStripMenuItem";
            this.relatórioDeMecânicaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.relatórioDeMecânicaToolStripMenuItem.Text = "Relatório de Mecânica";
            // 
            // frotasToolStripMenuItem
            // 
            this.frotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFrotaToolStripMenuItem,
            this.consultarFrotaToolStripMenuItem,
            this.relatórioDeFrotasToolStripMenuItem});
            this.frotasToolStripMenuItem.Name = "frotasToolStripMenuItem";
            this.frotasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.frotasToolStripMenuItem.Text = "Frotas";
            // 
            // cadastrarFrotaToolStripMenuItem
            // 
            this.cadastrarFrotaToolStripMenuItem.Name = "cadastrarFrotaToolStripMenuItem";
            this.cadastrarFrotaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cadastrarFrotaToolStripMenuItem.Text = "Cadastrar Frota";
            // 
            // consultarFrotaToolStripMenuItem
            // 
            this.consultarFrotaToolStripMenuItem.Name = "consultarFrotaToolStripMenuItem";
            this.consultarFrotaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.consultarFrotaToolStripMenuItem.Text = "Consultar Frota";
            // 
            // relatórioDeFrotasToolStripMenuItem
            // 
            this.relatórioDeFrotasToolStripMenuItem.Name = "relatórioDeFrotasToolStripMenuItem";
            this.relatórioDeFrotasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.relatórioDeFrotasToolStripMenuItem.Text = "Relatório de Frotas";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viagensToolStripMenuItem1,
            this.empresasToolStripMenuItem,
            this.veículosToolStripMenuItem1,
            this.motoristasToolStripMenuItem1,
            this.manutençãoToolStripMenuItem1,
            this.segurosToolStripMenuItem1,
            this.mecânicaToolStripMenuItem1,
            this.frotaToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // viagensToolStripMenuItem1
            // 
            this.viagensToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioDeViagensToolStripMenuItem,
            this.consultarRelatórioDeViagensToolStripMenuItem});
            this.viagensToolStripMenuItem1.Name = "viagensToolStripMenuItem1";
            this.viagensToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.viagensToolStripMenuItem1.Text = "Viagens";
            // 
            // gerarRelatórioDeViagensToolStripMenuItem
            // 
            this.gerarRelatórioDeViagensToolStripMenuItem.Name = "gerarRelatórioDeViagensToolStripMenuItem";
            this.gerarRelatórioDeViagensToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.gerarRelatórioDeViagensToolStripMenuItem.Text = "Gerar Relatório de Viagens";
            // 
            // consultarRelatórioDeViagensToolStripMenuItem
            // 
            this.consultarRelatórioDeViagensToolStripMenuItem.Name = "consultarRelatórioDeViagensToolStripMenuItem";
            this.consultarRelatórioDeViagensToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.consultarRelatórioDeViagensToolStripMenuItem.Text = "Consultar Relatório de Viagens";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioDeEmpresasToolStripMenuItem,
            this.consultarRelatórioDeEmpresasToolStripMenuItem});
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.empresasToolStripMenuItem.Text = "Empresas";
            // 
            // gerarRelatórioDeEmpresasToolStripMenuItem
            // 
            this.gerarRelatórioDeEmpresasToolStripMenuItem.Name = "gerarRelatórioDeEmpresasToolStripMenuItem";
            this.gerarRelatórioDeEmpresasToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.gerarRelatórioDeEmpresasToolStripMenuItem.Text = "Gerar Relatório de Empresas";
            // 
            // consultarRelatórioDeEmpresasToolStripMenuItem
            // 
            this.consultarRelatórioDeEmpresasToolStripMenuItem.Name = "consultarRelatórioDeEmpresasToolStripMenuItem";
            this.consultarRelatórioDeEmpresasToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.consultarRelatórioDeEmpresasToolStripMenuItem.Text = "Consultar Relatório de Empresas";
            // 
            // veículosToolStripMenuItem1
            // 
            this.veículosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioDeVeículosToolStripMenuItem,
            this.consultarRelatórioDeVeículosToolStripMenuItem});
            this.veículosToolStripMenuItem1.Name = "veículosToolStripMenuItem1";
            this.veículosToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.veículosToolStripMenuItem1.Text = "Veículos";
            // 
            // gerarRelatórioDeVeículosToolStripMenuItem
            // 
            this.gerarRelatórioDeVeículosToolStripMenuItem.Name = "gerarRelatórioDeVeículosToolStripMenuItem";
            this.gerarRelatórioDeVeículosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.gerarRelatórioDeVeículosToolStripMenuItem.Text = "Gerar Relatório de Veículos";
            // 
            // consultarRelatórioDeVeículosToolStripMenuItem
            // 
            this.consultarRelatórioDeVeículosToolStripMenuItem.Name = "consultarRelatórioDeVeículosToolStripMenuItem";
            this.consultarRelatórioDeVeículosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.consultarRelatórioDeVeículosToolStripMenuItem.Text = "Consultar Relatório de Veículos";
            // 
            // motoristasToolStripMenuItem1
            // 
            this.motoristasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioDeMotoristasToolStripMenuItem,
            this.consultarRelatórioDeMotoristasToolStripMenuItem});
            this.motoristasToolStripMenuItem1.Name = "motoristasToolStripMenuItem1";
            this.motoristasToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.motoristasToolStripMenuItem1.Text = "Motoristas";
            // 
            // gerarRelatórioDeMotoristasToolStripMenuItem
            // 
            this.gerarRelatórioDeMotoristasToolStripMenuItem.Name = "gerarRelatórioDeMotoristasToolStripMenuItem";
            this.gerarRelatórioDeMotoristasToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.gerarRelatórioDeMotoristasToolStripMenuItem.Text = "Gerar Relatório de Motoristas";
            // 
            // consultarRelatórioDeMotoristasToolStripMenuItem
            // 
            this.consultarRelatórioDeMotoristasToolStripMenuItem.Name = "consultarRelatórioDeMotoristasToolStripMenuItem";
            this.consultarRelatórioDeMotoristasToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.consultarRelatórioDeMotoristasToolStripMenuItem.Text = "Consultar Relatório de Motoristas";
            // 
            // manutençãoToolStripMenuItem1
            // 
            this.manutençãoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioDeManutençãoToolStripMenuItem,
            this.consultarRelatórioDeManutençãoToolStripMenuItem});
            this.manutençãoToolStripMenuItem1.Name = "manutençãoToolStripMenuItem1";
            this.manutençãoToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.manutençãoToolStripMenuItem1.Text = "Manutenção";
            // 
            // gerarRelatórioDeManutençãoToolStripMenuItem
            // 
            this.gerarRelatórioDeManutençãoToolStripMenuItem.Name = "gerarRelatórioDeManutençãoToolStripMenuItem";
            this.gerarRelatórioDeManutençãoToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.gerarRelatórioDeManutençãoToolStripMenuItem.Text = "Gerar Relatório de Manutenção";
            // 
            // consultarRelatórioDeManutençãoToolStripMenuItem
            // 
            this.consultarRelatórioDeManutençãoToolStripMenuItem.Name = "consultarRelatórioDeManutençãoToolStripMenuItem";
            this.consultarRelatórioDeManutençãoToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.consultarRelatórioDeManutençãoToolStripMenuItem.Text = "Consultar Relatório de Manutenção";
            // 
            // segurosToolStripMenuItem1
            // 
            this.segurosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioDeSegurosToolStripMenuItem,
            this.consultarRelatórioDeSegurosToolStripMenuItem});
            this.segurosToolStripMenuItem1.Name = "segurosToolStripMenuItem1";
            this.segurosToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.segurosToolStripMenuItem1.Text = "Seguros";
            // 
            // gerarRelatórioDeSegurosToolStripMenuItem
            // 
            this.gerarRelatórioDeSegurosToolStripMenuItem.Name = "gerarRelatórioDeSegurosToolStripMenuItem";
            this.gerarRelatórioDeSegurosToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.gerarRelatórioDeSegurosToolStripMenuItem.Text = "Gerar Relatório de Seguros";
            // 
            // consultarRelatórioDeSegurosToolStripMenuItem
            // 
            this.consultarRelatórioDeSegurosToolStripMenuItem.Name = "consultarRelatórioDeSegurosToolStripMenuItem";
            this.consultarRelatórioDeSegurosToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.consultarRelatórioDeSegurosToolStripMenuItem.Text = "Consultar Relatório de Seguros";
            // 
            // mecânicaToolStripMenuItem1
            // 
            this.mecânicaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioDeMecânicaToolStripMenuItem,
            this.consultarRelatórioDeMecânicaToolStripMenuItem});
            this.mecânicaToolStripMenuItem1.Name = "mecânicaToolStripMenuItem1";
            this.mecânicaToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.mecânicaToolStripMenuItem1.Text = "Mecânica";
            // 
            // gerarRelatórioDeMecânicaToolStripMenuItem
            // 
            this.gerarRelatórioDeMecânicaToolStripMenuItem.Name = "gerarRelatórioDeMecânicaToolStripMenuItem";
            this.gerarRelatórioDeMecânicaToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.gerarRelatórioDeMecânicaToolStripMenuItem.Text = "Gerar Relatório de Mecânica";
            // 
            // consultarRelatórioDeMecânicaToolStripMenuItem
            // 
            this.consultarRelatórioDeMecânicaToolStripMenuItem.Name = "consultarRelatórioDeMecânicaToolStripMenuItem";
            this.consultarRelatórioDeMecânicaToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.consultarRelatórioDeMecânicaToolStripMenuItem.Text = "Consultar Relatório de Mecânica";
            // 
            // frotaToolStripMenuItem
            // 
            this.frotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioDeFrotaToolStripMenuItem,
            this.consultarRelatórioDeFrotaToolStripMenuItem});
            this.frotaToolStripMenuItem.Name = "frotaToolStripMenuItem";
            this.frotaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.frotaToolStripMenuItem.Text = "Frota";
            // 
            // gerarRelatórioDeFrotaToolStripMenuItem
            // 
            this.gerarRelatórioDeFrotaToolStripMenuItem.Name = "gerarRelatórioDeFrotaToolStripMenuItem";
            this.gerarRelatórioDeFrotaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.gerarRelatórioDeFrotaToolStripMenuItem.Text = "Gerar Relatório de Frota";
            // 
            // consultarRelatórioDeFrotaToolStripMenuItem
            // 
            this.consultarRelatórioDeFrotaToolStripMenuItem.Name = "consultarRelatórioDeFrotaToolStripMenuItem";
            this.consultarRelatórioDeFrotaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.consultarRelatórioDeFrotaToolStripMenuItem.Text = "Consultar Relatório de Frota";
            // 
            // BtnFrotas
            // 
            this.BtnFrotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFrotas.BackColor = System.Drawing.Color.Yellow;
            this.BtnFrotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFrotas.FlatAppearance.BorderSize = 0;
            this.BtnFrotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnFrotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFrotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFrotas.ForeColor = System.Drawing.Color.DimGray;
            this.BtnFrotas.Image = global::Fleets.Properties.Resources.traffic_jam_32px;
            this.BtnFrotas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFrotas.Location = new System.Drawing.Point(898, 555);
            this.BtnFrotas.Name = "BtnFrotas";
            this.BtnFrotas.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.BtnFrotas.Size = new System.Drawing.Size(420, 84);
            this.BtnFrotas.TabIndex = 19;
            this.BtnFrotas.Text = "Frotas";
            this.BtnFrotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFrotas.UseVisualStyleBackColor = false;
            this.BtnFrotas.Click += new System.EventHandler(this.BtnFrotas_Click);
            // 
            // BtnMecanica
            // 
            this.BtnMecanica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMecanica.BackColor = System.Drawing.Color.Yellow;
            this.BtnMecanica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMecanica.FlatAppearance.BorderSize = 0;
            this.BtnMecanica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnMecanica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMecanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMecanica.ForeColor = System.Drawing.Color.DimGray;
            this.BtnMecanica.Image = global::Fleets.Properties.Resources.car_service_32px;
            this.BtnMecanica.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMecanica.Location = new System.Drawing.Point(473, 555);
            this.BtnMecanica.Name = "BtnMecanica";
            this.BtnMecanica.Size = new System.Drawing.Size(420, 84);
            this.BtnMecanica.TabIndex = 18;
            this.BtnMecanica.Text = "Mecânica";
            this.BtnMecanica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMecanica.UseVisualStyleBackColor = false;
            this.BtnMecanica.Click += new System.EventHandler(this.BtnMecanica_Click);
            // 
            // BtnSeguro
            // 
            this.BtnSeguro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeguro.BackColor = System.Drawing.Color.Yellow;
            this.BtnSeguro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSeguro.FlatAppearance.BorderSize = 0;
            this.BtnSeguro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSeguro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeguro.ForeColor = System.Drawing.Color.DimGray;
            this.BtnSeguro.Image = global::Fleets.Properties.Resources.crashed_car_32px;
            this.BtnSeguro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSeguro.Location = new System.Drawing.Point(898, 469);
            this.BtnSeguro.Name = "BtnSeguro";
            this.BtnSeguro.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.BtnSeguro.Size = new System.Drawing.Size(420, 84);
            this.BtnSeguro.TabIndex = 17;
            this.BtnSeguro.Text = "Seguro";
            this.BtnSeguro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSeguro.UseVisualStyleBackColor = false;
            this.BtnSeguro.Click += new System.EventHandler(this.BtnSeguro_Click);
            // 
            // BtnManutencao
            // 
            this.BtnManutencao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnManutencao.BackColor = System.Drawing.Color.Yellow;
            this.BtnManutencao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnManutencao.FlatAppearance.BorderSize = 0;
            this.BtnManutencao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManutencao.ForeColor = System.Drawing.Color.DimGray;
            this.BtnManutencao.Image = global::Fleets.Properties.Resources.maintenance_32px;
            this.BtnManutencao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnManutencao.Location = new System.Drawing.Point(473, 469);
            this.BtnManutencao.Name = "BtnManutencao";
            this.BtnManutencao.Size = new System.Drawing.Size(420, 84);
            this.BtnManutencao.TabIndex = 16;
            this.BtnManutencao.Text = "Manutenção";
            this.BtnManutencao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnManutencao.UseVisualStyleBackColor = false;
            this.BtnManutencao.Click += new System.EventHandler(this.BtnManutencao_Click);
            // 
            // BtnRelatorios
            // 
            this.BtnRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRelatorios.BackColor = System.Drawing.Color.Yellow;
            this.BtnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRelatorios.FlatAppearance.BorderSize = 0;
            this.BtnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelatorios.ForeColor = System.Drawing.Color.DimGray;
            this.BtnRelatorios.Image = global::Fleets.Properties.Resources.line_chart_32px;
            this.BtnRelatorios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRelatorios.Location = new System.Drawing.Point(48, 555);
            this.BtnRelatorios.Name = "BtnRelatorios";
            this.BtnRelatorios.Size = new System.Drawing.Size(420, 84);
            this.BtnRelatorios.TabIndex = 15;
            this.BtnRelatorios.Text = "Relatórios";
            this.BtnRelatorios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRelatorios.UseVisualStyleBackColor = false;
            this.BtnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // BtnMotoristas
            // 
            this.BtnMotoristas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMotoristas.BackColor = System.Drawing.Color.Yellow;
            this.BtnMotoristas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMotoristas.FlatAppearance.BorderSize = 0;
            this.BtnMotoristas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnMotoristas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMotoristas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMotoristas.ForeColor = System.Drawing.Color.DimGray;
            this.BtnMotoristas.Image = global::Fleets.Properties.Resources.driver_32px;
            this.BtnMotoristas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMotoristas.Location = new System.Drawing.Point(48, 469);
            this.BtnMotoristas.Name = "BtnMotoristas";
            this.BtnMotoristas.Size = new System.Drawing.Size(420, 84);
            this.BtnMotoristas.TabIndex = 14;
            this.BtnMotoristas.Text = "Funcionarios";
            this.BtnMotoristas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMotoristas.UseVisualStyleBackColor = false;
            this.BtnMotoristas.Click += new System.EventHandler(this.BtnMotoristas_Click);
            // 
            // BtnVeiculos
            // 
            this.BtnVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVeiculos.BackColor = System.Drawing.Color.Yellow;
            this.BtnVeiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVeiculos.FlatAppearance.BorderSize = 0;
            this.BtnVeiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVeiculos.ForeColor = System.Drawing.Color.DimGray;
            this.BtnVeiculos.Image = global::Fleets.Properties.Resources.car_30px;
            this.BtnVeiculos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVeiculos.Location = new System.Drawing.Point(898, 383);
            this.BtnVeiculos.Name = "BtnVeiculos";
            this.BtnVeiculos.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.BtnVeiculos.Size = new System.Drawing.Size(420, 84);
            this.BtnVeiculos.TabIndex = 13;
            this.BtnVeiculos.Text = "Veículos";
            this.BtnVeiculos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVeiculos.UseMnemonic = false;
            this.BtnVeiculos.UseVisualStyleBackColor = false;
            this.BtnVeiculos.Click += new System.EventHandler(this.btnVeiculos_Click);
            // 
            // BtnEmpresas
            // 
            this.BtnEmpresas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEmpresas.BackColor = System.Drawing.Color.Yellow;
            this.BtnEmpresas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpresas.FlatAppearance.BorderSize = 0;
            this.BtnEmpresas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpresas.ForeColor = System.Drawing.Color.DimGray;
            this.BtnEmpresas.Image = global::Fleets.Properties.Resources.building_26px;
            this.BtnEmpresas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEmpresas.Location = new System.Drawing.Point(473, 383);
            this.BtnEmpresas.Name = "BtnEmpresas";
            this.BtnEmpresas.Size = new System.Drawing.Size(420, 84);
            this.BtnEmpresas.TabIndex = 12;
            this.BtnEmpresas.Text = "Empresas";
            this.BtnEmpresas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEmpresas.UseVisualStyleBackColor = false;
            this.BtnEmpresas.Click += new System.EventHandler(this.BtnEmpresas_Click);
            // 
            // BtnViagens
            // 
            this.BtnViagens.AllowDrop = true;
            this.BtnViagens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnViagens.BackColor = System.Drawing.Color.Yellow;
            this.BtnViagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnViagens.FlatAppearance.BorderSize = 0;
            this.BtnViagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnViagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViagens.ForeColor = System.Drawing.Color.DimGray;
            this.BtnViagens.Image = global::Fleets.Properties.Resources.road_24px;
            this.BtnViagens.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnViagens.Location = new System.Drawing.Point(48, 383);
            this.BtnViagens.Name = "BtnViagens";
            this.BtnViagens.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtnViagens.Size = new System.Drawing.Size(420, 84);
            this.BtnViagens.TabIndex = 11;
            this.BtnViagens.TabStop = false;
            this.BtnViagens.Text = "Viagens";
            this.BtnViagens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnViagens.UseVisualStyleBackColor = false;
            this.BtnViagens.Click += new System.EventHandler(this.BtnViagens_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Fleets.Properties.Resources._1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(418, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 235);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // empresa1
            // 
            this.empresa1.BackColor = System.Drawing.Color.DimGray;
            this.empresa1.Location = new System.Drawing.Point(-748, 92);
            this.empresa1.Name = "empresa1";
            this.empresa1.Size = new System.Drawing.Size(880, 576);
            this.empresa1.TabIndex = 32;
            // 
            // frotas1
            // 
            this.frotas1.BackColor = System.Drawing.Color.DimGray;
            this.frotas1.Location = new System.Drawing.Point(-711, 27);
            this.frotas1.Name = "frotas1";
            this.frotas1.Size = new System.Drawing.Size(880, 576);
            this.frotas1.TabIndex = 31;
            // 
            // funcionarios1
            // 
            this.funcionarios1.BackColor = System.Drawing.Color.DimGray;
            this.funcionarios1.Location = new System.Drawing.Point(-696, 456);
            this.funcionarios1.Name = "funcionarios1";
            this.funcionarios1.Size = new System.Drawing.Size(880, 576);
            this.funcionarios1.TabIndex = 30;
            // 
            // gerarRelatorios1
            // 
            this.gerarRelatorios1.BackColor = System.Drawing.Color.DimGray;
            this.gerarRelatorios1.Location = new System.Drawing.Point(-1270, 0);
            this.gerarRelatorios1.Name = "gerarRelatorios1";
            this.gerarRelatorios1.Size = new System.Drawing.Size(1382, 788);
            this.gerarRelatorios1.TabIndex = 29;
            // 
            // manutencao1
            // 
            this.manutencao1.BackColor = System.Drawing.Color.DimGray;
            this.manutencao1.Location = new System.Drawing.Point(-788, 362);
            this.manutencao1.Name = "manutencao1";
            this.manutencao1.Size = new System.Drawing.Size(880, 576);
            this.manutencao1.TabIndex = 28;
            // 
            // mecanica1
            // 
            this.mecanica1.BackColor = System.Drawing.Color.DimGray;
            this.mecanica1.Location = new System.Drawing.Point(-768, 383);
            this.mecanica1.Name = "mecanica1";
            this.mecanica1.Size = new System.Drawing.Size(880, 576);
            this.mecanica1.TabIndex = 27;
            // 
            // relatorio2
            // 
            this.relatorio2.BackColor = System.Drawing.Color.DimGray;
            this.relatorio2.Location = new System.Drawing.Point(-815, 383);
            this.relatorio2.Name = "relatorio2";
            this.relatorio2.Size = new System.Drawing.Size(880, 576);
            this.relatorio2.TabIndex = 26;
            // 
            // relatorio1
            // 
            this.relatorio1.BackColor = System.Drawing.Color.DimGray;
            this.relatorio1.Location = new System.Drawing.Point(-815, 362);
            this.relatorio1.Name = "relatorio1";
            this.relatorio1.Size = new System.Drawing.Size(880, 576);
            this.relatorio1.TabIndex = 25;
            // 
            // seguro1
            // 
            this.seguro1.BackColor = System.Drawing.Color.DimGray;
            this.seguro1.Location = new System.Drawing.Point(-815, 383);
            this.seguro1.Name = "seguro1";
            this.seguro1.Size = new System.Drawing.Size(880, 576);
            this.seguro1.TabIndex = 24;
            // 
            // veiculos1
            // 
            this.veiculos1.BackColor = System.Drawing.Color.DimGray;
            this.veiculos1.Location = new System.Drawing.Point(-815, 151);
            this.veiculos1.Name = "veiculos1";
            this.veiculos1.Size = new System.Drawing.Size(880, 576);
            this.veiculos1.TabIndex = 23;
            // 
            // viagens1
            // 
            this.viagens1.AutoScroll = true;
            this.viagens1.BackColor = System.Drawing.Color.DimGray;
            this.viagens1.Location = new System.Drawing.Point(-815, 413);
            this.viagens1.Name = "viagens1";
            this.viagens1.Size = new System.Drawing.Size(880, 576);
            this.viagens1.TabIndex = 22;
            // 
            // LogadoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.empresa1);
            this.Controls.Add(this.frotas1);
            this.Controls.Add(this.funcionarios1);
            this.Controls.Add(this.gerarRelatorios1);
            this.Controls.Add(this.manutencao1);
            this.Controls.Add(this.mecanica1);
            this.Controls.Add(this.relatorio2);
            this.Controls.Add(this.relatorio1);
            this.Controls.Add(this.seguro1);
            this.Controls.Add(this.veiculos1);
            this.Controls.Add(this.viagens1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnFrotas);
            this.Controls.Add(this.BtnMecanica);
            this.Controls.Add(this.BtnSeguro);
            this.Controls.Add(this.BtnManutencao);
            this.Controls.Add(this.BtnRelatorios);
            this.Controls.Add(this.BtnMotoristas);
            this.Controls.Add(this.BtnVeiculos);
            this.Controls.Add(this.BtnEmpresas);
            this.Controls.Add(this.BtnViagens);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LogadoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fleets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LogadoUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarViagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarViagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeViagensToolStripMenuItem;
        private System.Windows.Forms.Button BtnViagens;
        private System.Windows.Forms.Button BtnEmpresas;
        private System.Windows.Forms.Button BtnVeiculos;
        private System.Windows.Forms.Button BtnMotoristas;
        private System.Windows.Forms.Button BtnRelatorios;
        private System.Windows.Forms.Button BtnManutencao;
        private System.Windows.Forms.Button BtnSeguro;
        private System.Windows.Forms.Button BtnMecanica;
        private System.Windows.Forms.Button BtnFrotas;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEmpresasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeEmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoristasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMotoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMotoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeMotoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarManutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarManutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeManutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segurosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarSeguroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarSeguroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeSeguroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mecânicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMecânicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMecânicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeMecânicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFrotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFrotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeFrotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viagensToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioDeViagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRelatórioDeViagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioDeEmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRelatórioDeEmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioDeVeículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRelatórioDeVeículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoristasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioDeMotoristasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRelatórioDeMotoristasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioDeManutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRelatórioDeManutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segurosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioDeSegurosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRelatórioDeSegurosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mecânicaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioDeMecânicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRelatórioDeMecânicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioDeFrotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRelatórioDeFrotaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Viagens viagens1;
        private Controls.Menus.Veiculos veiculos1;
        private Controls.Menus.Seguro seguro1;
        private Controls.Menus.Relatorio relatorio1;
        private Controls.Menus.Relatorio relatorio2;
        private Controls.Menus.Mecanica mecanica1;
        private Controls.Menus.Manutencao manutencao1;
        private Controls.Menus.GerarRelatorios gerarRelatorios1;
        private Controls.Menus.Funcionarios funcionarios1;
        private Controls.Menus.Frotas frotas1;
        private Controls.Empresa empresa1;
    }



}