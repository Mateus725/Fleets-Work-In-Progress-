using BDClasses;
using Business;
using Models;

namespace Controladores
{
    public class Ctrl_Veiculo
    {

        Ctrl_BD ctrlVeiculo = new Ctrl_BD();

        
        public bool CadastroVeiculo(int Renavam, string Placa, int Ano, string Marca, string Modelo,
            string Categoria, string Cor, double Kilometragem, string Combustivel, bool Seguro, bool Adaptado, int Infracoes, 
            string Frotas)
        {
            try
            {
                Veiculo veiculo = new Veiculo();
                veiculo.renavam = Renavam;
                veiculo.placa = Placa;
                veiculo.ano = Ano;
                veiculo.marca = Marca;
                veiculo.modelo = Modelo;
                veiculo.categoria = Categoria;
                veiculo.cor = Cor;
                veiculo.kilometragem = Kilometragem;
                veiculo.combustivel = Combustivel;
                //veiculo.seguro = Seguro;
                //veiculo.adaptado = Adaptado;                            
                veiculo.infracoes = Infracoes;
                veiculo.frotas = Frotas;


                if(Seguro == true)
                {
                    veiculo.seguro = "Sim";
                }
                else
                {
                    veiculo.seguro = "Não";
                }

                if (Adaptado == true)
                {
                    veiculo.adaptado = "Sim";
                }
                else
                {
                    veiculo.adaptado = "Não";
                }

                Mdl_Veiculo _Veiculo = new Mdl_Veiculo();
                _Veiculo.CadastroVeiculo(veiculo);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InativarVeiculo(int CodVeiculo)
        {
            try
            {
                Mdl_Veiculo _Veiculo = new Mdl_Veiculo();
                
                _Veiculo.InativarVeiculo(CodVeiculo);
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
                Mdl_Veiculo _Veiculo = new Mdl_Veiculo();
                _Veiculo.AtualizarVeiculo();
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
                Mdl_Veiculo _Veiculo = new Mdl_Veiculo();
                _Veiculo.ConsultarVeiculo();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Ctrl_Veiculo()
        {
            
        }
    }

}
