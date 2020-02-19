using Business;

using Models;

namespace Controls
{
    public class Ctrl_Viagem
    {

        public bool CadViagem(string LogradouroOrigem, int NumeroOrigem, string CEPOrigem, string EstadoOrigem,
            string CidadeOrigem, string LogradouroDestino, int NumeroDestino, string CEPDestino, string EstadoDestino,
            string CidadeDestino, int PkMotorista, int PkVeiculo, double Pedagio)
        {
            Mdl_Viagem Viagem = new Mdl_Viagem();
            try
            {
                Viagem viagem = new Viagem();
                viagem.LogradouroOrigem = LogradouroOrigem;
                viagem.numeroOrigem = NumeroOrigem;
                viagem.cepOrigem = CEPOrigem;
                viagem.LogradouroDestino = LogradouroDestino;
                viagem.numeroDestino = NumeroDestino;
                viagem.cepDestino = CEPDestino;
                viagem.estadoDestino = EstadoDestino;
                viagem.cidadeDestino = CidadeDestino;
                viagem.pkMotorista = PkMotorista;
                viagem.pkVeiculo = PkVeiculo;
                viagem.valorPedagio = Pedagio;

                Mdl_Viagem mdlViagem = new Mdl_Viagem();
                mdlViagem.CadastroViagens(viagem);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateViagem(Viagem viagem)
        {
            Mdl_Viagem Viagem = new Mdl_Viagem();
            try
            {
                Viagem.UpdateViagem(viagem);
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool InativarViagem(string Cod)
        {
            Mdl_Viagem Viagem = new Mdl_Viagem();
            try
            {
                Viagem.ExcluirViagem(Cod);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
