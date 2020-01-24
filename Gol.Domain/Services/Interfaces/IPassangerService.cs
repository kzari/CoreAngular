using System.Collections.Generic;
using Gol.Domain.Entities;

namespace Gol.Domain.Services
{
    public interface IPassengerService
    {
        void InsertPassenger(Passenger request);
        void InsertPassengerToAirPlane(PassengerToAirplane request);
        void ChangePassenger(int id, int idAirplane);
        IEnumerable<Passenger> ListAllPassengerByAirplane(int idAirplane);
    }
}