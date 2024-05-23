using Demo31Appp.BusinessObjectLayer;
using Demo31Appp.ServicesLayer;
using System;
//DataAccessObjectsLayer: Lớp đối tượng truy cập dữ liệu
//RepositoriesLayer     : Lớp kho lưu trữ
//ServicesLayer         : Lớp dịch vụ
//BusinessObjectLayer   : Lớp xử lý đối tượng
namespace Demo31Appp
{
    public class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine("Please choose option:");
            Console.WriteLine("1 - Show all airlines");
            Console.WriteLine("2 - Add airline");
            Console.WriteLine("3 - Update airline");
            Console.WriteLine("4 - Delete airline");
            Console.WriteLine("5 - Search by id");
            Console.WriteLine("****************************");
            Console.Write("Enter your choice: ");
        }
        static int GetUserChoice()
        {
            PrintMenu();
            int res = 0;
            int.TryParse(Console.ReadLine(), out res);
            return res;
        }
        public static void Main(string[] args)
        {
            IAirlineService iAirlineService = new AirlineService();
            int userChoice = 0;
            int id;
            string name, code, country;
            Airline airline;
            do
            {
                userChoice = GetUserChoice();
                Console.WriteLine($"You Choice: {userChoice}");
                switch (userChoice)
                {
                    case 1: ShowAllAirline(); break;
                    case 2: EntetAirline(); AddAirline(airline); ShowAllAirline(); break;
                    case 3: EntetAirline(); UpdateAirline(airline); ShowAllAirline(); break;
                    case 4: EntetAirlineId(); DeleteAirline(airline); ShowAllAirline(); break;
                    case 5: EntetAirlineId(); SearchAirlineByID(id); break;
                }
            } while (userChoice > 0 && userChoice < 6);
            //show full
            void ShowAllAirline()
            {
                List<Airline> airlines = iAirlineService.GetAirlines();
                foreach (Airline air in airlines)
                {
                    Console.WriteLine(air.ToString());
                }
            }
            //Enter 
            void EntetAirline()
            {
                Console.Write("Enter airline id: ");
                int.TryParse(Console.ReadLine(), out id);
                Console.Write("Enter airline name: ");
                name = Console.ReadLine();
                Console.Write("Enter airline code: ");
                code = Console.ReadLine();
                Console.Write("Enter airline country: ");
                country = Console.ReadLine();
                airline = new Airline() { ID = id, Name = name, Code = code, Country = country };
            }
           void EntetAirlineId()
            {
                Console.Write("Enter airline id: ");
                int.TryParse(Console.ReadLine(), out id);
                airline = new Airline() { ID = id};
            }
            //add
            void AddAirline(Airline airline)
            {
                iAirlineService.InsertAirline(airline);
            }
            //delete
            void DeleteAirline(Airline airline)
            {
                iAirlineService.DeleteAirline(airline);
            }
            //update
            void UpdateAirline(Airline airline)
            {
                iAirlineService.UpdateAirline(airline);
            }
            void SearchAirlineByID(int id)
            {
                Airline? air = iAirlineService.GetAirlineById(id);
                Console.WriteLine(air?.ToString());
            }
        }

       
    }
}