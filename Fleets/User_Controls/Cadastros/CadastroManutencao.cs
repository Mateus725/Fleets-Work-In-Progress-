using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;

namespace Fleets.Controls.Cadastros
{
    public partial class CadastroManutencao : UserControl
    {
        public CadastroManutencao()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtData.Text == "")
            {
                txtData.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Data");
            }
            else { txtData.BackColor = Color.White; }
            if (txtMotivo.Text == "")
            {
                txtMotivo.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Motivo");
            }
            else { txtMotivo.BackColor = Color.White; }
            if (txtPlaca.Text == "" || txtPlaca.TextLength > 7)
            {
                txtPlaca.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha corretamente o campo Placa");
            }
            else { txtPlaca.BackColor = Color.White; }
            if (cbEmpresa.Text == "")
            {
                cbEmpresa.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Empresa");
            }
            else { cbEmpresa.BackColor = Color.White; }
            if (txtRegistroMecanica.Text == "")
            {
                txtRegistroMecanica.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Mecânica");
            }
            else { txtRegistroMecanica.BackColor = Color.White; }

            Ctrl_Manutencao ctrlManutencao = new Ctrl_Manutencao();

            try
            {
                bool cadManutencao = ctrlManutencao.CadManutencao(txtPlaca.Text, txtMotivo.Text, Convert.ToDateTime(txtData.Text), cbEmpresa.Text, txtObservacoes.Text, Convert.ToDecimal(txtRegistroMecanica.Text));

                if (cadManutencao)
                {
                    MessageBox.Show("Manutenção cadastrada com sucesso!");
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType() == typeof(TextBox))
                        {
                            c.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar a Manutenção");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ops, algo deu errado! Contate o suporte. Erro: " + err.Message);
            }
        }
    }
}
