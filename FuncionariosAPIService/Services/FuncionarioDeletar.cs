using FuncionariosAPIService.Interfaces;
using FuncionariosAPIService.Models;
using FuncionariosAPIService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuncionariosAPIService.Services
{
    public class FuncionarioDeletar
    {
        private IFuncionario _funcionarioRepository;

        public FuncionarioDeletar(IFuncionario funcionarioRepository)
        {
            this._funcionarioRepository = funcionarioRepository;
        }

        public bool execute(int funcionarioID)
        {
            _funcionarioRepository.DeletarFuncionario(funcionarioID);
            _funcionarioRepository.SalvarFuncionario();

            return true;
        }
    }
}