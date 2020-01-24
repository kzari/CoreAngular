using System.Collections.Generic;

namespace Gol.Domain.Services
{
    public interface IAirplaneService
    {
        IEnumerable<Airplane> GetAll();
        Airplane Find(int id);
        void InsertAirplane(Airplane request);
    }
}