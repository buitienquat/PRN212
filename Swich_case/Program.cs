using System;
using System.Diagnostics;
namespace Switch_case
{
    class Program
    {
        #region Switch_case if else xử lý ngoại lệ
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter number: ");
        //    String input = Console.ReadLine();
        //    int k;
        //    if (int.TryParse(input, out k))
        //    {
        //        switch (k)
        //        {
        //            case 0: Console.WriteLine("hi"); break;
        //            case 1: Console.WriteLine("chao cau"); break;
        //            case 2: Console.WriteLine("case 2 ne"); break;
        //            default: Console.WriteLine("error"); break;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Khong duoc nhap chuoi");
        //    }

        //}
        #endregion
        #region switch_case do while xử lý ngoại lệ
        static void Main(string[] args)
        {
            int k;
            bool isvaild;
            do
            {
                Console.Write("Enter number: ");
                String input = Console.ReadLine();
                isvaild = int.TryParse(input, out k); //=> true nếu chuyển đổi thành công, false nếu thất bại
                if (!isvaild) // nếu isvaild là false
                {
                    Console.WriteLine("Error, Please enter again !!!");
                }
            } while (!isvaild); // lặp lại khi isvaild là false

            // Sau khi ra khỏi vòng lặp, isvaild phải là true, tức là người dùng đã nhập một số nguyên hợp lệ
            switch (k)
            {
                case 0: Console.WriteLine("case 0"); break;
                case 1: Console.WriteLine("case 1"); break;
                case 2: Console.WriteLine("case 2"); break;
                default: Console.WriteLine("Error"); break;
            }
        }

    }
    #endregion
}
