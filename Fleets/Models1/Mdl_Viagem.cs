using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BDClasses;
using Business;


namespace Models
{
    public class Mdl_Viagem
    {
        Ctrl_BD ctrlBd = new Ctrl_BD();

        public bool CadastroViagens(Viagem viagem)
        {
            try
            {



                SqlConnection con = new SqlConnection(ctrlBd.stringConexao);
                string Query = "dbo.Sp_CadastroViagem";
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Rua", SqlDbType.VarChar)).Value = viagem.LogradouroOrigem;
                cmd.Parameters.Add(new SqlParameter("@Numero", SqlDbType.Int)).Value = viagem.numeroOrigem;
                cmd.Parameters.Add(new SqlParameter("@CEP", SqlDbType.VarChar)).Value = viagem.cepOrigem;
                cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = viagem.estadoOrigem;
                cmd.Parameters.Add(new SqlParameter("@Cidade", SqlDbType.VarChar)).Value = viagem.cidadeOrigem;
                cmd.Parameters.Add(new SqlParameter("@Max", SqlDbType.Int)).Value = 1;

                cmd.Parameters.Add(new SqlParameter("@RuaA", SqlDbType.VarChar)).Value = viagem.LogradouroOrigem;
                cmd.Parameters.Add(new SqlParameter("@NumeroO", SqlDbType.Int)).Value = viagem.numeroOrigem;
                cmd.Parameters.Add(new SqlParameter("@CEPP", SqlDbType.VarChar)).Value = viagem.cepOrigem;
                cmd.Parameters.Add(new SqlParameter("@EstadoO", SqlDbType.VarChar)).Value = viagem.estadoOrigem;
                cmd.Parameters.Add(new SqlParameter("@CidadeE", SqlDbType.VarChar)).Value = viagem.cidadeOrigem;

                cmd.Parameters.Add(new SqlParameter("@PkMotorista", SqlDbType.Int)).Value = viagem.pkMotorista;
                cmd.Parameters.Add(new SqlParameter("@PkVeiculo", SqlDbType.Int)).Value = viagem.pkVeiculo;
                cmd.Parameters.Add(new SqlParameter("@ValorPedagio", SqlDbType.Money)).Value = viagem.valorPedagio;
                cmd.Parameters.Add(new SqlParameter("@Max1", SqlDbType.Int)).Value = 1;



                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Viagem Cadastrada com Sucesso!");

                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool UpdateViagem(Viagem Viagem)
        {
            try
            {
                Ctrl_BD Update = new Ctrl_BD();
                Update.Update("");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ExcluirViagem(string Cod)
        {
            try
            {
                string Query = "dbo.Sp_ExcluirViagem";
                SqlConnection con = new SqlConnection(ctrlBd.stringConexao);
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Cod_Viagem", SqlDbType.Int)).Value = Convert.ToInt32(Cod);

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
            catch
            {
                return false;
            }
        }
        public Viagem BuscarViagem(string Cidade)
        {
            try
            {
                Ctrl_BD buscarViagem = new Ctrl_BD();
                return buscarViagem.ConsultarViagem("");

            }
            catch
            {
                return null;
            }
        }


    }
    /*public void carregaLista(ListView listView1)
    {
        DataSet _DataSet = new DataSet();
        string Query = "SELECT Cod_Viagem FROM dbo.";
        Ctrl_BD ctrlBD = new Ctrl_BD();



        string con = ctrlBD.stringConexao;

        SqlDataAdapter _da = new SqlDataAdapter(Query, con);
        _da.Fill(_DataSet, "dbo.");

        // Obtem a tabela do dataset
        DataTable dtable = _DataSet.Tables["dbo."];

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

                ListViewItem lvi = new ListViewItem(drow["Cod_Viagem"].ToString());
                lvi.SubItems.Add(drow[""].ToString());
                lvi.SubItems.Add(drow[""].ToString());
                lvi.SubItems.Add(drow[""].ToString());
                lvi.SubItems.Add(drow[""].ToString());
                lvi.SubItems.Add(drow[""].ToString());


                // Inclui os itens no ListView
                listView1.Items.Add(lvi);
            }
        }

    }*/
}
