using Demo31App.BusinessObjectsLayer;
using Demo31App.DataAccessObjectsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo31App.RepositoriesLayer
{
    public class AirlineRepository : IAirlineRepository
    {
        public void DeleteAirline(Airline bay) => AirlineDAO.DeleteAirline(bay);


        public List<Airline> GetAirlines() => AirlineDAO.GetAirline();


        public void InsertAirline(Airline bay) => AirlineDAO.InsertAirline(bay);


        public Airline? SearchByIdAirline(int id) => AirlineDAO.SearchByIdAirline(id);


        public void UpdateAirline(Airline bay) => AirlineDAO.UpdateAirline(bay);

    }
}
