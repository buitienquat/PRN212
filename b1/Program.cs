using System;
namespace b1
{
    class hi
    {
        static void Main(string[] args)
        {
            // in ra trên cùng 1 line
            #region Console.Write()
            //console.write("quat");
            //console.write(10);
            //console.write(10.9f);
            //console.write(true);
            //Console.ReadKey();
            #endregion
            //in ra và xuống dòng
            #region Console.WriteLine()

            //Console.WriteLine("chao cau");
            //Console.WriteLine(6);
            //Console.WriteLine(6.5f);
            //int a = 5;
            //Console.WriteLine("a = {0}", a);
            //Console.Write("{0} {1} {2} {3}", 1, 2.5f, true, "quatdz");
            //Console.ReadLine(); // đợi người dùng nhấn phím enter => dừng màn hình lại
            #endregion
            //đọc 1 ký tự => mã ASCII
            #region Console.Read()
            //Console.Write(Console.Read());// Chỉ đọc 1 ký tự đầu tiên từ bàn phím và trả về kiểu số nguyên => mã ASCII
            //Console.ReadKey();// lệnh này dùng với mục đích là dừng màn hình để xem kết quả
            #endregion
            //In ra những gì mình nhập(đọc dữ liệu mình nhập)
            #region Console.ReadLine()

            //Console.Write(Console.ReadLine());
            //Console.ReadKey();

            #endregion

            #region Console.ReadKey()

            //Console.WriteLine("quatdz");
            //Console.ReadKey();// không truyền tham số vào thì mặc định là false
            //Console.ReadKey(false);// hiểu thị phím ấn trên màn hình
            //Console.ReadKey(true); //không hiểu thị phím ấn trên màn hinh
            #endregion
        }
    }
}