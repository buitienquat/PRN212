using Demo31Appp.BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo31Appp.RepositoriesLayer
{
    public interface IAirlineRepository
    {
        List<Airline> GetAllAirlines();// lớp interface lấy dữ liệu của airline về
        void InsertAirline(Airline airline);
        void UpdateAirline(Airline airline);
        void DeleteAirline(Airline airline);
        Airline? GetAirlineById(int id);
    }
}
