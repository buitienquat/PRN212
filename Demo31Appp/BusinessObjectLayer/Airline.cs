using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo31Appp.BusinessObjectLayer
{
    public class Airline
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public String Code { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"Airline(ID: {ID}, Name: {Name}, Code: {Code}, Country: {Country})";
        }

        public static implicit operator Airline(string v)
        {
            throw new NotImplementedException();
        }
    }
}
