using System;
using Controladores;
using System.Windows.Forms;
using System.Drawing;

namespace Fleets.Controls.Cadastros
{
    public partial class CadastroMecanica : UserControl
    {
        public CadastroMecanica()
        {
            InitializeComponent();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Ctrl_Mecanica cadMecanica = new Ctrl_Mecanica();
            string cep = txtCep.Text;
            cep.Replace("-", "");
            bool estadoCadastro = cadMecanica.CadastroMecanica(Convert.ToInt32(txtRegistroMecanica.Text), cep, txtCep.Text, cbEstado.Text, cbCidade.Text, txtLogradouro.Text);

            if (estadoCadastro)
            {
                txtRegistroMecanica.Text = "";
                txtLogradouro.Text = "";
                txtCep.Text = "";
                cbCidade.Text = "";
                cbEstado.Text = "";
                cbManutencoes.Text = "";
            }

            this.Visible = false;

            if (txtCep.Text == "")
            {
                txtCep.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo CEP");
            }
            else { txtCep.BackColor = Color.White; }
            if (txtLogradouro.Text == "")
            {
                txtLogradouro.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Logradouro");
            }
            else { txtLogradouro.BackColor = Color.White; }
            if (txtRegistroMecanica.Text == "")
            {
                txtRegistroMecanica.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Registro Mecânica");
            }
            else { txtRegistroMecanica.BackColor = Color.White; }
            if (cbCidade.Text == "")
            {
                cbCidade.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Cidade");
            }
            else { cbCidade.BackColor = Color.White; }
            if (cbEstado.Text == "")
            {
                cbEstado.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Estado");
            }
            else
            { cbEstado.BackColor = Color.White; }
            if (cbManutencoes.Text == "")
            {
                cbManutencoes.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Manutenção");
            }
            else { cbManutencoes.BackColor = Color.White; }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            txtCep.Text = "";
            txtLogradouro.Text = "";
            txtRegistroMecanica.Text = "";
            cbCidade.Text = "";
            cbEstado.Text = "";
            cbManutencoes.Text = "";
            this.Visible = false;
        }
    }
}
