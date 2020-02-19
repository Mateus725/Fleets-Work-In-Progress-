using System;

namespace Business
{
    public class Funcionario
    {
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string departamento { get; set; }
        public string deficiencia { get; set; }
        public string cargo { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public char sexo { get; set; }
        public string estadoCivil { get; set; }
        public string CTPS { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int CodFuncionario { get; set; }
        public int CodEmpresa { get; set; }
        public override string ToString()
        {
            return "dd-MM-yyyy";
        }

        public Funcionario(string nome, DateTime dataNascimento, string email, string departamento, string deficiencia, string cargo, string endereco, char sexo, string estadoCivil, string cTPS, string rG, string cPF, string login, string senha)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.email = email;
            this.departamento = departamento;
            this.deficiencia = deficiencia;
            this.cargo = cargo;
            this.endereco = endereco;
            this.sexo = sexo;
            this.estadoCivil = estadoCivil;
            this.CTPS = cTPS;
            this.RG = rG;
            this.CPF = cPF;
            this.login = login;
            this.senha = senha;
        }

        public Funcionario(string nome, DateTime dataNascimento, string departamento, string deficiencia, string cargo, string endereco, char sexo, string estadoCivil, string cTPS, string rG, string cPF, string login, string senha)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.departamento = departamento;
            this.deficiencia = deficiencia;
            this.cargo = cargo;
            this.endereco = endereco;
            this.sexo = sexo;
            this.estadoCivil = estadoCivil;
            CTPS = cTPS;
            RG = rG;
            CPF = cPF;
            this.login = login;
            this.senha = senha;
        }

        public Funcionario()
        {
        }
    }

}
