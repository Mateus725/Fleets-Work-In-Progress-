using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class VeiculoProprio : Veiculo
    {

        public string estadoVeiculo { get; private set; }


        public bool manutencaoPreventiva { get; private set; }


        public bool alugado { get; private set; }


        public string localRetirada { get; private set; }


        public Contatos contato { get; private set; }
    }
}
