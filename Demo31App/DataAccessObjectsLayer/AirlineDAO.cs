using Demo31App.BusinessObjectsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo31App.DataAccessObjectsLayer
{
    public static class AirlineDAO
    {
        private static List<Airline> airlines = new List<Airline>
        {
            new Airline(){ID = 1, Name = "Bui Tien Quat",Code = "139", Country = "VietNam"},
            new Airline(){ID = 2, Name = "Doan Anh Duc",Code = "119", Country = "VietNam"},
            new Airline(){ID = 3, Name = "Nguyen Manh Dung",Code = "113", Country = "VietNam"}
        };
        public static List<Airline> GetAirline() { return airlines; }
        //add
        public static void InsertAirline(Airline bay)
        {
            airlines.Add(bay);
        }
        //update
        public static void UpdateAirline(Airline bay)
        {
            foreach (Airline air in airlines.ToList())
            {   
                if(air.ID == bay.ID)
                {
                    air.ID = bay.ID;
                    air.Name = bay.Name;
                    air.Code = bay.Code;
                    air.Country = bay.Country;
                }
            }
        }
        //delete
        public static void DeleteAirline(Airline bay)
        {
            foreach (Airline air in airlines.ToList())
            {
                if( air.ID == bay.ID)
                {
                    airlines.Remove(air);
                }
            }
        }
        //search theo id
        public static Airline? SearchByIdAirline(int id)
        {
            foreach(Airline air in airlines.ToList())
            {
                if(air.ID == id)
                {
                    return air;
                }
            }
            return null;
        }
    }
}
