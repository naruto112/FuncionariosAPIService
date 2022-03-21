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

        public FuncionarioGetID()
        {
            this._funcionarioRepository = new FuncionarioRepository(new FuncionarioDbContext());
        }

        public Funcionario execute(int funcionarioID)
        {
            return (Funcionario)_funcionarioRepository.GetFuncionarioPorID(funcionarioID);
        }
    }
}