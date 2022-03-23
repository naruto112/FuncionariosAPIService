using FuncionariosAPIService.Interfaces;
using FuncionariosAPIService.Models;
using FuncionariosAPIService.Repositories;
using FuncionariosAPIService.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace FuncionariosAPIService.Controllers
{
    [Authorize]
    public class FuncionariosController : ApiController
    {

        private FuncionarioDbContext db = new FuncionarioDbContext();
        private FuncionarioGet _funcionarioGet = new FuncionarioGet(new FuncionarioRepository(new FuncionarioDbContext()));
        private FuncionarioGetID _funcionarioGetID = new FuncionarioGetID(new FuncionarioRepository(new FuncionarioDbContext()));
        private FuncionarioInserir _funcionarioInserir = new FuncionarioInserir(new FuncionarioRepository(new FuncionarioDbContext()));
        private FuncionarioAtualizar _funcionarioAtualizar = new FuncionarioAtualizar(new FuncionarioRepository(new FuncionarioDbContext()));
        private FuncionarioExists _funcionarioExists = new FuncionarioExists(new FuncionarioRepository(new FuncionarioDbContext()));
        private FuncionarioDeletar _funcionarioDeletar = new FuncionarioDeletar(new FuncionarioRepository(new FuncionarioDbContext()));


        // GET: api/Funcionarios      
        public List<Funcionario> GetFuncionarios()
        {
            return (List<Funcionario>)_funcionarioGet.execute();
        }
        // GET: api/Funcionarios/5
        [ResponseType(typeof(Funcionario))]
        public IHttpActionResult GetFuncionario(int id)
        {
            Funcionario funcionario = _funcionarioGetID.execute(id);
            if (funcionario == null)
            {
                return NotFound();
            }
            return Ok(funcionario);
        }
        // PUT: api/Funcionarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFuncionario(int id, Funcionario funcionario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != funcionario.FuncionarioId)
            {
                return BadRequest();
            }
            
            try
            {
                _funcionarioAtualizar.execute(funcionario);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_funcionarioExists.execute(funcionario))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return StatusCode(HttpStatusCode.NoContent);
        }
        // POST: api/Funcionarios
        [ResponseType(typeof(Funcionario))]
        public IHttpActionResult PostFuncionario(Funcionario funcionario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _funcionarioInserir.execute(funcionario);
            return CreatedAtRoute("DefaultApi", new { id = funcionario.FuncionarioId }, funcionario);
        }
        // DELETE: api/Funcionarios/5
        [ResponseType(typeof(Funcionario))]
        public IHttpActionResult DeleteFuncionario(int id)
        {
            Funcionario funcionario = _funcionarioGetID.execute(id);

            if (funcionario == null)
            {
                return NotFound();
            }
            _funcionarioDeletar.execute(funcionario.FuncionarioId);
            return Ok(funcionario);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
