using BDClasses;
using Business;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Models
{
    public class Mdl_Frota
    {
        Ctrl_BD conexao = new Ctrl_BD();

        public bool CadastrarFrota(Frota frota)
        {
            SqlConnection con = new SqlConnection(conexao.stringConexao);
            try
            {
                con.Open();
                string Query = "dbo.Sp_CadastroFrota";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@NomeFrota", SqlDbType.VarChar)).Value = frota.nomeFrota;
                cmd.Parameters.Add(new SqlParameter("@QtdVeiculo", SqlDbType.Int)).Value = frota.QuantVeiculos;
                cmd.Parameters.Add(new SqlParameter("@QtdMotorista", SqlDbType.Int)).Value = frota.QuantMotoristas;
                cmd.Parameters.Add(new SqlParameter("@NomeEmpresa", SqlDbType.VarChar)).Value = frota.empresa;

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

        public bool ExcluirFrota(int CodFrota)
        {
            SqlConnection con = new SqlConnection(conexao.stringConexao);

            try
            {
                con.Open();
                string Query = "dbo.Sp_ExcluirFrota";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Cod_Frota", SqlDbType.Int)).Value = CodFrota;
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
            string Query = "SELECT Cod_Frota, NomeEmpresa, QtdVeiculo, QtdMotorista FROM dbo.FROTAS";
            Ctrl_BD ctrlBD = new Ctrl_BD();



            string con = ctrlBD.stringConexao;

            SqlDataAdapter _da = new SqlDataAdapter(Query, con);
            _da.Fill(_DataSet, "dbo.FROTAS");

            // Obtem a tabela do dataset
            DataTable dtable = _DataSet.Tables["dbo.FROTAS"];

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

                    ListViewItem lvi = new ListViewItem(drow["Cod_Frotas"].ToString());
                    lvi.SubItems.Add(drow["NomeEmpresa"].ToString());
                    lvi.SubItems.Add(drow["QtdVeiculo"].ToString());
                    lvi.SubItems.Add(drow["QtdMotorista"].ToString());
                    
                    //lvi.SubItems.Add(drow["Seguro"].ToString());
                    //lvi.SubItems.Add(drow["Adaptado"].ToString());

                    // Inclui os itens no ListView
                    listView1.Items.Add(lvi);
                }
            }
        }

    }
}
