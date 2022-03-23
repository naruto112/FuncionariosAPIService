using FuncionariosAPIService.Interfaces;
using FuncionariosAPIService.Models;
using FuncionariosAPIService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuncionariosAPIService.Services
{
    public class FuncionarioAtualizar
    {
        private IFuncionario _funcionarioRepository;

        public FuncionarioAtualizar(IFuncionario funcionarioRepository)
        {
            this._funcionarioRepository = funcionarioRepository;
        }

        public Funcionario execute(Funcionario funcionario)
        {
            _funcionarioRepository.AtualizarFuncionario(funcionario);
            _funcionarioRepository.SalvarFuncionario();

            return funcionario;
        }

    }
}