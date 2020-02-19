using System;
using System.Drawing;
using System.Windows.Forms;
using Controladores;
using Models;
using Business;

namespace Fleets.Controls.Menus
{
    public partial class CadastroSeguro : UserControl
    {

        public CadastroSeguro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Ctrl_Seguro cadSeg = new Ctrl_Seguro();

            if (txtVigencia.Text == "")
            {
                txtVigencia.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Vigência");
            }
            else { txtVigencia.BackColor = Color.White; }
            
            if (txtSeguradora.Text == "")
            {
                txtSeguradora.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Seguradora");
            }
            else { txtSeguradora.BackColor = Color.White; }
            if (txtCobertura.Text == "")
            {
                txtCobertura.BackColor = Color.LightSalmon;
                MessageBox.Show("Atenção! Preencha o campo Cobertura");
            }
            else { txtCobertura.BackColor = Color.White; }

            try
            {

                bool cadSeguro = cadSeg.CadSeguros(txtSeguradora.Text, Convert.ToDateTime(txtVigencia.Text).Date, txtCobertura.Text);
                Business.Seguro seguro = new Business.Seguro();
                seguro.cobertura = txtCobertura.Text;
                seguro.seguradora = txtSeguradora.Text;
                seguro.vigencia = Convert.ToDateTime(txtVigencia.Text).Date;
                

                //Ctrl_Seguro ctrlSeguro = new Ctrl_Seguro();
               // bool cadastro = ctrlSeguro.CadSeguros(seguro);

                if(cadSeguro == true)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar! Erro: ");
                    throw new Exception();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar! Erro: " + ex.Message);
            }

        }
    }
}
