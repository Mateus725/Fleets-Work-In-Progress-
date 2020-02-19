using System;
using System.Data.SqlClient;
using Business;
using BDClasses;
using System.Data;
using System.Windows.Forms;

namespace Models
{
    public class Mdl_Funcionario
    {

        Ctrl_BD conexao = new Ctrl_BD();

        public bool CadastrarFuncionario(Funcionario Funcionario)
        {
            try
            {
                Ctrl_BD CadFunc = new Ctrl_BD();
                SqlConnection con = new SqlConnection(CadFunc.stringConexao);
                string Query = "dbo.Sp_CadastroUsuario";
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Rua", SqlDbType.VarChar)).Value = Funcionario.endereco;
                cmd.Parameters.Add(new SqlParameter("@Numero", SqlDbType.Int)).Value = Funcionario.numero;
                cmd.Parameters.Add(new SqlParameter("@CEP", SqlDbType.VarChar)).Value = Funcionario.cep;
                cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Funcionario.estado;
                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar)).Value = Funcionario.email;
                cmd.Parameters.Add(new SqlParameter("@Telefone", SqlDbType.VarChar)).Value = Funcionario.telefone;
                cmd.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar)).Value = Funcionario.cargo;
                //cmd.Parameters.Add(new SqlParameter("@Max", SqlDbType.Int)).Value = 1;
                cmd.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = Funcionario.nome;
                cmd.Parameters.Add(new SqlParameter("@Nascimento", SqlDbType.Date)).Value = Funcionario.dataNascimento;
                cmd.Parameters.Add(new SqlParameter("@RG", SqlDbType.VarChar)).Value = Funcionario.RG;
                cmd.Parameters.Add(new SqlParameter("@CPF", SqlDbType.VarChar)).Value = Funcionario.CPF;
                cmd.Parameters.Add(new SqlParameter("@Sexo", SqlDbType.VarChar)).Value = Funcionario.sexo;
                cmd.Parameters.Add(new SqlParameter("@EstadoCivil", SqlDbType.VarChar)).Value = Funcionario.estadoCivil;
                cmd.Parameters.Add(new SqlParameter("@CTPS", SqlDbType.VarChar)).Value = Funcionario.CTPS;
                cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.VarChar)).Value = Funcionario.login;
                cmd.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)).Value = Funcionario.senha;
                cmd.Parameters.Add(new SqlParameter("@Cod_Empresa", SqlDbType.Int)).Value = Funcionario.CodEmpresa;

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Funcionário Cadastrado com Sucesso!");

                return true;

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Ops! Algo deu errado! Contate o suporte." +
                    "Erro: " + e.Message);
                return false;
            }
        }

        public bool CadastrarMotorista(Motorista motorista)
        {
            try
            {
                Ctrl_BD CadFunc = new Ctrl_BD();
                SqlConnection con = new SqlConnection(CadFunc.stringConexao);
                string Query = "dbo.Sp_CadastroMotorista";
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Rua", SqlDbType.VarChar)).Value = motorista.endereco;
                cmd.Parameters.Add(new SqlParameter("@Numero", SqlDbType.Int)).Value = motorista.numero;
                cmd.Parameters.Add(new SqlParameter("@CEP", SqlDbType.VarChar)).Value = motorista.cep;
                cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = motorista.estado;
                cmd.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar)).Value = motorista.cargo;
                cmd.Parameters.Add(new SqlParameter("@Max", SqlDbType.Int)).Value = 1;
                cmd.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = motorista.nome;
                cmd.Parameters.Add(new SqlParameter("@Nascimento", SqlDbType.Date)).Value = motorista.dataNascimento;
                cmd.Parameters.Add(new SqlParameter("@RG", SqlDbType.VarChar)).Value = motorista.RG;
                cmd.Parameters.Add(new SqlParameter("@CPF", SqlDbType.VarChar)).Value = motorista.CPF;
                cmd.Parameters.Add(new SqlParameter("@Sexo", SqlDbType.VarChar)).Value = motorista.sexo;
                cmd.Parameters.Add(new SqlParameter("@EstadoCivil", SqlDbType.VarChar)).Value = motorista.estadoCivil;
                cmd.Parameters.Add(new SqlParameter("@CTPS", SqlDbType.VarChar)).Value = motorista.CTPS;
                cmd.Parameters.Add(new SqlParameter("@CNH", SqlDbType.VarChar)).Value = motorista.CNH;
                cmd.Parameters.Add(new SqlParameter("@Habilitacao", SqlDbType.Char)).Value = motorista.habilitacao;
                cmd.Parameters.Add(new SqlParameter("@TipoSanguineo", SqlDbType.Char)).Value = motorista.tipoSanguinio;
                cmd.Parameters.Add(new SqlParameter("@Deficiencia", SqlDbType.VarChar)).Value = motorista.deficiencia;
                //cmd.Parameters.Add(new SqlParameter("@Max1", SqlDbType.Int)).Value = 1;
                cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.VarChar)).Value = motorista.login;
                cmd.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)).Value = motorista.senha;
                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar)).Value = motorista.email;
                cmd.Parameters.Add(new SqlParameter("@Telefone", SqlDbType.VarChar)).Value = motorista.telefone;
                cmd.Parameters.Add(new SqlParameter("@Cod_Empresa", SqlDbType.Int)).Value = motorista.CodEmpresa;


                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Motorista Cadastrado com Sucesso!");

                return true;

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Ops! Algo deu errado! Contate o suporte." +
                    "Erro: " + e.Message);
                return false;
            }
        }

        public bool InativarFuncionario(string Cod)
        {
            SqlConnection con = new SqlConnection(conexao.stringConexao);
            con.Open();
            try
            {
                string query = "dbo.Sp_ExcluirUsuario";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Cod_Usuario", SqlDbType.VarChar)).Value = Convert.ToInt32(Cod);

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

        public bool AtualizarFuncionario(Funcionario Funcionario, int CodigoFuncionario)
        {
            try
            {
                Ctrl_BD CadFunc = new Ctrl_BD();
                SqlConnection con = new SqlConnection(CadFunc.stringConexao);
                string Query = "dbo.Sp_AlterarUsuario";
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Rua", SqlDbType.VarChar)).Value = Funcionario.endereco;
                cmd.Parameters.Add(new SqlParameter("@Numero", SqlDbType.Int)).Value = Funcionario.numero;
                cmd.Parameters.Add(new SqlParameter("@CEP", SqlDbType.VarChar)).Value = Funcionario.cep;
                cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Funcionario.estado;
                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar)).Value = Funcionario.email;
                cmd.Parameters.Add(new SqlParameter("@Telefone", SqlDbType.VarChar)).Value = Funcionario.telefone;
                cmd.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar)).Value = Funcionario.cargo;
                //cmd.Parameters.Add(new SqlParameter("@Max", SqlDbType.Int)).Value = 1;
                cmd.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = Funcionario.nome;
                //cmd.Parameters.Add(new SqlParameter("@Nascimento", SqlDbType.Date)).Value = Funcionario.dataNascimento;
                //cmd.Parameters.Add(new SqlParameter("@RG", SqlDbType.VarChar)).Value = Funcionario.RG;
                //cmd.Parameters.Add(new SqlParameter("@CPF", SqlDbType.VarChar)).Value = Funcionario.CPF;
                //cmd.Parameters.Add(new SqlParameter("@Sexo", SqlDbType.VarChar)).Value = Funcionario.sexo;
                cmd.Parameters.Add(new SqlParameter("@EstadoCivil", SqlDbType.VarChar)).Value = Funcionario.estadoCivil;
                //cmd.Parameters.Add(new SqlParameter("@CTPS", SqlDbType.VarChar)).Value = Funcionario.CTPS;
                //cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.VarChar)).Value = Funcionario.login;
                //cmd.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)).Value = Funcionario.senha;
                cmd.Parameters.Add(new SqlParameter("@Cod_Usuario", SqlDbType.Int)).Value = CodigoFuncionario;

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Funcionário Atualizado com Sucesso!");

                return true;

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Ops! Algo deu errado! Contate o suporte." +
                    "Erro: " + e.Message);
                return false;
            }
        }

        public bool AtualizarMotorista(Motorista motorista, String CodigoFuncionario)
        {
            try
            {
               
                Ctrl_BD CadFunc = new Ctrl_BD();
                SqlConnection con = new SqlConnection(CadFunc.stringConexao);
                string Query = "dbo.Sp_CadastroMotorista";
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Rua", SqlDbType.VarChar)).Value = motorista.endereco;
                cmd.Parameters.Add(new SqlParameter("@Numero", SqlDbType.Int)).Value = motorista.numero;
                cmd.Parameters.Add(new SqlParameter("@CEP", SqlDbType.VarChar)).Value = motorista.cep;
                cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = motorista.estado;
                cmd.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar)).Value = motorista.cargo;
                cmd.Parameters.Add(new SqlParameter("@Max", SqlDbType.Int)).Value = 1;
                cmd.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = motorista.nome;
                cmd.Parameters.Add(new SqlParameter("@Nascimento", SqlDbType.Date)).Value = motorista.dataNascimento;
                cmd.Parameters.Add(new SqlParameter("@RG", SqlDbType.VarChar)).Value = motorista.RG;
                cmd.Parameters.Add(new SqlParameter("@CPF", SqlDbType.VarChar)).Value = motorista.CPF;
                cmd.Parameters.Add(new SqlParameter("@Sexo", SqlDbType.VarChar)).Value = motorista.sexo;
                cmd.Parameters.Add(new SqlParameter("@EstadoCivil", SqlDbType.VarChar)).Value = motorista.estadoCivil;
                cmd.Parameters.Add(new SqlParameter("@CTPS", SqlDbType.VarChar)).Value = motorista.CTPS;
                cmd.Parameters.Add(new SqlParameter("@CNH", SqlDbType.VarChar)).Value = motorista.CNH;
                cmd.Parameters.Add(new SqlParameter("@Habilitacao", SqlDbType.Char)).Value = motorista.habilitacao;
                cmd.Parameters.Add(new SqlParameter("@TipoSanguineo", SqlDbType.Char)).Value = motorista.tipoSanguinio;
                cmd.Parameters.Add(new SqlParameter("@Deficiencia", SqlDbType.VarChar)).Value = motorista.deficiencia;
                cmd.Parameters.Add(new SqlParameter("@Max1", SqlDbType.Int)).Value = 1;
                cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.VarChar)).Value = motorista.login;
                cmd.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)).Value = motorista.senha;
                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar)).Value = motorista.email;
                cmd.Parameters.Add(new SqlParameter("@Telefone", SqlDbType.VarChar)).Value = motorista.telefone;

                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Motorista excluído com Sucesso!");

                return true;

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Ops! Algo deu errado! Contate o suporte." +
                    "Erro: " + e.Message);
                return false;
            }
        }


        public void carregaLista(ListView listView1)
        {
            DataSet _DataSet = new DataSet();
            string Query = "SELECT Cod_usuario, Nome, Cargo, Telefone, Celular FROM dbo.vw_UsuarioDesktop";
            Ctrl_BD ctrlBD = new Ctrl_BD();



            string con = ctrlBD.stringConexao;

            SqlDataAdapter _da = new SqlDataAdapter(Query, con);
            _da.Fill(_DataSet, "dbo.vw_UsuarioDesktop");

            // Obtem a tabela do dataset
            DataTable dtable = _DataSet.Tables["dbo.vw_UsuarioDesktop"];

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

                    ListViewItem lvi = new ListViewItem(drow["Cod_usuario"].ToString());
                    lvi.SubItems.Add(drow["Nome"].ToString());
                    lvi.SubItems.Add(drow["Cargo"].ToString());
                    lvi.SubItems.Add(drow["Telefone"].ToString());
                    lvi.SubItems.Add(drow["Celular"].ToString());
                    
                    // Inclui os itens no ListView
                    listView1.Items.Add(lvi);
                }
            }
        }
        
        public Funcionario carregaFuncionario(int CodFuncionario)
        {

            SqlConnection con = new SqlConnection(conexao.stringConexao);

            try
            {
                con.Open();
                String Query = "Select * from dbo.vw_UsuarioDesktop where Cod_usuario ='" + CodFuncionario + "'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                Funcionario funcionario = new Funcionario();

                //funcionario.dataNascimento = Convert.ToDateTime(dr.GetString(12));
                funcionario.CodFuncionario = CodFuncionario;
                funcionario.nome = dr.GetString(13);
                funcionario.CPF = dr.GetString(17);
                funcionario.cargo = dr.GetString(21);//verificar
                funcionario.email = dr.GetString(0);//verificar
                funcionario.telefone = dr.GetString(2);//verificar
                funcionario.RG = dr.GetString(14);
                funcionario.sexo = Convert.ToChar(dr.GetString(15));
                funcionario.estadoCivil = dr.GetString(16);
                funcionario.CTPS = dr.GetString(19);
                funcionario.endereco = dr.GetString(8);
                funcionario.numero = dr.GetInt32(5);
                funcionario.cep = dr.GetString(7);
                funcionario.estado = dr.GetString(6);
                funcionario.telefone = dr.GetString(2);
                funcionario.cargo = dr.GetString(21);

                /*
                funcionario.dataNascimento = dr.GetDateTime(2);
                funcionario.RG = dr.GetString(4);
                funcionario.sexo = dr.GetChar(5);
                funcionario.estadoCivil = dr.GetString(6);
                funcionario.CTPS = dr.GetString(9);
                funcionario.CodFuncionario = dr.GetInt32(0);
                */

                return funcionario;
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

    }
}
