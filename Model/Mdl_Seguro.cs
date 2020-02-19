using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Business;
using BDClasses;

namespace Models
{
    public class Mdl_Seguro
    {
        Ctrl_BD conexao = new Ctrl_BD();

        public bool CadastrarSeguro(Seguro Seguro)
        {
            try
            {
                Ctrl_BD cadSeguro = new Ctrl_BD();
                cadSeguro.Cadastro("");
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool AtualizarSeguro(Seguro Seguro)
        {
            try
            {
                Ctrl_BD cadSeguro = new Ctrl_BD();
                cadSeguro.Update("");
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool InativarSeguro(Seguro Seguro)
        {
            try
            {
                Ctrl_BD cadSeguro = new Ctrl_BD();
                cadSeguro.Cadastro("");
                return true;

            }
            catch
            {
                return false;
            }
        }

       
    }
}
