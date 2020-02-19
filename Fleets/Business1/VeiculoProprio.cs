
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
