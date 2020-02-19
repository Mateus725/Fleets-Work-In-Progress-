using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace Business
{
    public class Contatos
    {
        public List<string> telefoneFixo { get; set; }
        public List<string> telefoneCel { get; set; }
        public List<string> telefoneComercial { get; set; }
        public List<string> email { get; set; }

        private string con = "string de conexão com o banco de dados";

        public void IncluirTelFixo(string TelefoneFixo)
        {
            SqlConnection connection = new SqlConnection(con);
            string query = "INSERT INTO tbContatos (Telefone) VALUES (" + TelefoneFixo + ")";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void IncluirTelCel(string TelefoneCelular)
        {
            SqlConnection connection = new SqlConnection(con);
            string query = "INSERT INTO tbContatos (Celular) VALUES (" + TelefoneCelular + ")";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void IncluirEmail(string Email)
        {
            SqlConnection connection = new SqlConnection(con);
            string query = "INSERT INTO tbContatos (Email) VALUES (" + Email + ")";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
