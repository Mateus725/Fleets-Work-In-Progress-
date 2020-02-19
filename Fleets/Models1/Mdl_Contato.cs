using System.Data.SqlClient;
using BDClasses;
using Business;

namespace Models
{
    class Mdl_Contato
    {
        Ctrl_BD conexao = new Ctrl_BD();

        //public Ctrl_BD Conexao { get => conexao; set => conexao = value; }

        public bool CadastrarContato(Contatos Contato)
        {
            try
            {
                SqlConnection con = new SqlConnection("");
                string query = "INSERT INTO Contatos (Email, Telefone, Celular) VALUES (" +
                    Contato.email + ", " + Contato.telefoneFixo + ", " + Contato.telefoneCel + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool InativarEmail(string Email)
        {
            try
            {
                SqlConnection con = new SqlConnection("");
                string query = "DELETE Email FROM Contatos WHERE Email==" + Email;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InativarTelefone(string Telefone)
        {
            try
            {
                SqlConnection con = new SqlConnection("");
                string query = "DELETE Telefone FROM Contatos WHERE Telefone==" + Telefone;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InativarCelular(string Celular)
        {
            try
            {
                SqlConnection con = new SqlConnection("");
                string query = "DELETE Celular FROM Contatos WHERE Celular==" + Celular;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Contatos BuscarContatos(string NomeEmpresa)
        {
            try
            {
                //Buscando o Código da empresa para usar a chave estrangeira
                SqlConnection con = new SqlConnection("");
                string buscaEmpresa = "SELECT Cod_Empresa FROM Empresa WHERE NomeFantasia ==" + NomeEmpresa;
                SqlCommand cmd = new SqlCommand(buscaEmpresa, con);
                SqlDataReader dr = cmd.ExecuteReader();

                //Buscando os contatos a partir do Cod_Empresa
                string query = "SELECT * from Contatos WHERE Cod_Empresa==" + dr.GetString(0);
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                //Atribuindo os contatos de acordo com o retorno do Select
                Contatos contatoRetornado = new Contatos();
                contatoRetornado.email.Add(dr.GetString(1));
                contatoRetornado.telefoneFixo.Add(dr.GetString(2));
                contatoRetornado.telefoneCel.Add(dr.GetString(3));

                con.Close();

                return contatoRetornado;
            }
            catch
            {
                return null;
            }
        }

        public bool AlterarEmail(string EmailAntigo, string EmailNovo)
        {
            try
            {
                SqlConnection con = new SqlConnection("");
                string query = "UPDATE Contatos SET Email = " + EmailNovo + "WHERE Email == " + EmailAntigo;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AlterarTelefone(string TelefoneAntigo, string TelefoneNovo)
        {
            try
            {
                SqlConnection con = new SqlConnection("");
                string query = "UPDATE Contatos SET Telefone = " + TelefoneNovo + "WHERE Telefone == " + TelefoneAntigo;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AlterarCelular(string CelularAntigo, string CelularNovo)
        {
            try
            {
                SqlConnection con = new SqlConnection("");
                string query = "UPDATE Contatos SET Celular = " + CelularNovo + "WHERE Celular == " + CelularAntigo;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
