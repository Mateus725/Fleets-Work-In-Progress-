using BDClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fleets
{
    public partial class MenuLogin : Form
    {


        public MenuLogin()
        {
            InitializeComponent();
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.MinimumSize = new Size(800, 600);



        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            LogadoUsuario login = new LogadoUsuario();
            try
            {
                Ctrl_BD verificaLogin = new Ctrl_BD();
                string cargo = verificaLogin.VerificaLogin(txtLogin.Text.TrimEnd().TrimStart(), txtSenha.Text);
                if (cargo.ToUpper() == "ATENDENTE" || cargo.ToUpper() == "GERENTE")
                {

                    MessageBox.Show("Nível de Acesso: " + cargo);
                    this.Hide();
                    login.Closed += (s, args) => this.Close();
                    login.Show();
                }
                else if (cargo == "MOTORISTA")
                {
                    MessageBox.Show("Acesso bloqueado para motoristas");
                }
                else
                {
                    MessageBox.Show("Acesso com um usuário ou senha válidos");
                }
            }catch
            {
                MessageBox.Show("Erro ao efetuar o Login. Acesse com um usuário e senha válidos!");
            }


        }

    }
}
