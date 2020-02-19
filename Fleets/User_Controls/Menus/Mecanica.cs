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
    public partial class Mecanica : UserControl
    {
        public Mecanica()
        {
            InitializeComponent();
            
            // exibe detalhes
            listMecanicas.View = View.Details;
            // permite ao usuário editar o texto
            listMecanicas.LabelEdit = true;
            // permite ao usuário rearranjar as colunas
            listMecanicas.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            listMecanicas.FullRowSelect = true;
            // Exibe as linhas no ListView
            listMecanicas.GridLines = true;

            // Anexa Subitems no ListView
            listMecanicas.Columns.Add("Código da Mecânica", 50, HorizontalAlignment.Center);
            listMecanicas.Columns.Add("Registro", 100, HorizontalAlignment.Center);
            //listMecanicas.Columns.Add("Endereco", 100, HorizontalAlignment.Center);
            //lvVeiculos.Columns.Add("Frota", 200, HorizontalAlignment.Left);
            //lvVeiculos.Columns.Add("Categoria", 100, HorizontalAlignment.Left);
            //listMecanicas.Columns.Add("Telefone", 100, HorizontalAlignment.Center);
            //listMecanicas.Columns.Add("E-Mail", 100, HorizontalAlignment.Center);
            //listMecanicas.Columns.Add("CEP", 100, HorizontalAlignment.Center);

            //lvVeiculos.Columns.Add("Frota", 100, HorizontalAlignment.Left);


            Mdl_Mecanica mdlMecanica = new Mdl_Mecanica();
            //mdlMecanica.carregaLista(listMecanicas);

            cadastroMecanica1.Visible = false;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCadMecanica_Click(object sender, EventArgs e)
        {
            cadastroMecanica1.Visible = true;
            cadastroMecanica1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            cadastroMecanica1.Location = this.Location;
            cadastroMecanica1.Dock = DockStyle.Fill;
            cadastroMecanica1.Show();

            if (cadastroMecanica1.Visible == false)
            {
                btnCadMecanica_Click(sender, e);
            }
        }

        private void lblAtualizar_Click(object sender, EventArgs e)
        {
            //Mdl_Mecanica mdlMecanica = new Mdl_Mecanica();
            //mdlMecanica.carregaLista(listMecanicas);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
