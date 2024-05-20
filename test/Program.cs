using System;
namespace hi
{
    // lệnh bên trong thực hiện trước rồi mới đến lệnh bên ngoài
    class runhi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         test");
            //Console.Write("Enter name: ");
            //Console.WriteLine("Ten cua ban la: "+ Console.ReadLine());
            //Console.Write("Enter phone number: ");
            //Console.WriteLine("SDT là: "+Console.ReadLine());
            //Console.Write("Enter birth of date: ");
            //Console.WriteLine("date là: " + Console.ReadLine());
            int a = 6; int b = 9;
            Console.WriteLine("a + b = {0} + {1} = {2}", a,b,a+b);
            Console.ReadKey();
        }
    }
}