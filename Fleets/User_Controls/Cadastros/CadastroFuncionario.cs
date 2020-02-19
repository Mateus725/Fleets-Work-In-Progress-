using Business;
using Controladores;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fleets.Controls.Cadastros
{
    public partial class CadastroFuncionario : UserControl
    {
        Funcionario funcionario = new Funcionario();

        public CadastroFuncionario()
        {
            InitializeComponent();
            lblCNH.Visible = false;
            txtCNH.Visible = false;
            lblHabilitacao.Visible = false;
            cbHabilitacao.Visible = false;
            lblTipoSanguineo.Visible = false;
            cbTipoSsanguineo.Visible = false;
            lblDeficiencia.Visible = false;
            txtDeficiencia.Visible = false;
        }

        public CadastroFuncionario(Funcionario Funcionario)
        {
            InitializeComponent();
            lblCNH.Visible = false;
            txtCNH.Visible = false;
            lblHabilitacao.Visible = false;
            cbHabilitacao.Visible = false;
            lblTipoSanguineo.Visible = false;
            cbTipoSsanguineo.Visible = false;
            lblDeficiencia.Visible = false;
            txtDeficiencia.Visible = false;
            this.funcionario = Funcionario;
            CarregaFuncionario(funcionario);
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCargo.Text != "Motorista" || cbCargo.Text == null)
            {
                lblCNH.Visible = false;
                txtCNH.Visible = false;
                lblHabilitacao.Visible = false;
                cbHabilitacao.Visible = false;
                lblTipoSanguineo.Visible = false;
                cbTipoSsanguineo.Visible = false;
                lblDeficiencia.Visible = false;
                txtDeficiencia.Visible = false;

            }
            else if (cbCargo.Text == "Motorista")
            {
                lblCNH.Visible = true;
                txtCNH.Visible = true;
                lblHabilitacao.Visible = true;
                cbHabilitacao.Visible = true;
                lblTipoSanguineo.Visible = true;
                cbTipoSsanguineo.Visible = true;
                lblDeficiencia.Visible = true;
                txtDeficiencia.Visible = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Ctrl_Funcionario cadFunc = new Ctrl_Funcionario();
            char sexo = 'N';

            if (txtNome.Text == "")
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
            if (cbCargo.Text == "" || cbCargo.Text != "Motorista" || cbCargo.Text != "Gerente" || cbCargo.Text != "Atendente")
            {
                cbCargo.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha corretamente o campo Cargo");
            }
            else { cbCargo.BackColor = Color.White; };


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
            }

            if (cbCargo.Text == "Atendente" || cbCargo.Text == "Gerente")
            {
                bool cad = cadFunc.CadastroFuncionario(cbCargo.Text.ToUpper(), txtNome.Text, Convert.ToDateTime(txtDataNascimento.Text).Date, txtRG.Text, txtCPF.Text, sexo, txtEstadoCivil.Text, txtCTPS.Text, txtEmail.Text, txtTelefone.Text,
                txtLogradouro.Text, Convert.ToInt32(txtNumero.Text), txtCep.Text, txtEstado.Text, txtLogin.Text, txtSenha.Text, Convert.ToInt32(txtCodEmpresa.Text));
                txtSexo.BackColor = Color.White;

                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        c.Text = "";
                    }
                }

                this.Visible = false;
                
                

            }
            else if (cbCargo.Text == "Motorista")
            {
                
                if (txtCNH.Text == null)
                {
                    txtCNH.BackColor = Color.LightSalmon;
                    MessageBox.Show("Atenção! Preencha o campo CNH");
                }
                else { txtCNH.BackColor = Color.White; };
                if (cbHabilitacao.Text == null)
                {
                    cbHabilitacao.BackColor = Color.LightSalmon;
                    MessageBox.Show("Atenção! Preencha o campo Habilitação");
                }
                else { cbHabilitacao.BackColor = Color.White; };

                if (cbTipoSsanguineo.Text == null)
                {
                    cbTipoSsanguineo.BackColor = Color.LightSalmon;
                    MessageBox.Show("Atenção! Preencha o campo Tipo Sanguíneo");
                }
                else { cbTipoSsanguineo.BackColor = Color.White; };

                if (txtDeficiencia.Text == null)
                {
                    cbTipoSsanguineo.BackColor = Color.LightSalmon;
                    MessageBox.Show("Atenção! Preencha o campo Deficência");
                }
                else { txtDeficiencia.BackColor = Color.White; };

                cadFunc.CadastroMotorista(cbCargo.Text.ToUpper(), txtNome.Text, Convert.ToDateTime(txtDataNascimento.Text).Date, txtRG.Text, txtCPF.Text, sexo, txtEstadoCivil.Text, txtCTPS.Text, txtEmail.Text, txtTelefone.Text,
                   txtLogradouro.Text, Convert.ToInt32(txtNumero.Text), txtCep.Text, txtEstado.Text, txtLogin.Text, txtSenha.Text, txtCNH.Text, cbHabilitacao.Text, cbTipoSsanguineo.Text, txtDeficiencia.Text, Convert.ToInt32(txtCodEmpresa.Text));

                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        c.Text = "";
                    }
                }

                this.Visible = false;

            }
        }

        public void CarregaFuncionario(Funcionario Funcionario)
        {

            Ctrl_Funcionario cadFunc = new Ctrl_Funcionario();
            

            this.btnCadastrar.Text = "Atualizar";

            this.txtDataNascimento.Text = Convert.ToString(Funcionario.dataNascimento);
            this.txtDataNascimento.Enabled = false;
            this.txtNome.Text = Funcionario.nome;
            this.txtRG.Text = Funcionario.RG;
            this.txtRG.Enabled = false;
            this.txtSexo.Text = Convert.ToString(Funcionario.sexo);
            this.txtCPF.Text = Funcionario.CPF;
            this.txtCPF.Enabled = false;
            this.txtCTPS.Text = Funcionario.CTPS;
            this.txtCTPS.Enabled = false;
        }
    }
}
