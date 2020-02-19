using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Business;
using BDClasses;

namespace Models
{
    class Mdl_Funcionario
    {

        Ctrl_BD conexao = new Ctrl_BD();

        public bool CadastrarFuncionario(Funcionario Funcionario)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexao.con.ToString());
                string query = "INSERTO INTO Funcionario [Nome, Nascimento, RG, Sexo, EstadoCivil, CPF, Login_User, Senha, CTPS] VALUES ("+
                    Funcionario.nome + ", " + Funcionario.dataNascimento + ", " + Funcionario.RG + ", " + Funcionario.sexo + ", " + Funcionario.estadoCivil + ", " + Funcionario.CPF + ", " +
                    Funcionario.login + ", " + Funcionario.senha + ", " + Funcionario.CTPS + ")";
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

        public bool InativarFuncionario(Funcionario Funcionario)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexao.con.ToString());
                string query = "DELETE * FROM Funcionario WHERE Nome ==" + Funcionario.nome + "AND CPF ==" + Funcionario.CPF;
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

        /*public Funcionario BuscarFuncionarioNome(string Nome)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexao.Conexao);
                string query = "SELECT * FROM FUNCIONARIO WHERE Nome==" + Nome;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                foreach(Funcionario Funcionario in dr)
                {
                    //Funcionario funcionario = new Funcionario(dr.GetString(0), dr.GetDateTime(1), dr.GetString(2));
                }
            }
        }*/

    }
}
