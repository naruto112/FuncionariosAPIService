using FuncionariosAPIService.Interfaces;
using FuncionariosAPIService.Models;
using FuncionariosAPIService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuncionariosAPIService.Services
{
    public class FuncionarioInserir
    {
        private IFuncionario _funcionarioRepository;

        public FuncionarioInserir(IFuncionario funcionarioRepository)
        {
            this._funcionarioRepository = funcionarioRepository;
        }

        public bool execute(Funcionario funcionario)
        {
            _funcionarioRepository.InserirFuncionario(funcionario);
            _funcionarioRepository.SalvarFuncionario();

            return true;
        }
    }
}