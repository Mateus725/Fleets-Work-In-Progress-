using Business;
using Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fleets.Forms
{
    public partial class AlterarEmpresa : Form
    {
        public AlterarEmpresa(Empresa Empresa)
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
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Ctrl_Empresa ctrlEmpresa = new Ctrl_Empresa();
            
        }
    }
}
