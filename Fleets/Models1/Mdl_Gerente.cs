using Business;
using BDClasses;

namespace Models
{
    class Mdl_Gerente
    {
        Ctrl_BD conexao = new Ctrl_BD();

        public bool CadastrarGerente(Funcionario Funcionario)
        {
            try
            {
                Mdl_Funcionario func = new Mdl_Funcionario();
                func.CadastrarFuncionario(Funcionario);
                return true;

            }
            catch
            {
                return false;
            }
        }

        
    }
}
