using FuncionariosAPIService.Interfaces;
using FuncionariosAPIService.Models;
using FuncionariosAPIService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuncionariosAPIService.Services
{
    public class FuncionarioGet
    {
        private IFuncionario _funcionarioRepository;

        public FuncionarioGet()
        {
            this._funcionarioRepository = new FuncionarioRepository(new FuncionarioDbContext());
        }

        public List<Funcionario> execute()
        {
            return (List<Funcionario>)_funcionarioRepository.GetFuncionarios();
        }
    }
}