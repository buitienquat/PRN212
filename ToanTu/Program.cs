using System;
namespace hi
{
    class pro
    {
        static void Main(string[] args)
        {
            #region Toán tử toán học
            //int i = 5, j = 5;
            ////biến i đã được sử dụng để in ra màn hình rồi sau đó mới
            ////tăng lên 1 đơn vị cho nên màn hình mới in ra số 5.=> kết thúc dòng lệnh rồi mới cộng lên
            //console.writeline(i++);  // 5

            ////biến j thì ngược lại, tăng lên 1 đơn vị trước rồi mới
            ////sử dụng giá trị mới để in ra màn hình nên màn hình in ra số 6.
            //console.writeline(++j); // 6
            //console.readkey();
            #endregion
            #region toán tử tạo và gán
            int H, K, T;
            H = K = T = 10;
            Console.WriteLine("H= {0}, K= {1}, T= {2}", H, K, T);
            H += K = T = 5;// thực hiện gán trước sau đó mới cộng
            Console.WriteLine("H= {0}, K= {1}, T= {2}", H, K, T);
            #endregion
        }
    }
}
