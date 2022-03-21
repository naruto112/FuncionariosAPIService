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

        public FuncionarioAtualizar()
        {
            this._funcionarioRepository = new FuncionarioRepository(new FuncionarioDbContext());
        }

        public void execute(Funcionario funcionario)
        {
            _funcionarioRepository.AtualizarFuncionario(funcionario);
            _funcionarioRepository.SalvarFuncionario();
        }

    }
}