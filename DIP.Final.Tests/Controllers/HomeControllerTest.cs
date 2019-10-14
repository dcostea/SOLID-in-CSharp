using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DIP.Final.Controllers;
using DIP.Final.Models;
using Moq;
using System.Web.Mvc;

namespace DIP.Final.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private Mock<IPetRepository> dogRepositoryMock;

        [TestMethod]
        public void PetControllerMocked()
        {
            // Arrange
            dogRepositoryMock = new Mock<IPetRepository>();
            IPetRepository petRepository = dogRepositoryMock.Object;
            dogRepositoryMock.Setup(call => call.GetAll())
                .Returns(new List<Pet> { new Pet { Age = 2, Name = "PhiPhi" } });
            var controller = new HomeController(dogRepositoryMock.Object);

            // Act
            var result = controller.Index() as ViewResult;
            var pets = result.Model as List<Pet>;

            // Assert
            Assert.AreEqual(1, pets.Count());
        }
    }
}
