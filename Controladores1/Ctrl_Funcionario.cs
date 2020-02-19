using Business;
using Models;
using System;


namespace Controladores
{
    public class Ctrl_Funcionario
    {
        Mdl_Funcionario mdlFunc = new Mdl_Funcionario();

        public bool CadastroFuncionario(string Funcao, string Nome, DateTime DataNascimento, string RG, string CPF,
            char Sexo, string EstadoCivil, string CTPS, string Email, string Telefone, string Logradouro, int Numero,
            string CEP, string Estado, string Login, string Senha, int CodEmpresa)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                funcionario.cargo = Funcao;
                funcionario.nome = Nome;
                funcionario.dataNascimento = DataNascimento.Date;
                funcionario.RG = RG;
                funcionario.CPF = CPF;
                funcionario.sexo = Sexo;
                funcionario.estadoCivil = EstadoCivil;
                funcionario.CTPS = CTPS;
                funcionario.email = Email;
                funcionario.telefone = Telefone;
                funcionario.endereco = Logradouro;
                funcionario.numero = Numero;
                funcionario.cep = CEP;
                funcionario.estado = Estado;
                funcionario.login = Login;
                funcionario.senha = Senha;
                funcionario.CodEmpresa = CodEmpresa;
                
                
                mdlFunc.CadastrarFuncionario(funcionario);

                return true;

            }
            catch
            {

                return false;

            }

        }

        public bool CadastroMotorista(string Funcao, string Nome, DateTime DataNascimento, string RG, string CPF,
            char Sexo, string EstadoCivil, string CTPS, string Email, string Telefone, string Logradouro, int Numero,
            string CEP, string Estado, string Login, string Senha, string CNH, string Habilitacao, string TipoSanguineo, string Deficiencia, int CodEmpresa)
        {
            try
            {
                Motorista motorista = new Motorista();
                motorista.cargo = Funcao;
                motorista.nome = Nome;
                motorista.dataNascimento = DataNascimento.Date;
                motorista.RG = RG;
                motorista.CPF = CPF;
                motorista.sexo = Sexo;
                motorista.estadoCivil = EstadoCivil;
                motorista.CTPS = CTPS;
                motorista.email = Email;
                motorista.telefone = Telefone;
                motorista.endereco = Logradouro;
                motorista.numero = Numero;
                motorista.cep = CEP;
                motorista.estado = Estado;
                motorista.login = Login;
                motorista.senha = Senha;

                motorista.CNH = CNH;
                motorista.tipoSanguinio = TipoSanguineo;
                motorista.habilitacao = Habilitacao;
                motorista.deficiencia = Deficiencia;
                motorista.CodEmpresa = CodEmpresa;

                
                mdlFunc.CadastrarMotorista(motorista);

                return true;

            }
            catch
            {

                return false;

            }

        }
        public bool AtualizarFuncionario(int CodigoUsuario, string Nome, DateTime DataNascimento, string RG, string CPF,
            char Sexo, string EstadoCivil, string CTPS, string Email, string Telefone, string Logradouro, int Numero,
            string CEP, string Estado, string Cargo)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                funcionario.nome = Nome;
                funcionario.dataNascimento = DataNascimento.Date;
                funcionario.RG = RG;
                funcionario.CPF = CPF;
                funcionario.sexo = Sexo;
                funcionario.estadoCivil = EstadoCivil;
                funcionario.CTPS = CTPS;
                funcionario.email = Email;
                funcionario.telefone = Telefone;
                funcionario.endereco = Logradouro;
                funcionario.numero = Numero;
                funcionario.cep = CEP;
                funcionario.estado = Estado;
                funcionario.cargo = Cargo;
                
                funcionario.CodFuncionario = CodigoUsuario;

                
                mdlFunc.AtualizarFuncionario(funcionario, CodigoUsuario);

                return true;

            }
            catch
            {

                return false;

            }
        }

        public bool InativarFuncionario(string CPF)
        {
            try
            {
                Mdl_Funcionario func = new Mdl_Funcionario();
                func.InativarFuncionario(CPF);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Funcionario CarregaFuncionario(string CodFuncionario)
        {
            Funcionario func = mdlFunc.carregaFuncionario(Convert.ToInt32(CodFuncionario));
            return func;
        }

    }
}
