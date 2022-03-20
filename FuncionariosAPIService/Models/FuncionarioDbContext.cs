using System.Data.Entity;

namespace FuncionariosAPIService.Models
{
    public class FuncionarioDbContext: DbContext
    {
        public FuncionarioDbContext() : base("name=FuncionarioDBContext") { }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}