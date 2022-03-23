using FuncionariosAPIService.Interfaces;
using FuncionariosAPIService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FuncionariosAPIService.Repositories
{
    public class FuncionarioRepository: IFuncionario
    {
        private FuncionarioDbContext _context;

        public FuncionarioRepository(FuncionarioDbContext funcionarioDbContext)
        {
            this._context = funcionarioDbContext;
        }

        public IEnumerable<Funcionario> GetFuncionarios()
        {
            return _context.Funcionarios.ToList();
        }

        public Funcionario GetFuncionarioPorID(int funcionarioID)
        {
            return _context.Funcionarios.Find(funcionarioID);
        }

        public void InserirFuncionario(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
        }

        public void DeletarFuncionario(int funcionarioID)
        {
            Funcionario funcionario = _context.Funcionarios.Find(funcionarioID);
            _context.Funcionarios.Remove(funcionario);
        }

        public void AtualizarFuncionario(Funcionario funcionario)
        {
            _context.Entry(funcionario).State = EntityState.Modified;
        }

        public bool ExistsFuncionario(Funcionario funcionario)
        {
            return _context.Funcionarios.Count(e => e.FuncionarioId == funcionario.FuncionarioId) > 0;
        }

        public void SalvarFuncionario()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}