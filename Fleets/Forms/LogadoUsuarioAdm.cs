using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fleets
{
    public partial class LogadoUsuario : Form
    {
        public LogadoUsuario(char nivelAcesso)
        {

            InitializeComponent(nivelAcesso);
            this.viagens1.Visible = false;
            this.empresa1.Visible = false;
            this.veiculos1.Visible = false;
            this.funcionarios1.Visible = false;
            this.manutencao1.Visible = false;
            this.seguro1.Visible = false;
            this.relatorio1.Visible = false;
            this.mecanica1.Visible = false;
            this.frotas1.Visible = false;
            this.gerarRelatorios1.Visible = false;
            this.relatorio2.Visible = false;
            

            // UserControl login = new MenuUsuario();
            //carregarMenu.Controls.Add(login);

            //login.Show();
            //login.Dock = DockStyle.Fill;



        }

        private void LogadoUsuario_Load(object sender, EventArgs e)
        {
            viagens1.Visible = false;
            empresa1.Visible = false;
            veiculos1.Visible = false;
            funcionarios1.Visible = false;
            manutencao1.Visible = false;
            seguro1.Visible = false;
            relatorio1.Visible = false;
            mecanica1.Visible = false;
            frotas1.Visible = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.MinimumSize = new Size(800, 600);

            BtnViagens.Height = Convert.ToInt32(this.Height * 0.11);
            BtnViagens.Width = Convert.ToInt32(this.Width * 0.29);

            BtnEmpresas.Height = Convert.ToInt32(this.Height * 0.11);
            BtnEmpresas.Width = Convert.ToInt32(this.Width * 0.29);

            BtnVeiculos.Height = Convert.ToInt32(this.Height * 0.11);
            BtnVeiculos.Width = Convert.ToInt32(this.Width * 0.29);

            BtnMotoristas.Height = Convert.ToInt32(this.Height * 0.11);
            BtnMotoristas.Width = Convert.ToInt32(this.Width * 0.29);

            BtnManutencao.Height = Convert.ToInt32(this.Height * 0.11);
            BtnManutencao.Width = Convert.ToInt32(this.Width * 0.29);

            BtnSeguro.Height = Convert.ToInt32(this.Height * 0.11);
            BtnSeguro.Width = Convert.ToInt32(this.Width * 0.29);

            BtnRelatorios.Height = Convert.ToInt32(this.Height * 0.11);
            BtnRelatorios.Width = Convert.ToInt32(this.Width * 0.29);

            BtnMecanica.Height = Convert.ToInt32(this.Height * 0.11);
            BtnMecanica.Width = Convert.ToInt32(this.Width * 0.29);

            BtnFrotas.Height = Convert.ToInt32(this.Height * 0.11);
            BtnFrotas.Width = Convert.ToInt32(this.Width * 0.29);


        }

        

        private void BtnViagens_Click(object sender, EventArgs e)
        {
            
            viagens1.Visible = true;
            viagens1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            viagens1.Location = this.Location;
            viagens1.Dock = DockStyle.Fill;
            viagens1.Show();
           
            if(viagens1.Visible == false)
            {
                BtnViagens_Click(sender, e);
            }

            
        }

        private void BtnEmpresas_Click(object sender, EventArgs e)
        {
            empresa1.Visible = true;
            empresa1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            empresa1.Location = this.Location;
            empresa1.Dock = DockStyle.Fill;
            empresa1.Show();

            if (empresa1.Visible == false)
            {
                BtnEmpresas_Click(sender, e);
            }
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            veiculos1.Visible = true;
            veiculos1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            veiculos1.Location = this.Location;
            veiculos1.Dock = DockStyle.Fill;
            veiculos1.Show();

            if (veiculos1.Visible == false)
            {
                btnVeiculos_Click(sender, e);
            }
        }

        private void BtnMotoristas_Click(object sender, EventArgs e)
        {
            funcionarios1.Visible = true;
            funcionarios1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            funcionarios1.Location = this.Location;
            funcionarios1.Dock = DockStyle.Fill;
            funcionarios1.Show();

            if (funcionarios1.Visible == false)
            {
                BtnMotoristas_Click(sender, e);
            }
        }

        private void BtnManutencao_Click(object sender, EventArgs e)
        {
            manutencao1.Visible = true;
            manutencao1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            manutencao1.Location = this.Location;
            manutencao1.Dock = DockStyle.Fill;
            manutencao1.Show();

            if (manutencao1.Visible == false)
            {
                BtnManutencao_Click(sender, e);
            }
        }

        private void BtnSeguro_Click(object sender, EventArgs e)
        {
            seguro1.Visible = true;
            seguro1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            seguro1.Location = this.Location;
            seguro1.Dock = DockStyle.Fill;
            seguro1.Show();

            if (seguro1.Visible == false)
            {
                BtnSeguro_Click(sender, e);
            }
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            relatorio1.Visible = true;
            relatorio1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            relatorio1.Location = this.Location;
            relatorio1.Dock = DockStyle.Fill;
            relatorio1.Show();

            if (relatorio1.Visible == false)
            {
                BtnRelatorios_Click(sender, e);
            }
        }

        private void BtnMecanica_Click(object sender, EventArgs e)
        {
            mecanica1.Visible = true;
            mecanica1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            mecanica1.Location = this.Location;
            mecanica1.Dock = DockStyle.Fill;
            mecanica1.Show();

            if (mecanica1.Visible == false)
            {
                BtnMecanica_Click(sender, e);
            }
        }

        private void BtnFrotas_Click(object sender, EventArgs e)
        {
            frotas1.Visible = true;
            frotas1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            frotas1.Location = this.Location;
            frotas1.Dock = DockStyle.Fill;
            frotas1.Show();

            if (frotas1.Visible == false)
            {
                BtnFrotas_Click(sender, e);
            }
        }

        

        /*private void cadastrarViagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroViagens1.Visible = true;
            cadastroViagens1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            cadastroViagens1.Location = this.Location;
            cadastroViagens1.Dock = DockStyle.Fill;
            cadastroViagens1.Show();

            if (cadastroViagens1.Visible == false)
            {
                cadastrarViagemToolStripMenuItem_Click(sender, e);
            }

        }*/
    }
}
