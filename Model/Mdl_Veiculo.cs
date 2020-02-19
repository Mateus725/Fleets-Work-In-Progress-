using System;
using BDClasses;
using Business;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Mdl_Veiculo
    {
        Ctrl_BD ctrlVeiculo = new Ctrl_BD();

        Veiculo veiculo;

        public Mdl_Veiculo(Veiculo veiculo)
        {
            this.veiculo = veiculo;
        }


        public bool CadastroVeiculo()
        {
            try
            {

                ctrlVeiculo.Cadastro("");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InativarVeiculo()
        {
            try
            {
                ctrlVeiculo.Excluir("");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AtualizarVeiculo()
        {
            try
            {
                ctrlVeiculo.Update("");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ConsultarVeiculo()
        {
            try
            {
                ctrlVeiculo.ConsultarVeiculo("");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
