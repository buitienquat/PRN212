using Demo31Appp.BusinessObjectLayer;
using Demo31Appp.RepositoriesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo31Appp.ServicesLayer
{
    // kế thừa lớp interface IAirlineService
    public class AirlineService : IAirlineService
    {
        private readonly IAirlineRepository iAirlineRepository;//lấy lớp interface của repos có sẵn các phương thức để đưa qua sử dụng qua airlineService
        public AirlineService()
        {
            iAirlineRepository = new AirlineRepository();
        }
        public void DeleteAirline(Airline airline)
        {
            iAirlineRepository.DeleteAirline(airline);
        }

        public Airline? GetAirlineById(int id)
        {
            return iAirlineRepository.GetAirlineById(id);
        }

        public List<Airline> GetAirlines()
        {
            return iAirlineRepository.GetAllAirlines();
        }

        public void InsertAirline(Airline airline)
        {
            iAirlineRepository.InsertAirline(airline);
        }

        public void UpdateAirline(Airline airline)
        {
            iAirlineRepository.UpdateAirline(airline);
        }
    }
}
