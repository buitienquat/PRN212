using System;
using System.ComponentModel;
using System.Linq.Expressions;
namespace Goto
{
    class Program
    {
        // goto => tốc biến
        static void Main(string[] args)
        {
            #region vidu1
            //    goto hicau;
            //    Console.WriteLine("hello");
            //hicau:
            //    Console.WriteLine("hi");
            //    // go to hicau sẽ đi thẳng đến hicau, bỏ hết tất cả các lệnh bên trong goto
            #endregion
            #region vidu2
            //int a;
            //String input = Console.ReadLine();
            // bool result = int.TryParse(input,out a);
            //switch (a)
            //{
            //    case 1: Console.WriteLine("case 1"); 
            //        break;
            //    case 2: Console.WriteLine("case 2");
            //        goto case 1;
            //        break;// bỏ qua break => break thừa
            //        case 3: Console.WriteLine("case3"); break;
            //    default: Console.WriteLine("error");break;
            //}
            #endregion
            #region vidu3
            //    int a;
            //    String input = Console.ReadLine();
            //    bool result = int.TryParse(input, out a);
            //    if (a == 2)
            //    {
            //        goto a_is_2;
            //    }
            //    Console.WriteLine("a = 1");
            //a_is_2:
            //    Console.WriteLine("a = 2");

            // a = 2 => Output: a = 2
            // a = 1 => Output: a = 1
            //                  a = 2
            #endregion
            #region vidu4
            //    int a = 1;

            //dichchuyen1:
            //    // a == 2
            //    if(a == 2)
            //    {
            //        // dịch chuyển tới hi 1
            //        goto dichchuyen2;
            //    }
            //    Console.WriteLine("A");
            //dichchuyen2:
            //    Console.WriteLine("B");
            //    goto dichchuyen1;// dịch chuyển tới hi 2
            #endregion
            #region vidu5
            //String name = "bui tien quat";
            //int count = 0;
            //beginloop:// in ra 10 lần
            //count++;
            //if(count < 10)
            //{
            //    Console.WriteLine(name);
            //    goto beginloop;
            //}
            //Console.WriteLine("finished 10 loop");
            #endregion
            #region 
            #endregion
        }
    }
}