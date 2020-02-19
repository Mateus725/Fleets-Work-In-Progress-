using BDClasses;
using Business;
using Models;

namespace Controladores
{
    public class Ctrl_Mecanica
    {
        Ctrl_BD ctrlMecaninca = new Ctrl_BD();


        public bool CadastroMecanica(int RegMecanica, string Manutencao, string Cep, string Estado, string Cidade,
            string Logradouro)
        {
            try
            {
                Mecanica mecanica = new Mecanica();

                mecanica.RegistroMecanica = RegMecanica;
                mecanica.Manutencao = Manutencao;
                mecanica.Cep = Cep;
                mecanica.Estado = Estado;
                mecanica.Cidade = Cidade;
                mecanica.Logradouro = Logradouro;

                
                
                Mdl_Mecanica _Mecanica = new Mdl_Mecanica();
                _Mecanica.CadastroMecanica(mecanica);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InativarMecanica(int CodMecanica)
        {
            try
            {
                Mdl_Mecanica _Mecanica = new Mdl_Mecanica();
                _Mecanica.InativarMecanica(CodMecanica);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AtualizarMecanica()
        {
            try
            {
                Mdl_Mecanica _Mecanica = new Mdl_Mecanica();
                _Mecanica.AtualizarMecanica();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ConsultarMecanica()
        {
            try
            {
                Mdl_Mecanica _Mecanica = new Mdl_Mecanica();
                _Mecanica.ConsultarMecanica();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Ctrl_Mecanica()
        {

        }
    }
}

