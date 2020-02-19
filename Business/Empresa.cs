using System;
using System.Collections.Generic;


namespace Business
{
    public class Empresa
    {
        public string endereco { get; set; }
        public string razaoSocial { get; set; }
        public int CNPJ { get; set; }
        public List<Contatos> contatos { get; set; }
        public string nomeFantasia { get; set; }
        public string ramoDeAtividade { get; set; }
        public int NIRE { get; set; }
        public List<Funcionario> funcionarios { get; private set; }
        public List<Motorista> motoristas { get; private set; }
        public List<Gerente>  gerentes { get; private set; }

        public string login { get; set; }
        public string senha { get; set; }


        public void AlterarInformacoes(string Endereco, Contatos[] Contatos, string NomeFantasia,
            Funcionario Administrador)
        {
        }

    }
}
