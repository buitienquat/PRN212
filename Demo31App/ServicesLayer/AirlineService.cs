using Demo31App.BusinessObjectsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo31App.ServicesLayer
{
    internal class AirlineService : IAirlineService
    {
        private readonly IAirlineService iairlineService;   
        public void DeleteAirline(Airline bay)
        {
            iairlineService.DeleteAirline(bay);
        }

        public Airline? GetAirlineById(int id)
        {
            return iairlineService.GetAirlineById(id);
        }

        public List<Airline> GetAirlines()
        {
          return iairlineService.GetAirlines();
        }

        public void InsertAirline(Airline bay)
        {
            iairlineService.InsertAirline(bay);
        }

        public void UpdateAirline(Airline bay)
        {
            iairlineService.UpdateAirline(bay);
        }
    }
}
