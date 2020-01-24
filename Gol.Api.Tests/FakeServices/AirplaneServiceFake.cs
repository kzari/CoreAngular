using System.Collections.Generic;
using System.Linq;
using Gol.Domain;
using Gol.Domain.Services;

namespace Gol.Api.FakeServices
{
    internal class AirplaneServiceFake : IAirplaneService
    {
        private readonly IList<Airplane> _airplanes = new List<Airplane>
        {
            new Airplane { Id = 1, Model = "747", Prefix = "02XC54" },
            new Airplane { Id = 2, Model = "737", Prefix = "02XC01" },
            new Airplane { Id = 3, Model = "747", Prefix = "02XC55" }
        };

        public Airplane Find(int id)
        {
            return _airplanes.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Airplane> GetAll()
        {
            return _airplanes;
        }

        public void InsertAirplane(Airplane airplane)
        {
            _airplanes.Add(airplane);
        }
    }
}