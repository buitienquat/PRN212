using Demo31App.BusinessObjectsLayer;
using Demo31App.RepositoriesLayer;
using Demo31App.ServicesLayer;

namespace Demo31App
{
    public class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine("Please choose option:");
            Console.WriteLine("1 - Show all airline");
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
        static void Main(string[] args)
        {
            IAirlineService iairlineService = new AirlineService();
            int userchoice = 0;
            int ID = 0; // Khởi tạo giá trị cho biến ID
            string Name = "", Code = "", Country = ""; // Khởi tạo giá trị cho các biến chuỗi
            Airline bay = null; // Khởi tạo giá trị cho biến airline
            do
            {
                userchoice = GetUserChoice();
                Console.WriteLine($"Your choice: {userchoice}");
                switch (userchoice)
                {
                    case 1: showAllAriline(); break;
                    case 2: EnterAriline(); AddAriline(bay); showAllAriline(); break;
                    case 3: EnterAriline(); UpdateAriline(bay); showAllAriline(); break;
                    case 4: EnterAriline(); DeleteAriline(bay); showAllAriline(); break;
                    case 5: EnterAriline(); SearchByArilineId(ID); break;
                }
            } while (userchoice > 0 && userchoice < 6);
            void showAllAriline()
            {
                List<Airline> airlines = iairlineService.GetAirlines();
                foreach (Airline bay in airlines)
                {
                    Console.WriteLine(bay.ToString());
                }
            }
            void EnterAriline()
            {
                Console.Write("Enter airline id: ");
                int.TryParse(Console.ReadLine(), out ID);
                Console.Write("Enter airline name: ");
                Name = Console.ReadLine();
                Console.Write("Enter airline code: ");
                Code = Console.ReadLine();
                Console.Write("Enter airline country: ");
                Country = Console.ReadLine();
            }
            void SearchByArilineId(int id)
            {
                Airline? bay = iairlineService.GetAirlineById(ID);
                Console.WriteLine(bay?.ToString());
            }

            void DeleteAriline(Airline bay)
            {
                iairlineService.DeleteAirline(bay);
            }

             void UpdateAriline(Airline bay)
            {
                iairlineService.UpdateAirline(bay);
            }

           void AddAriline(Airline bay)
            {
                iairlineService.InsertAirline(bay);
            }
        } 
    }
}
