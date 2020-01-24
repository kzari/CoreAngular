using System.Collections.Generic;
using Gol.Domain.Entities;

namespace Gol.Domain.Repositories
{
    public interface IPassengerRepository
    {
        void Insert(Passenger passenger);
        void InsertToAirplane(PassengerToAirplane passengerToAirplane);
        IEnumerable<Passenger> ListAllByAirplane(int idAirplane);
    }
}
