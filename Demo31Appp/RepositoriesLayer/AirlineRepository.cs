using Demo31Appp.BusinessObjectLayer;
using Demo31Appp.DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo31Appp.RepositoriesLayer
{
    //kế thừa các lớp interface
    // sử dụng các phương thức từ AirlineDAO
    
    public class AirlineRepository : IAirlineRepository
    {
        public void DeleteAirline(Airline airline) => AirlineDAO.DeleteAirline(airline);

        public Airline? GetAirlineById(int id) => AirlineDAO.SearchById(id);

        public List<Airline> GetAllAirlines() => AirlineDAO.GetAirlines();

        public void InsertAirline(Airline airline) => AirlineDAO.InsertAirline(airline);

        public void UpdateAirline(Airline airline) => AirlineDAO.UpdateAirline(airline);
    }
}
