using Gol.Domain.Entities;
using Gol.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Gol.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        private readonly IPassengerService _service;

        public PassengersController(IPassengerService service)
        {
            _service = service;
        }


        [HttpPost]
        public void Post(Passenger passenger)
        {
            _service.InsertPassenger(passenger);
        }

        [HttpPost]
        public void InsertPassengerToAirPlane(PassengerToAirplane request)
        {
            _service.InsertPassengerToAirPlane(request);
        }

        [HttpPut]
        public void ChangePassenger(int id, int idAirplane)
        {
            _service.ChangePassenger(id, idAirplane);
        }

        [HttpGet]
        public IEnumerable<Passenger> ListAllPassengerByAirplane(int idAirplane)
        {
            return _service.ListAllPassengerByAirplane(idAirplane);
        }
    }
}
