using BDClasses;
using Business;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Models
{
    public class Mdl_Mecanica
    {
        Ctrl_BD ctrlVeiculo = new Ctrl_BD();

        public bool CadastroMecanica(Mecanica Mecanica)
        {
            try
            {
                Ctrl_BD CadMecanicas = new Ctrl_BD();
                SqlConnection con = new SqlConnection(CadMecanicas.stringConexao);
                string Query = "[dbo].[Sp_CadastroMecanica]";
                SqlCommand cmd = new SqlCommand(Query, con);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@CEP", SqlDbType.VarChar)).Value = Mecanica.Cep;
                cmd.Parameters.Add(new SqlParameter("@Cidade", SqlDbType.VarChar)).Value = Mecanica.Cidade;
                cmd.Parameters.Add(new SqlParameter("@Rua", SqlDbType.VarChar)).Value = Mecanica.Logradouro;
                cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Mecanica.Estado;
                cmd.Parameters.Add(new SqlParameter("@RegistroMecanica", SqlDbType.Int)).Value = Mecanica.RegistroMecanica;
                cmd.Parameters.Add(new SqlParameter("@Manutencao", SqlDbType.VarChar)).Value = Mecanica.Manutencao;
                cmd.Parameters.Add(new SqlParameter("@Max", SqlDbType.VarChar)).Value = 1;


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Mecanica Cadastrada com Sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ops! Algo deu errado! Contate o suporte." +
                    "Erro: " + e.Message);
                return false;
            }

        }
        public bool InativarMecanica(int CodMecanica)
        {
            SqlConnection con = new SqlConnection(ctrlVeiculo.stringConexao);

            try
            {
                con.Open();
                string Query = "dbo.Sp_ExcluirMecanica";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Cod_Mecanica", SqlDbType.Int)).Value = CodMecanica;
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

        public bool AtualizarMecanica()
        {
            try
            {
                Ctrl_BD UpdateMecanica = new Ctrl_BD();
                UpdateMecanica.Update("");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ConsultarMecanica()
        {
            try
            {
                Ctrl_BD ConsultarMecanica = new Ctrl_BD();
                ConsultarMecanica.ConsultarVeiculo("");
                return true;
            }
            catch
            {
                return false;
            }
        }

        /*public void carregaLista(ListView listView1)
        {
            Ctrl_BD ctrlBD = new Ctrl_BD();
            string strCon = ctrlBD.stringConexao;
            SqlConnection con = new SqlConnection(strCon);

            DataSet _DataSet = new DataSet();
            //string Query = "SELECT Cod_Veiculo, Marca, Modelo, NomeFrota, TipoCategoria, Seguro, Adaptado FROM dbo.View_CategoriaVeiuculoMulta";
            string Query = "SELECT Cod_Mecanica, RegistroMecanica FROM dbo.MECANICA";
            SqlCommand cmd1 = new SqlCommand(Query, con);
            SqlDataReader dr = cmd1.ExecuteReader();
                    

            SqlDataAdapter _da = new SqlDataAdapter(Query, con);
            _da.Fill(_DataSet, "dbo.MECANICA");

            // Obtem a tabela do dataset
            DataTable dtable = _DataSet.Tables["dbo.MECANICA"];

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

                    ListViewItem lvi = new ListViewItem(drow["Cod_Mecanica"].ToString());
                    lvi.SubItems.Add(drow["RegistroMecanica"].ToString());
                    //lvi.SubItems.Add(drow["Modelo"].ToString());
                    //lvi.SubItems.Add(drow["NomeFrota"].ToString());
                    //lvi.SubItems.Add(drow["TipoCategoria"].ToString());
                    //lvi.SubItems.Add(drow["Seguro"].ToString());
                    //lvi.SubItems.Add(drow["Adaptado"].ToString());

                    // Inclui os itens no ListView
                    listView1.Items.Add(lvi);
                }
            }
        }*/

        public void CarregaLista(ListView listView1)
        {
            DataSet _DataSet = new DataSet();
            string Query = "SELECT Cod_Mecanica, RegistroMecanica, Rua, Manutencao FROM View_EnderecoMecanica";
            Ctrl_BD ctrlBD = new Ctrl_BD();



            string con = ctrlBD.stringConexao;

            SqlDataAdapter _da = new SqlDataAdapter(Query, con);
            _da.Fill(_DataSet, "View_EnderecoMecanica");

            // Obtem a tabela do dataset
            DataTable dtable = _DataSet.Tables["View_EnderecoMecanica"];

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

                    ListViewItem lvi = new ListViewItem(drow["Cod_Mecanica"].ToString());
                    lvi.SubItems.Add(drow["RegistroMecanica"].ToString());
                    lvi.SubItems.Add(drow["Rua"].ToString());
                    lvi.SubItems.Add(drow["Manutencao"].ToString());
                    //lvi.SubItems.Add(drow["Telefone"].ToString());
                    //lvi.SubItems.Add(drow["CEP"].ToString());
                    //lvi.SubItems.Add(drow["Seguro"].ToString());
                    //lvi.SubItems.Add(drow["Adaptado"].ToString());

                    // Inclui os itens no ListView
                    listView1.Items.Add(lvi);
                }
            }
        }
    }
}
