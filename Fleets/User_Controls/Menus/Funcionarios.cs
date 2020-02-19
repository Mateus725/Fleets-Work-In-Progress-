using Business;
using Controladores;
using Fleets.Forms;
using Models;
using System;
using System.Windows.Forms;

namespace Fleets.Controls.Menus
{
    public partial class Funcionarios : UserControl
    {
        string NivelAcesso;

        public Funcionarios()
        {
            InitializeComponent();
            
            // exibe detalhes
            listFuncionario.View = View.Details;
            // permite ao usuário editar o texto
            listFuncionario.LabelEdit = true;
            // permite ao usuário rearranjar as colunas
            listFuncionario.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            listFuncionario.FullRowSelect = true;
            // Exibe as linhas no ListView
            listFuncionario.GridLines = true;

            // Anexa Subitems no ListView
            listFuncionario.Columns.Add("Código do Funcionario", 200, HorizontalAlignment.Center);
            listFuncionario.Columns.Add("Nome", 200, HorizontalAlignment.Center);
            listFuncionario.Columns.Add("Cargo", 200, HorizontalAlignment.Center);
            listFuncionario.Columns.Add("Telefone", 200, HorizontalAlignment.Center);
            listFuncionario.Columns.Add("Celular", 200, HorizontalAlignment.Center);
            

            Mdl_Funcionario mdlFuncionario = new Mdl_Funcionario();
            mdlFuncionario.carregaLista(listFuncionario);

            cadastroFuncionario1.Visible = false;
        }

        public Funcionarios(String NivelAcesso)
        {
            InitializeComponent();
            this.NivelAcesso = NivelAcesso;
            // exibe detalhes
            listFuncionario.View = View.Details;
            // permite ao usuário editar o texto
            listFuncionario.LabelEdit = true;
            // permite ao usuário rearranjar as colunas
            listFuncionario.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            listFuncionario.FullRowSelect = true;
            // Exibe as linhas no ListView
            listFuncionario.GridLines = true;

            // Anexa Subitems no ListView
            listFuncionario.Columns.Add("Código do Funcionario", 200, HorizontalAlignment.Center);
            listFuncionario.Columns.Add("Nome", 200, HorizontalAlignment.Center);
            listFuncionario.Columns.Add("Cargo", 200, HorizontalAlignment.Center);
            listFuncionario.Columns.Add("Telefone", 200, HorizontalAlignment.Center);
            listFuncionario.Columns.Add("Celular", 200, HorizontalAlignment.Center);


            Mdl_Funcionario mdlFuncionario = new Mdl_Funcionario();
            mdlFuncionario.carregaLista(listFuncionario);

            cadastroFuncionario1.Visible = false;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            cadastroFuncionario1.Visible = true;
            cadastroFuncionario1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            cadastroFuncionario1.Location = this.Location;
            cadastroFuncionario1.Dock = DockStyle.Fill;
            cadastroFuncionario1.Show();

            if (cadastroFuncionario1.Visible == false)
            {
                btnCadFuncionario_Click(sender, e);
            }
        }

        private void lblAtualizar_Click(object sender, EventArgs e)
        {
            Mdl_Funcionario mdlFuncionario = new Mdl_Funcionario();
            mdlFuncionario.carregaLista(listFuncionario);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja exlcuir permanentemente o funcionário?", "Aviso!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {

                    Ctrl_Funcionario func = new Ctrl_Funcionario();
                    bool inativar = func.InativarFuncionario(txtCodFuncExcluir.Text);

                    if (inativar)
                    {
                        MessageBox.Show("Funcionário excluído com sucesso!");
                        txtCodFuncExcluir.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível Excluir o funcionário!");
                    }

                }
                catch(Exception err)
                {
                    MessageBox.Show("Ops, algo deu errado! Contate o suporte. Erro: " + err.Message);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            Ctrl_Funcionario func = new Ctrl_Funcionario();
            Funcionario funcionario = func.CarregaFuncionario(this.txtCodFuncAlterar.Text);


            AlterarFuncionario alterar = new AlterarFuncionario(funcionario, Convert.ToInt32(this.txtCodFuncAlterar.Text));
            alterar.Show();

        }
    }
}
