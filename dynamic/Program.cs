using System;
namespace dynamic
{
    class hi
    {
        static void Main(String[] args)
        {
            dynamic myValue = 0;
            Console.WriteLine("myValue is a: {0}", myValue.GetType().Name);

            myValue = true;
            Console.WriteLine("myValue is a: {0}", myValue.GetType().Name);

            myValue = "hicau";
            Console.WriteLine("myValue is a: {0}", myValue.GetType().Name);

            myValue = 0.5;
            Console.WriteLine("myValue is a: {0}", myValue.GetType().Name);
        }
    }
}