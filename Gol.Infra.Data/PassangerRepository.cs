using System.Collections.Generic;
using Gol.Domain.Entities;
using Gol.Domain.Repositories;

namespace Gol.Infra.Data
{
    public class PassengerRepository : BaseRepository, IPassengerRepository
    {
        public void Insert(Passenger passenger)
        {
            throw new System.NotImplementedException();
        }

        public void InsertToAirplane(PassengerToAirplane passengerToAirplane)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Passenger> ListAllByAirplane(int idAirplane)
        {
            throw new System.NotImplementedException();
        }
    }
}
