using System.Linq;
using DIP.Initial.Models;
using System.Collections.Generic;
using DIP.Initial.Controllers;
using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;

namespace DIP.Initial.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void PetController()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var response = controller.Get();
            var result = response.Result as OkObjectResult;
            var pets = result.Value as IEnumerable<Pet>;

            // Assert
            Assert.AreEqual(4, pets.Count());
        }
    }
}
