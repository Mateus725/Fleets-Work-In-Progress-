using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BDClasses;
using Models;
using Controladores;

namespace Fleets.Controls.Menus
{
    public partial class Veiculos : UserControl
    {
        public Veiculos()
        {
            InitializeComponent();
            // exibe detalhes
            lvVeiculos.View = View.Details;
            // permite ao usuário editar o texto
            lvVeiculos.LabelEdit = true;
            // permite ao usuário rearranjar as colunas
            lvVeiculos.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            lvVeiculos.FullRowSelect = true;
            // Exibe as linhas no ListView
            lvVeiculos.GridLines = true;

            // Anexa Subitems no ListView
            lvVeiculos.Columns.Add("Código Veículo", 50, HorizontalAlignment.Center);
            lvVeiculos.Columns.Add("Marca", 100, HorizontalAlignment.Center);
            lvVeiculos.Columns.Add("Modelo", 100, HorizontalAlignment.Center);
            //lvVeiculos.Columns.Add("Frota", 200, HorizontalAlignment.Left);
            //lvVeiculos.Columns.Add("Categoria", 100, HorizontalAlignment.Left);
            lvVeiculos.Columns.Add("Seguro", 100, HorizontalAlignment.Center);
            lvVeiculos.Columns.Add("Adaptado", 100, HorizontalAlignment.Center);
            
            //lvVeiculos.Columns.Add("Frota", 100, HorizontalAlignment.Left);


            Mdl_Veiculo mdlVeiculos = new Mdl_Veiculo();
            //mdlVeiculos.carregaLista(lvVeiculos);

            cadastroVeiculos1.Visible = false;
            
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void BtnCadVeiculo_Click(object sender, EventArgs e)
        {
            
            cadastroVeiculos1.Visible = true;
            cadastroVeiculos1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            cadastroVeiculos1.Location = this.Location;
            cadastroVeiculos1.Dock = DockStyle.Fill;
            cadastroVeiculos1.Show();
            cadastroVeiculos1 = new Cadastros.CadastroVeiculos();
            
            

            if (cadastroVeiculos1.Visible == false)
            {
                this.Visible = true;
                BtnCadVeiculo_Click(sender, e);
            }
        }

        private void cadastroVeiculos1_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                Ctrl_Veiculo veiculo = new Ctrl_Veiculo();
                veiculo.InativarVeiculo(Convert.ToInt32(txtCodVeiculoExcluir.Text));

            }catch(Exception i)
            {
                MessageBox.Show("Ops! Algo deu errado! Contate o suporte. \nErro: " + i.Message);
            }
        }

        private void lblAtualizar_Click(object sender, EventArgs e)
        {
            Mdl_Veiculo mdlVeiculo = new Mdl_Veiculo();
            //mdlVeiculo.carregaLista(lvVeiculos);
        }

        private void cadastroVeiculos1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
