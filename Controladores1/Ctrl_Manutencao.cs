using Business;
using Models;
using System;

namespace Controladores
{
    public class Ctrl_Manutencao
    {
        public bool CadManutencao(string Placa, string Motivo, DateTime Data, string Empresa, string Observacoes, decimal RegistroMecanica)
        {

            try
            {
                Manutencao manutencao = new Manutencao();

                manutencao.placaVeiculo = Placa;
                manutencao.motivoAgenda = Motivo;
                manutencao.dataManutencao = Data.Date;
                manutencao.empresa = Empresa;
                manutencao.observacoes = Observacoes;
                manutencao.registroMecanica = RegistroMecanica;

                Mdl_Manutencao cadManutencao = new Mdl_Manutencao();
                bool cadastro = cadManutencao.CadManutencao(manutencao);

                if (cadastro)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
            
        }
        
        public bool InativarManutencao(int CodManutencao)
        {
            try
            {
                Mdl_Manutencao excluirManutencao = new Mdl_Manutencao();
                bool excluir = excluirManutencao.ExcluirManutencao(CodManutencao);

                if(excluir)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
