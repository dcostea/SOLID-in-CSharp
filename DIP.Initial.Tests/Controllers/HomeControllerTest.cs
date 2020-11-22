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
        //TODO Add BadRequest and other unit tests

        [Test]
        public void Controller_GetAll_ReturnValidList()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var response = controller.GetAll();
            var result = response.Result as OkObjectResult;
            var dogs = result.Value as IEnumerable<Dog>;

            // Assert
            Assert.AreEqual(4, dogs.Count());
        }

        [Test]
        public void Controller_GetByName_ReturnValidItem()
        {
            // Arrange
            var controller = new HomeController();
            var newName = "Spot";

            // Act
            var response = controller.GetByName(newName);
            var result = response.Result as OkObjectResult;
            var dog = result.Value as Dog;

            // Assert
            Assert.IsTrue(dog.Name == newName);
        }

        [Test]
        public void Controller_Insert_Success()
        {
            // Arrange
            var controller = new HomeController();
            var dog = new Dog(7, "Spot", "duck");

            // Act
            var response = controller.Post(dog);
            var result = response as CreatedResult;

            // Assert
            Assert.IsTrue(result.StatusCode == 201);
        }
    }
}
