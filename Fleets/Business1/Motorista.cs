namespace Business
{
    public class Motorista : Funcionario
    {
        public bool PCD { get; set; }
        public int infracoes { get; set; }
        public int pontosCNH { get; set; }
        public bool disponivel { get; set; }
        public string CNH { get; set; }
        public string tipoSanguinio { get; set; }
        public string habilitacao { get; set; }

    }
}
