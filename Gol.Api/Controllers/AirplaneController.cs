using Gol.Domain;
using Gol.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Gol.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private readonly IAirplaneService _service;

        public AirplaneController(IAirplaneService service)
        {
            _service = service;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Airplane>> Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Airplane> Get(int id)
        {
            Airplane airplane = _service.Find(id);

            if (airplane == null)
                return NotFound(airplane);
            else
                return Ok(airplane);
        }

        [HttpPost]
        public ActionResult Post(Airplane request)
        {
            _service.InsertAirplane(request);

            return Ok();
        }
    }
}