using Business;
using Models;

namespace Controladores
{
    public class Ctrl_Frota
    {

        public bool CadFrota(string Empresa, string NomeFrota, int QuantVeiculos, int QuantMotoristas)
        {
            try
            {
                Frota frota = new Frota();
                frota.empresa = Empresa;
                frota.nomeFrota = NomeFrota;
                frota.QuantVeiculos = QuantVeiculos;
                frota.QuantMotoristas = QuantMotoristas;

                Mdl_Frota mdlFrota = new Mdl_Frota();
                mdlFrota.CadastrarFrota(frota);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ExcluirFrota(int CodFrota)
        {
            try
            {
                Mdl_Frota mdlFrota = new Mdl_Frota();
                return mdlFrota.ExcluirFrota(CodFrota);

            }
            catch
            {
                return false;
            }
        }
    }
}
