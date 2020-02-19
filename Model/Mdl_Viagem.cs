using System;
using System.Collections.Generic;
using System.Text;
using BDClasses;
using Business;


namespace Models
{
    public class Mdl_Viagem
    {
        public bool CadastroViagens(Viagem Viagem)
        {
            try
            {
                Ctrl_BD Cad = new Ctrl_BD();
                Cad.Cadastro("");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateViagem(Viagem Viagem)
        {
            try
            {
                Ctrl_BD Update = new Ctrl_BD();
                Update.Update("");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InativarViagem(Viagem Viagem)
        {
            try
            {
                Ctrl_BD Inativar = new Ctrl_BD();
                Inativar.Excluir("");
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
