using Business;
using System;
using System.Data.SqlClient;

using BDClasses;

namespace Models
{
    public class Mdl_Empresa
    {
        Ctrl_BD conexao = new Ctrl_BD();

        public bool CadastrarEmpresa(Empresa Empresa)
        {
            try
            {

                SqlConnection con = new SqlConnection(conexao.con.ToString());
                string query = "INSERT INTO Empresa (NomeFantasia, RazaoSocial, NIRE, CNPJ, Login_Empresa, Senha_Empresa) VALUES ("
                    + Empresa.nomeFantasia + ", " + Empresa.razaoSocial + ", " + Empresa.NIRE + ", " + Empresa.CNPJ + ", " + Empresa.login + ", " + Empresa.senha + ")";
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

        public Empresa ConsultarEmpresa(string NomeFantasia)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexao.con.ToString());
                string query = "SELECT * from Empresa WHERE NomeFantasia == " + NomeFantasia;
                SqlCommand cmd = new SqlCommand(query, con);          
                SqlDataReader dr = cmd.ExecuteReader();
                Empresa empresa = new Empresa();

                empresa.nomeFantasia = dr.GetString(0);
                empresa.razaoSocial = dr.GetString(1);
                empresa.NIRE = dr.GetInt32(2);
                empresa.CNPJ = dr.GetInt32(3);
                empresa.login = dr.GetString(5);
                empresa.senha = dr.GetString(6);
                con.Close();
                return empresa;

            }
            catch
            {
                
                return null;
            }
        }

        private bool InativarEmpresa(Gerente gerente, string NomeFantasia, string CNPJ)
        {   
            Empresa empresa = ConsultarEmpresa(NomeFantasia);
            if(empresa != null)
            {
                SqlConnection con = new SqlConnection(conexao.con.ToString());
                string query = "DELETE * FROM Empresa WHERE NomeFantasia ==" + NomeFantasia + "AND CNPJ ==" + CNPJ;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;

            }
            else
            {
                return false;
            }

        }

    }
}
