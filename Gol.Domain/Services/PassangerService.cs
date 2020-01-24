using System;
using System.Collections.Generic;
using Gol.Domain.Entities;
using Gol.Domain.Repositories;

namespace Gol.Domain.Services
{
    public class PassengerService : IPassengerService
    {
        private readonly IPassengerRepository _passengerRepository;

        public PassengerService(IPassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }


        public void ChangePassenger(int id, int idAirplane)
        {
            //TODO: understand bussiness logic
            throw new NotImplementedException();
        }

        public void InsertPassenger(Passenger passenger)
        {
            _passengerRepository.Insert(passenger);
        }

        public void InsertPassengerToAirPlane(PassengerToAirplane passengerToAirplane)
        {
            _passengerRepository.InsertToAirplane(passengerToAirplane);
        }

        public IEnumerable<Passenger> ListAllPassengerByAirplane(int idAirplane)
        {
            return _passengerRepository.ListAllByAirplane(idAirplane);
        }
    }
}
