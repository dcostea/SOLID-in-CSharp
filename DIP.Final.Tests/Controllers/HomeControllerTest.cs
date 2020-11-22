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
        private Mock<IPetRepository> dogRepositoryMock;

        [Test]
        public void PetControllerMocked()
        {
            // Arrange
            dogRepositoryMock = new Mock<IPetRepository>();
            IPetRepository petRepository = dogRepositoryMock.Object;
            dogRepositoryMock.Setup(call => call.GetAll())
                .Returns(new List<Pet> { new Pet { Age = 2, Name = "PhiPhi" } });
            var controller = new HomeController(dogRepositoryMock.Object);

            // Act
            var response = controller.Get();
            var result = response.Result as OkObjectResult;
            var pets = result.Value as IEnumerable<Pet>;

            // Assert
            Assert.AreEqual(1, pets.Count());
        }
    }
}
