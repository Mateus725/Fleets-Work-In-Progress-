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
using Controls;

namespace Fleets.Controls.Cadastros
{
    public partial class CadastroViagens : UserControl
    {
        public CadastroViagens()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void imgFleets_Click(object sender, EventArgs e)
        {

        }

        private void lblCadastroViagens_Click(object sender, EventArgs e)
        {

        }

        private void lblOrigem_Click(object sender, EventArgs e)
        {

        }

        private void lblLogradouro_Click(object sender, EventArgs e)
        {

        }

        private void lblCEP_Click(object sender, EventArgs e)
        {

        }

        private void txtCepOrigem_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtLogradouroOrigem_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void cbEstadoOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCepDestino.Text == "")
            {
                txtCepDestino.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo CEP de Destino");
            }
            else { txtCepDestino.BackColor = Color.White; }
            if (txtCepOrigem.Text == "")
            {
                txtCepOrigem.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Cep de Origem");
            }
            else { txtCepOrigem.BackColor = Color.White; }
            if (txtLogradouroDestino.Text == "")
            {
                txtLogradouroDestino.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Logradouro de Destino");
            }
            else { txtLogradouroDestino.BackColor = Color.White; }
            if (txtLogradouroOrigem.Text == "")
            {
                txtLogradouroOrigem.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Logradouro de Origem");
            }
            else { txtLogradouroOrigem.BackColor = Color.White; }
            if (txtNumeroOrigem.Text == "")
            {
                txtNumeroOrigem.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Numero de Origem");
            }
            else { txtNumeroOrigem.BackColor = Color.White; }
            if (txtNumeroDestino.Text == "")
            {
                txtNumeroDestino.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Numero de Destino");
            }
            else { txtNumeroDestino.BackColor = Color.White; }
            if (txtPedagio.Text == "")
            {
                txtPedagio.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Pedágio");
            }
            else { txtPedagio.BackColor = Color.White; }
            if (txtCidadeDestino.Text == "")
            {
                txtCidadeDestino.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Cidade de Destino");
            }
            else { txtCidadeDestino.BackColor = Color.White; }
            if (txtCidadeOrigem.Text == "")
            {
                txtCidadeOrigem.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Cidade de Origem");
            }
            else { txtCidadeOrigem.BackColor = Color.White; }
            if (txtEstadoDestino.Text == "")
            {
                txtEstadoDestino.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Estado de Destino");
            }
            else { txtEstadoDestino.BackColor = Color.White; }
            if (txtEstadoOrigem.Text == "")
            {
                txtEstadoOrigem.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Estado de Origem");
            }
            else { txtEstadoOrigem.BackColor = Color.White; }
            if (cbMotorista.Text == "")
            {
                cbMotorista.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Motorista");
            }
            else { cbMotorista.BackColor = Color.White; }
            if (cbVeiculo.Text == "")
            {
                cbVeiculo.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Veiculo");
            }
            else { cbVeiculo.BackColor = Color.White; }

            Ctrl_Viagem ctrlViagem = new Ctrl_Viagem();

            try
            {
                bool cadViagem = ctrlViagem.CadViagem(txtLogradouroOrigem.Text, Convert.ToInt32(txtNumeroOrigem.Text), txtCepOrigem.Text, txtEstadoOrigem.Text, txtCidadeOrigem.Text, txtLogradouroDestino.Text
                    , Convert.ToInt32(txtNumeroDestino.Text), txtNumeroDestino.Text, txtEstadoDestino.Text, txtCidadeDestino.Text, Convert.ToInt32(cbMotorista.Text), Convert.ToInt32(cbVeiculo.Text), Convert.ToInt32(txtPedagio));
                if (cadViagem)
                {
                    MessageBox.Show("Viagem cadastrada com sucesso!");
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
                    MessageBox.Show("Não foi possível cadastrar a Viagem");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ops, algo deu errado! Contate o suporte. Erro: " + err.Message);
            }


        }
    }
}
