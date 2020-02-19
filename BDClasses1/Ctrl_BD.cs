using Business;
using System.Data.SqlClient;

namespace BDClasses
{
    public class Ctrl_BD
    {
        public string stringConexao = "Data Source=LAPTOP-A7DPO4RK;Initial Catalog = fleets; Integrated Security = True";
        
      
        public string VerificaLogin(string Login, string Senha)
        {
            SqlConnection con = new SqlConnection(stringConexao);
            try
            {
                string Query = "SELECT Cargo FROM dbo.USUARIO WHERE Login='" + Login + "' AND Senha='" + Senha + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string cargo = dr.GetString(0);
                return cargo;

            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool Cadastro(string Query)
        {
            try
            {
                SqlConnection con = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(string Query)
        {
            try
            {
                SqlConnection con = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Excluir(string Query)
        {
            try
            {
                SqlConnection con = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Empresa ConsultaEmpresa(string Query)
        {
            try
            {
                SqlConnection con = new SqlConnection(stringConexao);
                con.Open();
                //Executa o comando conforme a string passada como parâmetro
                SqlCommand cmd = new SqlCommand(Query, con);

                //DataReader para ler as informações retornadas da consulta de forma organizada
                SqlDataReader dr = cmd.ExecuteReader();

                //Criando um objeto do tipo Empresa que recebe os dados retornados do Banco de Dados
                Empresa empresa = new Empresa();

                //GetString responsável por usar os dados como string, precisa estar na ordem certa, pois os números entre os parenteses servem como "índice"
                empresa.nomeFantasia = dr.GetString(0);
                empresa.razaoSocial = dr.GetString(1);
                empresa.NIRE = dr.GetString(2);
                empresa.CNPJ = dr.GetString(3);
                empresa.login = dr.GetString(5);
                empresa.senha = dr.GetString(6);

                //Fechando a conexão
                con.Close();

                //Retornando o objeto do tipo Empresa já com todos os atributos preenchidos
                return empresa;
            }
            catch
            {
                return null;
            }
        }

        /*public Seguro ConsultarSeguro(string Query)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                Seguro seguro = new Seguro();
                seguro.
            }
        }*/
        
        public Frota ConsultarFrota(string Query)
        {
            try
            {
                SqlConnection con = new SqlConnection(stringConexao);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                Frota frota = new Frota();

                frota.empresa = dr.GetString(0);
                frota.QuantMotoristas = dr.GetInt32(1);
                frota.QuantVeiculos = dr.GetInt32(2);

                con.Close();
                return frota;
            }
            catch
            {
                return null;
            }
        }

        public Viagem ConsultarViagem(string Query)
        {
            try
            {
                SqlConnection con = new SqlConnection(stringConexao);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);

                SqlDataReader dr = cmd.ExecuteReader();

                Viagem viagem = new Viagem();

                viagem.LogradouroOrigem = dr.GetString(0);
                viagem.numeroOrigem = dr.GetInt32(1);
                viagem.cepOrigem = dr.GetString(2);
                viagem.estadoOrigem = dr.GetString(3);
                viagem.cidadeOrigem = dr.GetString(4);

                viagem.LogradouroDestino = dr.GetString(5);
                viagem.numeroDestino = dr.GetInt32(6);
                viagem.cepDestino = dr.GetString(7);
                viagem.estadoDestino = dr.GetString(8);
                viagem.cidadeDestino = dr.GetString(9);

                viagem.pkMotorista = dr.GetInt32(10);
                viagem.pkVeiculo = dr.GetInt32(11);
                viagem.valorPedagio = dr.GetFloat(12);
                con.Close();
                return viagem;
            }
            catch
            {
                return null;
            }
        }

        public Veiculo ConsultarVeiculo(string Query)
        {
            try
            {
                SqlConnection con = new SqlConnection(stringConexao);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                Veiculo veiculo = new Veiculo();
                veiculo.renavam = dr.GetInt32(0);
                veiculo.placa = dr.GetString(1);
                veiculo.ano = dr.GetInt32(2);
                veiculo.marca = dr.GetString(3);
                veiculo.modelo = dr.GetString(4);
                veiculo.categoria = dr.GetString(5);
                veiculo.cor = dr.GetString(6);
                veiculo.kilometragem = dr.GetFloat(7);
                veiculo.combustivel = dr.GetString(8);
                veiculo.seguro = dr.GetString(9);
                veiculo.adaptado = dr.GetString(10);
                veiculo.infracoes = dr.GetInt32(11);

                con.Close();
                return veiculo;

            }
            catch
            {
                return null;
            }
        }

        public Mecanica ConsultarMecanica(string Query)
        {
            try
            {
                SqlConnection con = new SqlConnection(stringConexao);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                Mecanica mecanica = new Mecanica();
                mecanica.RegistroMecanica = dr.GetInt32(0);
                mecanica.Manutencao = dr.GetString(1);
                mecanica.Cep = dr.GetString(2);
                mecanica.Estado = dr.GetString(3);
                mecanica.Cidade = dr.GetString(4);
                mecanica.Logradouro = dr.GetString(5);
                con.Close();
                return mecanica;

            }
            catch
            {

                return null;

            }
        }
    }
}
