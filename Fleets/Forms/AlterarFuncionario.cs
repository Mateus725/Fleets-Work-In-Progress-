using Business;
using Controladores;
using Fleets.Controls.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fleets.Forms
{
    public partial class AlterarFuncionario : Form
    {
        Funcionario Funcionario = new Funcionario();
        public AlterarFuncionario(Funcionario funcionario, int CodFuncionario)
        {
            //Ctrl_Funcionario ctrl = new Ctrl_Funcionario();
            
            InitializeComponent();
            Funcionario = funcionario;
            this.txtDataNascimento.Text = Convert.ToString(funcionario.dataNascimento.Date);
            this.txtDataNascimento.Enabled = false;
            this.txtNome.Text = Funcionario.nome;
            this.txtRG.Text = Funcionario.RG;
            this.txtRG.Enabled = false;
            this.txtSexo.Text = Convert.ToString(Funcionario.sexo);
            this.txtCPF.Text = Funcionario.CPF;
            this.txtCPF.Enabled = false;
            this.txtCTPS.Text = Funcionario.CTPS;
            this.txtCTPS.Enabled = false;
            this.txtEstadoCivil.Text = Funcionario.estadoCivil;
            this.txtCTPS.Text = Funcionario.CTPS;
            this.txtEmail.Text = Funcionario.email;
            this.txtLogradouro.Text = Funcionario.endereco;
            this.txtNumero.Text = Convert.ToString(Funcionario.numero);
            this.txtCep.Text = Funcionario.cep;
            this.txtEstado.Text = Funcionario.estado;
            this.txtTelefone.Text = Funcionario.telefone;
            this.cbCargo.Text = Funcionario.cargo;
            //funcionario = funcionario;

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            char sexo;

            /*if (txtNome.Text == "")
            {
                txtNome.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Nome");
            }
            else { txtNome.BackColor = Color.White; };

            if (txtRG.Text == "")
            {
                txtRG.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo RG");

            }
            else { txtRG.BackColor = Color.White; };

            if (txtSexo.Text == "" || txtSexo.Text != "Masculino" || txtSexo.Text != "Feminino" || txtSexo.Text != "Outro")
            {
                txtSexo.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha corretamente o campo Sexo");

            }
            else { txtSexo.BackColor = Color.White; };

            if (txtEstadoCivil.Text == "" || txtEstadoCivil.Text != "Casado(a)" || txtEstadoCivil.Text != "Solteiro(a)" || txtEstadoCivil.Text != "Divorciado(a)")
            {
                txtEstadoCivil.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha corretamente o campo Estado Civil");
            }
            else { txtEstadoCivil.BackColor = Color.White; };

            if (txtDataNascimento.Text == "")
            {
                txtDataNascimento.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Data de Nascimento");
            }
            else { txtDataNascimento.BackColor = Color.White; };
            if (txtCTPS.Text == "")
            {
                txtCTPS.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo CTPS");

            }
            else { txtCTPS.BackColor = Color.White; };
            if (txtCPF.Text == "")
            {
                txtCPF.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo CPF");
            }
            else { txtCPF.BackColor = Color.White; };
           


            if (Convert.ToDateTime(txtDataNascimento.Text).Date < Convert.ToDateTime("01-01-1920").Date)
            {
                MessageBox.Show("Insira uma data de Nascimento válida!");
                txtDataNascimento.BackColor = Color.LightSalmon;

            }
            else { txtDataNascimento.BackColor = Color.White; };

            if (Convert.ToDateTime(txtDataNascimento.Text).Date > DateTime.Now.Date)
            {
                MessageBox.Show("A Data de Nascimento não pode ser no futuro!");
                txtDataNascimento.BackColor = Color.LightSalmon;

            }
            else { txtDataNascimento.BackColor = Color.White; };


            if (txtSexo.Text == "Masculino")
            {
                sexo = 'M';
                txtSexo.BackColor = Color.White;
            }
            else if (txtSexo.Text == "Feminino")
            {
                sexo = 'F';
                txtSexo.BackColor = Color.White;
            }
            else if (txtSexo.Text == "Outro")
            {
                sexo = 'O';
                txtSexo.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Selecione um sexo válido!");
                txtSexo.BackColor = Color.LightSalmon;
            }*/

            Ctrl_Funcionario func = new Ctrl_Funcionario();
            func.AtualizarFuncionario(this.Funcionario.CodFuncionario, txtNome.Text, Convert.ToDateTime(txtDataNascimento.Text).Date, txtRG.Text, txtCPF.Text, Convert.ToChar(txtSexo.Text), txtEstadoCivil.Text, txtCTPS.Text, txtEmail.Text, txtTelefone.Text, txtLogradouro.Text, Convert.ToInt32(txtNumero.Text), txtCep.Text, txtEstado.Text, cbCargo.Text);
        }
    }
}
