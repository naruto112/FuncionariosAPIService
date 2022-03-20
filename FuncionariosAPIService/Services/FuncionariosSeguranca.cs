using FuncionariosAPIService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuncionariosAPIService.Services
{
    public class FuncionariosSeguranca
    {
        public static bool Login(string login, string senha)
        {
           FuncionarioDbContext entities = new FuncionarioDbContext();
           return entities.Usuarios.Any(user => user.Login.Equals(login, StringComparison.OrdinalIgnoreCase) && user.Senha == senha);
        }
    }
}