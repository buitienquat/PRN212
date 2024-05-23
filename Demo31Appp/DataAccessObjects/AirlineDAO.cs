using Demo31Appp.BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo31Appp.DataAccessObjects
{
    public class AirlineDAO
    {
        private static List<Airline> airlines = new List<Airline>()
        {
            new Airline() {ID = 1, Name = "chaocau1", Code = "113", Country = "VN"},
            new Airline() {ID = 2, Name = "chaocau2", Code = "114", Country = "VN"},
            new Airline() {ID = 3, Name = "chaocau3", Code = "115", Country = "VN"},
        };
        public static List<Airline> GetAirlines() {  return airlines; }
        //add
        public static void InsertAirline(Airline airline)
        {
            airlines.Add(airline);
        }
        //update
        public static void UpdateAirline(Airline airline)
        {
            foreach(Airline air in airlines.ToList())
            {
                if(air.ID == airline.ID)
                {
                    air.Name = airline.Name;
                    air.Code = airline.Code;
                    air.Country = airline.Country;
                    air.ID = airline.ID;
                }
            }
        }
        //delete
        public static void DeleteAirline(Airline airline)
        {
           foreach (Airline air in airlines.ToList())
            {
                if (air.ID == airline.ID)
                {
                    airlines.Remove(air);
                }
            }
        }
        //search by id
        public static Airline? SearchById(int id)
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
