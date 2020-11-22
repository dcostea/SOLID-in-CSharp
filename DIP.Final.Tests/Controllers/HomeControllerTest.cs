using System.Collections.Generic;
using System.Linq;
using DIP.Final.Controllers;
using DIP.Final.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace DIP.Final.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        private Mock<IDogRepository> dogRepositoryMock;

        [Test]
        public void Controller_GetAll_ReturnValidList()
        {
            // Arrange
            dogRepositoryMock = new Mock<IDogRepository>();
            IDogRepository petRepository = dogRepositoryMock.Object;
            dogRepositoryMock.Setup(call => call.GetAll())
                .Returns(new List<Dog> { new Dog(2, "PhiPhi", "smile") });
            var controller = new HomeController(dogRepositoryMock.Object);

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
            dogRepositoryMock = new Mock<IDogRepository>();
            IDogRepository petRepository = dogRepositoryMock.Object;
            dogRepositoryMock.Setup(call => call.GetAll())
                .Returns(new List<Dog> { new Dog(2, "PhiPhi", "smile") });
            var controller = new HomeController(dogRepositoryMock.Object);

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
            dogRepositoryMock = new Mock<IDogRepository>();
            IDogRepository petRepository = dogRepositoryMock.Object;
            dogRepositoryMock.Setup(call => call.GetAll())
                .Returns(new List<Dog> { new Dog(2, "PhiPhi", "smile") });
            var controller = new HomeController(dogRepositoryMock.Object);

            var dog = new Dog(7, "Spot", "duck");

            // Act
            var response = controller.Post(dog);
            var result = response as CreatedResult;

            // Assert
            Assert.IsTrue(result.StatusCode == 201);
        }
    }
}
