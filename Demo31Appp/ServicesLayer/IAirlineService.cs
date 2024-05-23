using Demo31Appp.BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo31Appp.ServicesLayer
{
    // tạo ra lớp interface cho đỡ phải viết
    public interface IAirlineService
    {
        List<Airline> GetAirlines();
        void InsertAirline(Airline airline);
        void UpdateAirline(Airline airline);
        void DeleteAirline(Airline airline);
        Airline? GetAirlineById(int id);
    }
}
