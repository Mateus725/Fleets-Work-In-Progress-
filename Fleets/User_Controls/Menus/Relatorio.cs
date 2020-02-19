using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fleets.Controls.Menus
{
    public partial class Relatorio : UserControl
    {
        public Relatorio()
        {
            InitializeComponent();

            /*// exibe detalhes
            listRelatorios.View = View.Details;
            // permite ao usuário editar o texto
            listRelatorios.LabelEdit = true;
            // permite ao usuário rearranjar as colunas
            listRelatorios.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            listRelatorios.FullRowSelect = true;
            // Exibe as linhas no ListView
            listRelatorios.GridLines = true;

            // Anexa Subitems no ListView
            listRelatorios.Columns.Add("Código do Funcionario", 200, HorizontalAlignment.Center);
            listRelatorios.Columns.Add("Nome", 200, HorizontalAlignment.Center);
            listRelatorios.Columns.Add("Cargo", 200, HorizontalAlignment.Center);
            listRelatorios.Columns.Add("Telefone", 200, HorizontalAlignment.Center);
            listRelatorios.Columns.Add("Celular", 200, HorizontalAlignment.Center);


            Mdl_Relatorio mdlRelatorio = new Mdl_Relatorio();
            mdlRelatorio.carregaLista(listRelatorios);*/

            gerarRelatorios1.Visible = false;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            gerarRelatorios1.Visible = true;
            gerarRelatorios1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            gerarRelatorios1.Location = this.Location;
            gerarRelatorios1.Dock = DockStyle.Fill;
            gerarRelatorios1.Show();

            if (gerarRelatorios1.Visible == false)
            {
                btnGerarRelatorio_Click(sender, e);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
