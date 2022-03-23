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
using System;

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

            var response = serviceFuncionario.execute();

            Assert.IsNotEmpty(response);

        }

        [TestMethod]
        public void FuncionarioGetID()
        {

            var funcionarioMock = new FuncionarioRepository(new FuncionarioDbContext());
            var serviceFuncionario = new FuncionarioGetID(funcionarioMock);

            var response = serviceFuncionario.execute(1);

            Assert.IsNotNull(response.FuncionarioId);
            Assert.IsNotEmpty(response.Nome);
            Assert.IsNotEmpty(response.Email);
            Assert.IsNotEmpty(response.Salario);
            Assert.IsNotEmpty(response.Setor);
            Assert.IsNotEmpty(response.Sexo);

        }

        [TestMethod]
        public void FuncionarioAtualizar()
        {
            var funcionario = new Funcionario()
            {
                FuncionarioId = 1,
                Nome = "Gumercindo",
                Email = "gumercindo.teste@email.com",
                Salario = "10.000",
                Setor = "CEO",
                Sexo = "masculino"
            };



            var funcionarioMock = new FuncionarioRepository(new FuncionarioDbContext());
            var serviceFuncionario = new FuncionarioAtualizar(funcionarioMock);

            var response = serviceFuncionario.execute(funcionario);


            Assert.IsNotNull(response.FuncionarioId);
            Assert.IsNotEmpty(response.Nome);
            Assert.IsNotEmpty(response.Email);
            Assert.IsNotEmpty(response.Salario);
            Assert.IsNotEmpty(response.Setor);
            Assert.IsNotEmpty(response.Sexo);


        }

        [TestMethod]
        public void FuncionarioInserir()
        {
            bool response = false;
            var funcionario = new Funcionario()
            {
                Nome = "Armarindo da Silveira",
                Email = "armarindo.silveira@email.com",
                Salario = "10.000",
                Setor = "CEO",
                Sexo = "masculino"
            };

            var funcionarioMock = new FuncionarioRepository(new FuncionarioDbContext());
            var serviceFuncionarioInserir = new FuncionarioInserir(funcionarioMock);

            var serviceFuncionarioExists = new FuncionarioExists(funcionarioMock);

            if (!serviceFuncionarioExists.execute(funcionario))
            {
                response = serviceFuncionarioInserir.execute(funcionario);
            }

            Assert.AreEqual(true, response);

        }

        [TestMethod]
        public void FuncionarioDeletar()
        {
            //var funcionarioMock = new FuncionarioRepository(new FuncionarioDbContext());
            //var serviceFuncionario = new FuncionarioDeletar(funcionarioMock);

            //var response = serviceFuncionario.execute(1004);

            //Assert.IsTrue(response);

        }
        
    }
}
