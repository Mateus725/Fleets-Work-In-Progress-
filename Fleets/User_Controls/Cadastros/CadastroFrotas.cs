using System;
using System.Drawing;
using Controladores;
using System.Windows.Forms;

namespace Fleets.Controls.Cadastros
{
    public partial class CadastroFrotas : UserControl
    {
        public CadastroFrotas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            if (txtQtdMotoristas.Text == "")
            {
                txtQtdMotoristas.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Quantidade de Motoristas");
            }
            else { txtQtdMotoristas.BackColor = Color.White; };

            if (txtQtdVeiculos.Text == "")
            {
                txtQtdVeiculos.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Quantidade de Veiculos");
            }
            else { txtQtdVeiculos.BackColor = Color.White; };

            if (txtEmpresa.Text == "")
            {
                txtEmpresa.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Empresa");
            }
            else { txtEmpresa.BackColor = Color.White; };

            Ctrl_Frota ctrlFrota = new Ctrl_Frota();

            try
            {
                bool cadFrota = ctrlFrota.CadFrota(txtEmpresa.Text, txtNomeFrota.Text, Convert.ToInt32(txtQtdVeiculos.Text), Convert.ToInt32(txtQtdMotoristas.Text));
                if (cadFrota)
                {
                    MessageBox.Show("Frota cadastrada com sucesso!");
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
                    MessageBox.Show("Não foi possível cadastrar a frota");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Ops, algo deu errado! Contate o suporte. Erro: " + err.Message);
            }
        }

        
    }
}
