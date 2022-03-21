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

        public FuncionarioDeletar()
        {
            this._funcionarioRepository = new FuncionarioRepository(new FuncionarioDbContext());
        }

        public void execute(int funcionarioID)
        {
            _funcionarioRepository.DeletarFuncionario(funcionarioID);
            _funcionarioRepository.SalvarFuncionario();
        }
    }
}