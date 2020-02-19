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

namespace Fleets.Controls.Menus
{
    public partial class Manutencao : UserControl
    {
        public Manutencao()
        {
            InitializeComponent();
            /*// exibe detalhes
            listManutencao.View = View.Details;
            // permite ao usuário editar o texto
            listManutencao.LabelEdit = true;
            // permite ao usuário rearranjar as colunas
            listManutencao.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            listManutencao.FullRowSelect = true;
            // Exibe as linhas no ListView
            listManutencao.GridLines = true;

            // Anexa Subitems no ListView
            listManutencao.Columns.Add("Código da Manutenção", 200, HorizontalAlignment.Center);
            listManutencao.Columns.Add("Data", 200, HorizontalAlignment.Center);
            listManutencao.Columns.Add("Motivo", 200, HorizontalAlignment.Center);
            listManutencao.Columns.Add("Empresa", 200, HorizontalAlignment.Center);
            listManutencao.Columns.Add("Observação", 200, HorizontalAlignment.Center);
            listManutencao.Columns.Add("Placa", 200, HorizontalAlignment.Center);
            
            Mdl_Manutencao mdlManutencao = new Mdl_Manutencao();
            mdlManutencao.carregaLista(listManutencao);*/


            cadastroManutencao1.Visible = false;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCadManutencao_Click(object sender, EventArgs e)
        {
            cadastroManutencao1.Visible = true;
            cadastroManutencao1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            cadastroManutencao1.Location = this.Location;
            cadastroManutencao1.Dock = DockStyle.Fill;
            cadastroManutencao1.Show();

            if (cadastroManutencao1.Visible == false)
            {
                btnCadManutencao_Click(sender, e);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
