using System;
using System.Windows.Forms;

namespace Fleets
{
    public partial class Viagens : UserControl
    {
        public Viagens()
        {
            InitializeComponent();
            /*// exibe detalhes
            listViagens.View = View.Details;
            // permite ao usuário editar o texto
            listViagens.LabelEdit = true;
            // permite ao usuário rearranjar as colunas
            listViagens.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            listViagens.FullRowSelect = true;
            // Exibe as linhas no ListView
            listViagens.GridLines = true;

            // Anexa Subitems no ListView
            listViagens.Columns.Add("Código da Viagem", 200, HorizontalAlignment.Center);
            listViagens.Columns.Add("", 200, HorizontalAlignment.Center);
            listViagens.Columns.Add("", 200, HorizontalAlignment.Center);
            listViagens.Columns.Add("", 200, HorizontalAlignment.Center);
            listViagens.Columns.Add("", 200, HorizontalAlignment.Center);


            Mdl_Viagem mdlViagem = new Mdl_Viagem();
            mdlViagem.carregaLista(listViagens);*/

            cadastroViagens1.Visible = false;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnCadViagem_Click(object sender, EventArgs e)
        {
            cadastroViagens1.Visible = true;
            cadastroViagens1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            cadastroViagens1.Location = this.Location;
            cadastroViagens1.Dock = DockStyle.Fill;
            cadastroViagens1.Show();

            if (cadastroViagens1.Visible == false)
            {
                BtnCadViagem_Click(sender, e);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
