using System;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Kernel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mochi.Service.Controllers;
using Moq;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Mochi.UnitTests.Controllers
{
    public class UtilsControllerTests
    {
        private Fixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _fixture = new Fixture();
        }

        [Test]
        public async Task Ping_ReturnOk()
        {
            // Arrange
            var utilsControllerSlut = _fixture.Create<UtilsController>();
            
            // Act
            var response = await utilsControllerSlut.Ping();

            // Assert
            Assert.That(response, Is.InstanceOf<OkResult>());
        }

        [Test]
        public async Task Health_ReturnOk()
        {
            // Arrange
            var utilsControllerSlut = _fixture.Create<UtilsController>();

            // Act
            var response = await utilsControllerSlut.GetHealth();

            // Assert
            Assert.That(response, Is.InstanceOf<OkResult>());
        }
    }
}
