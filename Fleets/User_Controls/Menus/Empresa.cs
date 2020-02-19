using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Fleets.Forms;
using Controladores;

namespace Fleets.Controls
{
    public partial class Empresa : UserControl
    {
        public Empresa()
        {
            InitializeComponent();
            
            /*// exibe detalhes
            listEmpresa.View = View.Details;
            // permite ao usuário editar o texto
            listEmpresa.LabelEdit = true;
            // permite ao usuário rearranjar as colunas
            listEmpresa.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            listEmpresa.FullRowSelect = true;
            // Exibe as linhas no ListView
            listEmpresa.GridLines = true;
            
            // Anexa Subitems no ListView
            listEmpresa.Columns.Add("Código da Empresa", 200, HorizontalAlignment.Center);
            listEmpresa.Columns.Add("Nome Fantasia", 200, HorizontalAlignment.Center);
            listEmpresa.Columns.Add("CNPJ", 200, HorizontalAlignment.Center);
            listEmpresa.Columns.Add("E-Mail", 200, HorizontalAlignment.Center);
            listEmpresa.Columns.Add("Telefone", 100, HorizontalAlignment.Center);
            listEmpresa.Columns.Add("CEP", 100, HorizontalAlignment.Center);


            
            Mdl_Empresa mdlEmpresa = new Mdl_Empresa();
            mdlEmpresa.carregaLista(listEmpresa);*/
            
            

            //cadastroEmpresa1.Visible = false;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        /*private void BtnCadEmpresa_Click(object sender, EventArgs e)
        {
            cadastroEmpresa1.Visible = true;
            cadastroEmpresa1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            cadastroEmpresa1.Location = this.Location;
            cadastroEmpresa1.Dock = DockStyle.Fill;
            cadastroEmpresa1.Show();
            

            if (cadastroEmpresa1.Visible == false)
            {
                
                BtnCadEmpresa_Click(sender, e);
            }
        }
        */
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            //cadastroEmpresa1 = new CadastroEmpresa();
        }

        private void lblAtualizar_Click(object sender, EventArgs e)
        {
            //Mdl_Empresa mdlEmpresa = new Mdl_Empresa();
            //mdlEmpresa.carregaLista(listEmpresa);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            /*if(txtCep.Text == "")
            {
                txtCep.BackColor = Color.LightSalmon;
                MessageBox.Show("Digite o CEP!");
            }
            else
            {
                txtCep.BackColor = Color.White;
            }*/

            if (txtCnpj.Text == "")
            {
                txtCnpj.BackColor = Color.LightSalmon;
                MessageBox.Show("Digite o CNPJ!");
            }
            else
            {
                txtCnpj.BackColor = Color.White;
            }

            /*if (txtEmail.Text == "")
            {
                txtEmail.BackColor = Color.LightSalmon;
                MessageBox.Show("Digite o E-Mail!");
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }*/

            try
            {

                Ctrl_Empresa ctrlEmpresa = new Ctrl_Empresa();
                Business.Empresa empresa = ctrlEmpresa.retornaEmpresa(txtCnpj.Text);
                
                if (empresa == null)
                {
                    MessageBox.Show("Não foi possível localizar a empresa!");

                }
                else
                {

                    AlterarEmpresa alterarEmpresa = new AlterarEmpresa(empresa);
                    alterarEmpresa.Show();

                    //cadastroEmpresa1 = new CadastroEmpresa(empresa);
                    //cadastroEmpresa1 = new CadastroEmpresa(empresa);
                    //cadastroEmpresa1.Visible = true;
                    
                    //cadastroEmpresa1.Visible = true;
                    //cadastroEmpresa1.Size = Screen.PrimaryScreen.WorkingArea.Size;
                    //cadastroEmpresa1.Location = this.Location;
                    //cadastroEmpresa1.Dock = DockStyle.Fill;
                    //cadastroEmpresa1.RetornaEmpresa(empresa);
                    //cadastroEmpresa1.Show();
                    


                    //if (cadastroEmpresa1.Visible == false)
                    //{

                       // btnAlterar_Click(sender, e);
                    //}

                }
            }catch (Exception err)
            {
                MessageBox.Show("Ops! Algo deu errado. Contate o suporte. Erro: " + err.Message);
            }
        }
    }
}
