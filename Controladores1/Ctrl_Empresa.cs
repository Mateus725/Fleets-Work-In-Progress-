using Business;
using Models;

namespace Controladores
{
    public class Ctrl_Empresa
    {
        Mdl_Empresa mdlEmpresa = new Mdl_Empresa();

        public Empresa retornaEmpresa(string CNPJ)
        {
            try
            {
                Empresa empresa = mdlEmpresa.ConsultarEmpresa(CNPJ);
                return empresa;

                
            }
            catch
            {
                return null;
            }
        }
        
    }
}
