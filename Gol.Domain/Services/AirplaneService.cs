using Gol.Domain.Repositories;
using System.Collections.Generic;

namespace Gol.Domain.Services
{
    public class AirplaneService : IAirplaneService
    {
        private readonly IAirplaneRepository _airplaneRepository;

        public AirplaneService(IAirplaneRepository airplaneRepository)
        {
            _airplaneRepository = airplaneRepository;
        }


        public Airplane Find(int id)
        {
            return _airplaneRepository.FindAirplane(id);
        }

        public IEnumerable<Airplane> GetAll()
        {
            return _airplaneRepository.GetAirplanes();
        }

        public void InsertAirplane(Airplane request)
        {
            _airplaneRepository.InsertAirplane(request);
        }
    }
}
