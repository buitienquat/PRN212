using System;
namespace forbasic
{
    class program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            char c = '*';
            char d = ' ';
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    //if (i % (a - 1) == 0 || ((i % (a - 1) != 0) && (j % (b - 1) == 0)))
                    if (i % (a - 1) == 0 || ((i % (a - 1) != 0) && (j % (b - 1) == 0)))
                    {
                        Console.Write(c);
                    }
                    else
                    {
                        Console.Write(d);
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}