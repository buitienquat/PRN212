using System;
namespace homework_if_else
{
    class HowKteam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Kéo Búa Bao");
            Console.WriteLine("Kéo là 1");
            Console.WriteLine("Búa là 2");
            Console.WriteLine("Bao là 3");
            Console.Write("Enter option: ");
            String input = Console.ReadLine();
            int option;
 
            if (int.TryParse(input, out option) &&(option == 1 || option == 2 || option == 3))
            {
                Random rand = new Random();
                int randomNumber = rand.Next(1, 4);
                if (randomNumber == 1)
                {
                    Console.WriteLine("Kéo");
                }
                else if (randomNumber == 2)
                {
                    Console.WriteLine("Búa");
                }
                else if (randomNumber == 3)
                {
                    Console.WriteLine("Bao");
                }
                // xử lý logic thắng thua
                if (option == randomNumber)
                {
                    Console.WriteLine("hoà");
                }else if (
                            //bao va bua
                            (option == 1 && randomNumber == 3) ||
                            //bua va keo
                            (option == 2 && randomNumber == 1) ||
                            //keo va bao
                            (option == 3 && randomNumber == 2)
                          ){
                    Console.WriteLine("You Win");
                }else
                {
                    Console.WriteLine("You Lose");
                }
            }
            else
            {
                Console.WriteLine("input error,Enter number");
            }           
         
        }
    }
}