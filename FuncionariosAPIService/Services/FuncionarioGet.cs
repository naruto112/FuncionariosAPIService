using FuncionariosAPIService.Interfaces;
using FuncionariosAPIService.Models;
using FuncionariosAPIService.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuncionariosAPIService.Services
{
    public class FuncionarioGet
    {
        private IFuncionario _funcionarioRepository;

        public FuncionarioGet(IFuncionario funcionarioRepository)
        {
            this._funcionarioRepository = funcionarioRepository;
        }

        public virtual  List<Funcionario> execute()
        {
            return (List<Funcionario>)_funcionarioRepository.GetFuncionarios();
        }
    }
}