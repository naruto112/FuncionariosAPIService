using FuncionariosAPIService.Interfaces;
using FuncionariosAPIService.Models;
using FuncionariosAPIService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuncionariosAPIService.Services
{
    public class FuncionarioExists
    {

        private IFuncionario _funcionarioRepository;

        public FuncionarioExists()
        {
            this._funcionarioRepository = new FuncionarioRepository(new FuncionarioDbContext());
        }

        public bool execute(Funcionario funcionario)
        {
            return (bool)_funcionarioRepository.ExistsFuncionario(funcionario);
        }

    }
}