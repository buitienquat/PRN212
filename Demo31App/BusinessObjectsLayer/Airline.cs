
namespace Demo31App.BusinessObjectsLayer
{
    public class Airline
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Airline (ID: {ID}, Name: {Name}, Code: {Code}, Country: {Country})";
        }
    }
}