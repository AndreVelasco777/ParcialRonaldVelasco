using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialRonaldVelasco.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGet()
        {
            //Arrange
            CountriesController controller = new CountriesController();
            //Act
            var lista = controller.GetCountries();
            //Assert
            Assert.IsNotNull(lista);
        }
    }
}
