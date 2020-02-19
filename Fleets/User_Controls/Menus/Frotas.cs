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
using Models;

namespace Fleets.Controls.Menus
{
    public partial class Frotas : UserControl
    {
        public Frotas()
        {
            InitializeComponent();

            // exibe detalhes
            listFrotas.View = View.Details;
            // permite ao usuário editar o texto
            listFrotas.LabelEdit = true;
            // permite ao usuário rearranjar as colunas
            listFrotas.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            listFrotas.FullRowSelect = true;
            // Exibe as linhas no ListView
            listFrotas.GridLines = true;

            // Anexa Subitems no ListView
            listFrotas.Columns.Add("Código da Frota", 200, HorizontalAlignment.Center);
            listFrotas.Columns.Add("Empresa", 200, HorizontalAlignment.Center);
            listFrotas.Columns.Add("Nº de Veiculos", 200, HorizontalAlignment.Center);    
            listFrotas.Columns.Add("Nº de Motoristas", 200, HorizontalAlignment.Center);
            

             Mdl_Frota mdlEmpresa = new Mdl_Frota();
             mdlEmpresa.carregaLista(listFrotas);

             cadastroFrotas1.Visible = false;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCadFrota_Click(object sender, EventArgs e)
        {
            cadastroFrotas1.Visible = true;
            cadastroFrotas1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            cadastroFrotas1.Location = this.Location;
            cadastroFrotas1.Dock = DockStyle.Fill;
            cadastroFrotas1.Show();

            if (cadastroFrotas1.Visible == false)
            {
                btnCadFrota_Click(sender, e);
            }
        }

        private void Frotas_Load(object sender, EventArgs e)
        {

        }

        private void Frotas_Load_1(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Ctrl_Frota ctrlFrota = new Ctrl_Frota();

            if (txtCodFrota.Text != "" || txtCodFrota.Text != null)
            {
                if (MessageBox.Show("Deseja exlcuir permanentemente a Frota?", "Aviso!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (ctrlFrota.ExcluirFrota(Convert.ToInt32(txtCodFrota.Text)))
                    {
                        txtCodFrota.Text = "";
                        MessageBox.Show("Frota Excluída com Sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Exlcuir! Insira um código válido!");
                    }

                }
                else
                {
                    MessageBox.Show("Insira o Código da Frota!");
                }
            }

        }
    }
}
