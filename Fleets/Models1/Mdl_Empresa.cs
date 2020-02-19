using Business;
using System.Data.SqlClient;

using BDClasses;
using System.Data;
using System.Windows.Forms;

namespace Models
{
    public class Mdl_Empresa
    {
        Ctrl_BD conexao = new Ctrl_BD();

        public bool CadastrarEmpresa(Empresa Empresa)
        {
            try
            {

                SqlConnection con = new SqlConnection("");
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

        public Empresa ConsultarEmpresa(string CNPJ)
        {
            Ctrl_BD conexao = new Ctrl_BD();
            SqlConnection con = new SqlConnection(conexao.stringConexao);
            con.Open();
            try
            {
                
                string query = "SELECT * from dbo.vw_PerfilEmpresa WHERE CNPJ = '" + CNPJ + "'";
                SqlCommand cmd = new SqlCommand(query, con);          
                SqlDataReader dr = cmd.ExecuteReader();
                Empresa empresa = new Empresa();
                dr.Read();

                empresa.nomeFantasia = dr.GetString(0);
                empresa.razaoSocial = dr.GetString(1);
                empresa.NIRE = dr.GetString(2);
                empresa.CNPJ = dr.GetString(3);
                empresa.ramoDeAtividade = dr.GetString(4);
                empresa.numero = dr.GetInt32(5);
                empresa.estado = dr.GetString(6);
                empresa.CEP = dr.GetString(7);
                empresa.logradouro = dr.GetString(8);
                empresa.cidade = dr.GetString(9);
                empresa.email = dr.GetString(10);
                empresa.celular = dr.GetString(11);
                empresa.telefone = dr.GetString(12);
                
                
                return empresa;

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

        private bool AlterarEmpresa(Empresa Empresa)
        {

            Ctrl_BD conexao = new Ctrl_BD();

            try
            {
                SqlConnection con = new SqlConnection(conexao.stringConexao);
                string query = "dbo.Sp_AlterarEmpresa";
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

        

        public void carregaLista(ListView listView1)
        {
            /*DataSet _DataSet = new DataSet();
            string Query = "SELECT NomeFantasia, CNPJ, Email, Telefone, CEP FROM dbo.vw_PerfilEmpresa";
            Ctrl_BD ctrlBD = new Ctrl_BD();



            string con = ctrlBD.stringConexao;

            SqlDataAdapter _da = new SqlDataAdapter(Query, con);
            _da.Fill(_DataSet, "dbo.vw_PerfilEmpresa");

            // Obtem a tabela do dataset
            DataTable dtable = _DataSet.Tables["dbo.vw_PerfilEmpresa"];

            // limpa o ListView
            listView1.Items.Clear();

            // exibe os itens no controle ListView 
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                // Somente as linhas que não foram deletadas
                if (drow.RowState != DataRowState.Deleted)
                {
                    // Define os itens da lista

                    ListViewItem lvi = new ListViewItem(drow["Cod_Empresa"].ToString());
                    lvi.SubItems.Add(drow["NomeFantasia"].ToString());
                    lvi.SubItems.Add(drow["CNPJ"].ToString());
                    lvi.SubItems.Add(drow["Email"].ToString());
                    lvi.SubItems.Add(drow["Telefone"].ToString());
                    lvi.SubItems.Add(drow["CEP"].ToString());
                    

                    // Inclui os itens no ListView
                    listView1.Items.Add(lvi);
                }
            }*/
        }

        public bool ExcluirEmpresa(int CodEmpresa)
        {
            SqlConnection con = new SqlConnection(conexao.stringConexao);
            try
            {
                con.Open();
                string Query = "dbo.Sp_ExcluirEmpresa";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Cod_Empresa", SqlDbType.Int)).Value = CodEmpresa;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
