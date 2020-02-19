using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BDClasses;
using Business;

namespace Models
{
    public class Mdl_Manutencao
    {
        Ctrl_BD ctrlBd = new Ctrl_BD();
        
        public bool CadManutencao(Manutencao Manutencao)
        {
            SqlConnection con = new SqlConnection(ctrlBd.stringConexao);
            try
            {
                con.Open();
                string Query = "dbo.Sp_CadastroManutencao";
                SqlCommand cmd = new SqlCommand(Query, con);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Placa", System.Data.SqlDbType.VarChar)).Value = Manutencao.placaVeiculo;
                cmd.Parameters.Add(new SqlParameter("@Motivo", System.Data.SqlDbType.VarChar)).Value = Manutencao.motivoAgenda;
                cmd.Parameters.Add(new SqlParameter("@Data", System.Data.SqlDbType.Date)).Value = Manutencao.dataManutencao.Date;
                cmd.Parameters.Add(new SqlParameter("@Empresa", System.Data.SqlDbType.VarChar)).Value = Manutencao.empresa;
                cmd.Parameters.Add(new SqlParameter("@Observacoes", System.Data.SqlDbType.VarChar)).Value = Manutencao.observacoes;
                cmd.Parameters.Add(new SqlParameter("@RegistroMecanica", System.Data.SqlDbType.Decimal)).Value = Manutencao.registroMecanica;
                cmd.Parameters.Add(new SqlParameter("@Max", System.Data.SqlDbType.Int)).Value = 1;

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
            string Query = "SELECT Cod_Manutencao, Data, Motivo, Empresa, Observacao, Placa FROM dbo.MANUTENCAO";
            Ctrl_BD ctrlBD = new Ctrl_BD();

          
        string con = ctrlBD.stringConexao;

            SqlDataAdapter _da = new SqlDataAdapter(Query, con);
            _da.Fill(_DataSet, "dbo.MANUTENCAO");

            // Obtem a tabela do dataset
            DataTable dtable = _DataSet.Tables["dbo.MANUTENCAO"];

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

                    ListViewItem lvi = new ListViewItem(drow["Cod_Manutencao"].ToString());
                    lvi.SubItems.Add(drow["Data"].ToString());
                    lvi.SubItems.Add(drow["Motivo"].ToString());
                    lvi.SubItems.Add(drow["Empresa"].ToString());
                    lvi.SubItems.Add(drow["Observacao"].ToString());
                    lvi.SubItems.Add(drow["Placa"].ToString());


                    // Inclui os itens no ListView
                    listView1.Items.Add(lvi);
                }
            }
        }

        public bool ExcluirManutencao(int CodManutencao)
        {
            SqlConnection con = new SqlConnection(ctrlBd.stringConexao);

            try
            {
                con.Open();
                string Query = "dbo.Sp_ExcluirManutencao";
                SqlCommand cmd = new SqlCommand(Query, con);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Cod_Manutencao", System.Data.SqlDbType.Int)).Value = CodManutencao;
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
