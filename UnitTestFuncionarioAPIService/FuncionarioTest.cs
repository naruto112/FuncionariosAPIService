using Moq;
using FuncionariosAPIService.Services;
using FuncionariosAPIService.Models;
using System.Collections.Generic;
using FuncionariosAPIService.Controllers;
using NUnit.Framework;
using FuncionariosAPIService.Repositories;
using System.Web.Services.Description;
using Assert = NUnit.Framework.Assert;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FuncionariosAPIService.Interfaces;

namespace UnitTestFuncionarioAPIService
{
    [TestClass]
    public class FuncionarioTest
    {

        [TestMethod]
        public void FuncionarioGetTest()
        {

            var funcionarioMock = new FuncionarioRepository(new FuncionarioDbContext());
            var serviceFuncionario = new FuncionarioGet(funcionarioMock);

            var res = serviceFuncionario.execute();

            Assert.IsNotEmpty(res);

        }
    }
}
