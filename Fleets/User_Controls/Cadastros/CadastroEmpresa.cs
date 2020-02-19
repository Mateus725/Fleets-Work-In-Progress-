using System;
using System.Windows.Forms;
using Business;

namespace Fleets
{
    public partial class CadastroEmpresa : UserControl
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        public bool RetornaEmpresa(Empresa Empresa)
        {
            try
            {

                this.txtNomeEmpresa.Text = Empresa.nomeFantasia;
                this.txtRazaoSocial.Text = Empresa.razaoSocial;
                this.txtCNPJ.Text = Empresa.CNPJ;
                this.txtNIRE.Text = Empresa.NIRE;
                this.txtLogradouro.Text = Empresa.logradouro;
                this.txtNumero.Text = Convert.ToString(Empresa.numero);
                this.txtCEP.Text = Empresa.CEP;
                this.cbEstado.Text = Empresa.estado;
                this.cbCidade.Text = Empresa.cidade;
                this.txtTelefone.Text = Empresa.telefone;

                this.txtCelular.Text = Empresa.celular;
                this.txtEmail.Text = Empresa.email;
                return true;

            }
            catch
            {
                return false;
            }
        }

        public CadastroEmpresa(Empresa Empresa)
        {
            InitializeComponent();
            this.txtNomeEmpresa.Text = Empresa.nomeFantasia;
            this.txtRazaoSocial.Text = Empresa.razaoSocial;
            this.txtCNPJ.Text = Empresa.CNPJ;
            this.txtNIRE.Text = Empresa.NIRE;
            this.txtLogradouro.Text = Empresa.logradouro;
            this.txtNumero.Text = Convert.ToString(Empresa.numero);
            this.txtCEP.Text = Empresa.CEP;
            this.cbEstado.Text = Empresa.estado;
            this.cbCidade.Text = Empresa.cidade;
            this.txtTelefone.Text = Empresa.telefone;
            
            this.txtCelular.Text = Empresa.celular;
            this.txtEmail.Text = Empresa.email;

            //this.Visible = true;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.Location = this.Location;
            //this.Dock = DockStyle.Fill;
            //this.Show();
            
        }

        private void lblContato_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblCelular_Click(object sender, EventArgs e)
        {

        }

        private void txtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblCEP_Click(object sender, EventArgs e)
        {

        }

        private void lblRua_Click(object sender, EventArgs e)
        {

        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNIRE_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblNIRE_Click(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblCNPJ_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNomeEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void lblRazaoSocial_Click(object sender, EventArgs e)
        {

        }

        private void txtRazaoSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDadosEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void imgFleets_Click(object sender, EventArgs e)
        {

        }

        private void lblCadastroEmpresa_Click(object sender, EventArgs e)
        {

        }
    }
}
