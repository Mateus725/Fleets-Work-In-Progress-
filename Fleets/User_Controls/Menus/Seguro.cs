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
    public partial class Seguro : UserControl
    {
        public Seguro()
        {
            InitializeComponent();

            /*// exibe detalhes
            listSeguros.View = View.Details;
            // permite ao usuário editar o texto
            listSeguros.LabelEdit = true;
            // permite ao usuário rearranjar as colunas
            listSeguros.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            listSeguros.FullRowSelect = true;
            // Exibe as linhas no ListView
            listSeguros.GridLines = true;

            // Anexa Subitems no ListView
            listSeguros.Columns.Add("Código do Seguro", 200, HorizontalAlignment.Center);
            listSeguros.Columns.Add("Seguradora", 200, HorizontalAlignment.Center);
            listSeguros.Columns.Add("Vigência", 200, HorizontalAlignment.Center);
            listSeguros.Columns.Add("Coberturas", 200, HorizontalAlignment.Center);
            listSeguros.Columns.Add("Sinistros", 200, HorizontalAlignment.Center);


            Mdl_Seguro mdlSeguro = new Mdl_Seguro();
            mdlSeguro.carregaLista(listSeguros);*/

            cadastroSeguro1.Visible = false;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCadSeguro_Click(object sender, EventArgs e)
        {
            cadastroSeguro1.Visible = true;
            cadastroSeguro1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            cadastroSeguro1.Location = this.Location;
            cadastroSeguro1.Dock = DockStyle.Fill;
            cadastroSeguro1.Show();

            if (cadastroSeguro1.Visible == false)
            {
                btnCadSeguro_Click(sender, e);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
