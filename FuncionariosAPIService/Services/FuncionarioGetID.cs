using FuncionariosAPIService.Interfaces;
using FuncionariosAPIService.Models;
using FuncionariosAPIService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuncionariosAPIService.Services
{
    public class FuncionarioGetID
    {
        private IFuncionario _funcionarioRepository;

        public FuncionarioGetID(IFuncionario funcionarioRepository)
        {
            this._funcionarioRepository = funcionarioRepository;
        }

        public Funcionario execute(int funcionarioID)
        {
            return (Funcionario)_funcionarioRepository.GetFuncionarioPorID(funcionarioID);
        }
    }
}