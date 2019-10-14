using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DIP.Initial.Models;
using Moq;
using System.Collections.Generic;
using DIP.Initial.Controllers;
using System.Web.Mvc;

namespace DIP.Initial.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void PetController()
        {
            // Arrange
            var dogRepository = new DogRepository();
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;
            var pets = result.Model as List<Dog>;

            // Assert
            Assert.AreEqual(4, pets.Count());
        }
    }
}
