using System;
namespace boxing
{
    class hi
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            i = 456;
            Console.WriteLine("the value-type value ={0}", i);
            Console.WriteLine("the object-type value ={0}", o);
     
        }
    }
}