using Business;
using Models;
using System;

namespace Controladores
{
    public class Ctrl_Seguro
    {

        public bool CadSeguros(string Seguradora, DateTime Vigencia, string Cobertura)
        {
            //Mdl_Seguro mdlSeguro = new Mdl_Seguro(); Não sei se deveria apagar essa linha, então deixei como comentário
            try
            {
                Seguro seguro = new Seguro();
                seguro.seguradora = Seguradora;
                seguro.vigencia = Vigencia;
                seguro.cobertura = Cobertura;

                Mdl_Seguro mdlSeguro = new Mdl_Seguro();
                mdlSeguro.CadastrarSeguro(seguro);
                // mdlSeguro.CadastrarSeguro(seguro); Não sei se deveria apagar essa linha, então deixei como comentário
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateSeguro(Seguro seguro)
        {
            Mdl_Seguro Seguro = new Mdl_Seguro();
            try
            {
                Seguro.AtualizarSeguro(seguro);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InativarSeguro(int CodSeguro)
        {
            Mdl_Seguro seguro = new Mdl_Seguro();
            try
            {
                seguro.InativarSeguro(CodSeguro);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /*public bool ConsultarSeguro(Seguro Seguro)
        {
            Mdl_Seguro seguro = new Mdl_Seguro();
            try
            {
                seguro.
            }
        }*/
    }
}
