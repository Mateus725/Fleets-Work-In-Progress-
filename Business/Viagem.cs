using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Viagem
    { 

        public string LogradouroOrigem { get; set; }

        public int numeroOrigem { get; set; }

        public string estadoOrigem { get; set; }

        public string cidadeOrigem { get; set; }

        public string LogradouroDestino { get; set; }

        public int numeroDestino { get; set; }

        public string estadoDestino { get; set; }

        public string cidadeDestino { get; set; }

        public string COD_Viagem { get; set; }



        public string endereco { get; set; }



        public string nomeDestino { get; set; }



        public string motorista { get; set; }



        public string veiculo { get; set; }



        public float distanciaKM { get; set; }



        public double valorPedagio { get; set; }



        public float prevAbastecimento { get; set; }



        public string cepOrigem { get; set; }


        public string cepDestino { get; set; }


        public int multas { get; set; }


        public string observacoes { get; set; }


        public DateTime dataSaida { get; set; }

    }
}
