using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Veiculo
    {

        public Frota Frota { get; set; }

        public string renavam { get; set; }


        public string placa { get; set; }


        public string marca { get; set; }


        public DateTime ano { get; set; }


        public string cor { get; set; }

        public string modelo { get; set; }

        public float kilometragem { get; set; }


        public string combustivel { get; set; }


        public string categoria { get; set; }


        public bool seguro { get; set; }


        public bool adaptado { get; set; }


        public int infracoes { get; set; }


        public string COD_Veiculo { get; set; }

    }
}
