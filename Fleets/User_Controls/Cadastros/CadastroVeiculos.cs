using System;
using System.Drawing;
using System.Windows.Forms;

using Controladores;

namespace Fleets.Controls.Cadastros
{
    public partial class CadastroVeiculos : UserControl
    {
        

        public CadastroVeiculos()
        {
            
            InitializeComponent();
           
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtAno.Text == "")
            {
                txtAno.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Ano");
            }
            else { txtAno.BackColor = Color.White; }
            if (txtCor.Text == "")
            {
                txtCor.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Cor");
            }
            else { txtCor.BackColor = Color.White; }
            if (txtInfracoes.Text == "")
            {
                txtInfracoes.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Infrações");
            }
            else { txtInfracoes.BackColor = Color.White; }
            if (txtKm.Text == "")
            {
                txtKm.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Kilometragem");
            }
            else { txtKm.BackColor = Color.White; }
            if (txtMarca.Text == "")
            {
                txtMarca.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Marca");
            }
            else
            {
                txtMarca.BackColor = Color.White;
            }
            if (txtModelo.Text == "")
            {
                txtModelo.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Modelo");
            }
            else
            {
                txtModelo.BackColor = Color.White;
            }
            if (txtPlaca.Text == "")
            {
                txtPlaca.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Placa");
            }
            else { txtPlaca.BackColor = Color.White; }
            if (txtRenavam.Text == "")
            {
                txtRenavam.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Renavam");
            }
            else { txtRenavam.BackColor = Color.White; }
            if (cbCategoria.Text == "")
            {
                cbCategoria.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Categoria");
            }
            else { cbCategoria.BackColor = Color.White; }
            if (cbCombustivel.Text == "")
            {
                cbCombustivel.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Combustivel");
            }
            else { cbCombustivel.BackColor = Color.White; }
            if (cbFrota.Text == "")
            {
                cbFrota.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Frota");
            }
            else { cbFrota.BackColor = Color.White; }
            

            bool seguro = false;
            if (rbSeguroSim.Checked)
            {
                seguro = true;
            }else if (rbSeguroNao.Checked)
            {
                seguro = false;
            }

            bool adaptado = false;
            if (rbAdaptadoSim.Checked)
            {
                adaptado = true;
            }
            else if (rbAdaptadoNao.Checked)
            {
                adaptado = false;
            }

            Ctrl_Veiculo ctrlVeiculo = new Ctrl_Veiculo();
            try
            {

                ctrlVeiculo.CadastroVeiculo(Convert.ToInt32(txtRenavam.Text), txtPlaca.Text, Convert.ToInt32(txtAno.Text),
                    txtMarca.Text, txtModelo.Text, cbCategoria.Text, txtCor.Text, Convert.ToDouble(txtKm.Text),
                    cbCombustivel.Text, seguro, adaptado, Convert.ToInt32(txtInfracoes.Text), cbFrota.Text);
                this.Visible = false;
            }
            catch(Exception i)
            {
                MessageBox.Show("Algo deu Errado. Contate o suporte. \nErro: " + i.Message);
            }


        }
    }
}
