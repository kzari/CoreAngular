using System.Collections.Generic;

namespace Gol.Domain.Repositories
{
    public interface IAirplaneRepository
    {
        IEnumerable<Airplane> GetAirplanes();
        Airplane FindAirplane(int id);
        void InsertAirplane(Airplane request);
    }
}
