using Demo31App.BusinessObjectsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo31App.RepositoriesLayer
{
    public interface IAirlineRepository
    {
        List<Airline> GetAirlines();
        void UpdateAirline(Airline bay);//edit
        void DeleteAirline(Airline bay);//remove
        void InsertAirline(Airline bay);//add
        Airline? SearchByIdAirline(int id);//search by id
    }
}
