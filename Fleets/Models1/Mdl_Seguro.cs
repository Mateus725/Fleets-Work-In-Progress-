using System.Data.SqlClient;
using Business;
using BDClasses;
using System.Data;
using System.Windows.Forms;

namespace Models
{
    public class Mdl_Seguro
    {
        Ctrl_BD conexao = new Ctrl_BD();

        public bool CadastrarSeguro(Seguro Seguro)
        {
            SqlConnection con = new SqlConnection(conexao.stringConexao);
            try
            {
                con.Open();
                string Query = "dbo.Sp_CadastroSeguro";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Seguradora", SqlDbType.VarChar)).Value = Seguro.seguradora;
                cmd.Parameters.Add(new SqlParameter("@Vigencia", SqlDbType.Int)).Value = Seguro.vigencia;
                cmd.Parameters.Add(new SqlParameter("@Cobertura", SqlDbType.Int)).Value = Seguro.cobertura;
                

                cmd.ExecuteNonQuery();

                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool AtualizarSeguro(Seguro Seguro)
        {
            try
            {
                Ctrl_BD cadSeguro = new Ctrl_BD();
                cadSeguro.Update("");
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool InativarSeguro(int CodSeguro)
        {
            SqlConnection con = new SqlConnection(conexao.stringConexao);
            try
            {
                con.Open();
                string Query = "dbo.ExcluirSeguro";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Cod_Seguro", SqlDbType.Int)).Value = CodSeguro;
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
        public void carregaLista(ListView listView1)
        {
            DataSet _DataSet = new DataSet();
            string Query = "SELECT Cod_Seguro, Seguradora, Vigencia, Cobertura, Sinistros FROM dbo.SEGURO";
            Ctrl_BD ctrlBD = new Ctrl_BD();

        string con = ctrlBD.stringConexao;

            SqlDataAdapter _da = new SqlDataAdapter(Query, con);
            _da.Fill(_DataSet, "dbo.SEGURO");

            // Obtem a tabela do dataset
            DataTable dtable = _DataSet.Tables["dbo.SEGURO"];

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

                    ListViewItem lvi = new ListViewItem(drow["Cod_Seguro"].ToString());
                    lvi.SubItems.Add(drow["Seguradora"].ToString());
                    lvi.SubItems.Add(drow["Vigencia"].ToString());
                    lvi.SubItems.Add(drow["Cobertura"].ToString());
                    lvi.SubItems.Add(drow["Sinistros"].ToString());

                    // Inclui os itens no ListView
                    listView1.Items.Add(lvi);
                }
            }
        }

        /*public bool ConsultarSeguro(Seguro seguro)
         {
             Ctrl_BD consultarSeguro = new Ctrl_BD();
             try
             {
                 consultarSeguro.
             }
         }*/
    }
}
