using Gol.Api.Controllers;
using Gol.Api.FakeServices;
using Gol.Domain;
using Gol.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace Gol.Api.Tests
{
    public class AirplaneControllerTest
    {
        private readonly AirplaneController _controller;
        private readonly IAirplaneService _service;
        private readonly Airplane airplaneToBeInserted = new Airplane { Id = 4, Model = "777", Prefix = "02XC545" };

        public AirplaneControllerTest()
        {
            _service = new AirplaneServiceFake();
            _controller = new AirplaneController(_service);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllAirplanes()
        {
            // Act
            var okResult = _controller.Get().Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<Airplane>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void Get_WhenCalled_FindAnAirplane()
        {
            var ok = _controller.Get(1).Result as OkObjectResult;

            Assert.NotNull(ok.Value as Airplane);
        }

        [Fact]
        public void Post_WhenCalled_InsertNewAirplane()
        {
            // Act
            ActionResult actionResult = _controller.Post(airplaneToBeInserted);

            // Assert
            Assert.IsType<OkResult>(actionResult);

            var ok = _controller.Get(airplaneToBeInserted.Id).Result as OkObjectResult;

            Assert.NotNull(ok.Value as Airplane);
        }
    }
}
