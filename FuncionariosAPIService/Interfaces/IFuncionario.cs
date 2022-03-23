using FuncionariosAPIService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosAPIService.Interfaces
{
    public interface IFuncionario: IDisposable
    {
        IEnumerable<Funcionario> GetFuncionarios();
        Funcionario GetFuncionarioPorID(int funcionarioID);
        void InserirFuncionario(Funcionario funcionario);
        void DeletarFuncionario(int funcionarioID);
        void AtualizarFuncionario(Funcionario funcionario);
        bool ExistsFuncionario(Funcionario funcionario);
        void SalvarFuncionario();
    }
}
