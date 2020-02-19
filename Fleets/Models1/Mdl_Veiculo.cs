using System;
using BDClasses;
using Business;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Models
{
    public class Mdl_Veiculo
    {
        Ctrl_BD ctrlVeiculo = new Ctrl_BD();

        //Veiculo veiculo;

       

        public Mdl_Veiculo()
        {
        }

        public bool CadastroVeiculo(Veiculo veiculo)
        {
           
            try
            {
                Ctrl_BD CadVeiculos = new Ctrl_BD();
                SqlConnection con = new SqlConnection(CadVeiculos.stringConexao);
                string Query = "dbo.Sp_CadastroVeiculo";
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Renavam", SqlDbType.Int)).Value = veiculo.renavam;
                cmd.Parameters.Add(new SqlParameter("@Placa", SqlDbType.VarChar)).Value = veiculo.placa;
                cmd.Parameters.Add(new SqlParameter("@Ano", SqlDbType.Int)).Value = veiculo.categoria;
                cmd.Parameters.Add(new SqlParameter("@Marca", SqlDbType.VarChar)).Value = veiculo.marca;
                cmd.Parameters.Add(new SqlParameter("@Modelo", SqlDbType.VarChar)).Value = veiculo.modelo;
                cmd.Parameters.Add(new SqlParameter("@TipoCategoria", SqlDbType.VarChar)).Value = veiculo.categoria;
                cmd.Parameters.Add(new SqlParameter("@Cor", SqlDbType.VarChar)).Value = veiculo.cor;
                cmd.Parameters.Add(new SqlParameter("@Kilometragem", SqlDbType.Decimal)).Value = veiculo.kilometragem;
                cmd.Parameters.Add(new SqlParameter("@Combustivel", SqlDbType.VarChar)).Value = veiculo.combustivel;
                cmd.Parameters.Add(new SqlParameter("@Seguro", SqlDbType.VarChar)).Value = veiculo.seguro;
                cmd.Parameters.Add(new SqlParameter("@Adaptado", SqlDbType.VarChar)).Value = veiculo.adaptado;
                cmd.Parameters.Add(new SqlParameter("@Max", SqlDbType.Int)).Value = 1;

                cmd.Parameters.Add(new SqlParameter("@NomeFrota", SqlDbType.VarChar)).Value = veiculo.frotas;
                cmd.Parameters.Add(new SqlParameter("@Max1", SqlDbType.Int)).Value = 1;

                cmd.Parameters.Add(new SqlParameter("@Infracao", SqlDbType.VarChar)).Value = veiculo.infracoes;               

                
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Veiculo Cadastrado com Sucesso!");

                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Ops! Algo deu errado! Contate o suporte." +
                    "Erro: " + e.Message);
                return false;
            }
          
        }
        public bool InativarVeiculo(int CodVeiculo)
        {
            SqlConnection con = new SqlConnection(ctrlVeiculo.stringConexao);
            try
            {
                con.Open();
                string Query = "dbo.Sp_ExcluirVeiculo";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Cod_Veiculo", SqlDbType.Int)).Value = CodVeiculo;
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

        public bool AtualizarVeiculo()
        {
            try
            {
                Ctrl_BD UpdateVeiculos = new Ctrl_BD();
                UpdateVeiculos.Update("");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ConsultarVeiculo()
        {
            try
            {
                Ctrl_BD ConsultarVeiculos = new Ctrl_BD();
                ConsultarVeiculos.ConsultarVeiculo("");
                return true;
            }
            catch
            {
                return false;
            }
        }

        /*public void carregaLista(ListView listView1)
        {
            DataSet _DataSet = new DataSet();
            //string Query = "SELECT Cod_Veiculo, Marca, Modelo, NomeFrota, TipoCategoria, Seguro, Adaptado FROM dbo.View_CategoriaVeiuculoMulta";
            string Query = "SELECT Cod_Veiculo, Marca, Modelo, Seguro, Adaptado FROM dbo.VEICULO";
            Ctrl_BD ctrlBD = new Ctrl_BD();



            string con = ctrlBD.stringConexao;

            SqlDataAdapter _da = new SqlDataAdapter(Query, con);
            _da.Fill(_DataSet, "VEICULO");

            // Obtem a tabela do dataset
            DataTable dtable = _DataSet.Tables["VEICULO"];

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
                    
                    ListViewItem lvi = new ListViewItem(drow["Cod_Veiculo"].ToString());
                    lvi.SubItems.Add(drow["Marca"].ToString());
                    lvi.SubItems.Add(drow["Modelo"].ToString());
                    //lvi.SubItems.Add(drow["NomeFrota"].ToString());
                    //lvi.SubItems.Add(drow["TipoCategoria"].ToString());
                    lvi.SubItems.Add(drow["Seguro"].ToString());
                    lvi.SubItems.Add(drow["Adaptado"].ToString());

                    // Inclui os itens no ListView
                    listView1.Items.Add(lvi);
                }
            }
        }*/
    }
}
