using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApp.Mockup.Contracts;
using WebApp.Mockup.DataAccess;
using System.Linq;

namespace WebApp.Mockup.BusinessModule.Test.IntegrationTests
{
    [TestClass]
    public class BusinessModuleManagerFixture
    {
        [TestMethod]
        public void GetAllParents_Success()
        {
            // Assign
            IUnitOfWork context = new UnitOfWork(new WebAppDBContext());

            // Act
            var parents = context.Parents.GetAll().ToList();


            // Assert
            Assert.IsTrue(parents.Count > 0);
        }
    }
}
