using System.Data.SqlClient;

using Business;

namespace BDClasses
{
    class Ctrl_Obj
    {
        public Empresa ObjEmpresaBD(SqlDataReader DataReader)
        {
            try
            {
                Empresa empresa = new Empresa();
                empresa.nomeFantasia = DataReader.GetString(0);
                empresa.razaoSocial = DataReader.GetString(1);
                empresa.NIRE = DataReader.GetString(2);
                empresa.CNPJ = DataReader.GetString(3);
                empresa.login = DataReader.GetString(5);
                empresa.senha = DataReader.GetString(6);

                return empresa;
            }
            catch
            {
                return null;
            }
        }

        public Funcionario ObjFuncionarioBD(SqlDataReader DataReader)
        {
            try
            {
                Funcionario funcionario = new Funcionario(DataReader.GetString(0), DataReader.GetDateTime(1), DataReader.GetString(2), DataReader.GetString(3), DataReader.GetString(4), DataReader.GetString(5), DataReader.GetString(6), DataReader.GetChar(7), DataReader.GetString(8), DataReader.GetString(9), DataReader.GetString(10), DataReader.GetString(11), DataReader.GetString(12), DataReader.GetString(13));
                return funcionario;
            }
            catch
            {
                return null;
            }
        }
    }

}
