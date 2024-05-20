using Demo31App.BusinessObjectsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo31App.ServicesLayer
{
    public interface IAirlineService
    {
        List<Airline> GetAirlines();
        void InsertAirline(Airline bay);
        void UpdateAirline(Airline bay);
        void DeleteAirline(Airline bay);
        Airline? GetAirlineById(int id);
    }
}
