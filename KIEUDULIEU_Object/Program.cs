using System;
namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            #region kiểu dữ liệu hay dùng của object
            //object obj = "HowKteam";
            //object cc = 1;
            //// chuyển từ kiểu dữ liệu nào đó về kiểu chuỗi, không cần biết kiều dữ liệu là gì vẫn chuyển được
            //obj.ToString();
            //obj.Equals(cc);// đúng thì trả về true, ko giống thì false
            //obj.gethashcode();// trả về mã băm của đối tượng
            //obj.GetType();// trả về kiểu dữ liệu của đối tượng
            //Console.WriteLine(obj);
            //Console.ReadKey();
            #endregion
            #region boxing và unboxing
            /*
             Boxing: chuyển từ kiểu dữ liệu giá trị sang kiểu dữ liệu tham chiếu
             */
            int value = 109;// kiểu dữ liệu giá trị int
            // copy giá trị value thả vào objvalue
            object objvalue = value; // đóng hộp

            //Unboxing: mở hộp
            int newValue = (int)objvalue;
            //b1: kiểm tra kiểu dữ liệu biến objvalue có lấy giá trị đúng kiểu int hay ko
            //b2: đúng => ko lỗi
            //sai  => lỗi , VD: nếu objvalue là chuỗi mà ép kiểu  int thì sẽ bị lỗi
            #endregion



            //var: từ khoá hỗ trợ khai báo biến mà ko cần kiểu dữ liệu
            // var chỉ sử dụng để khai báo biến, ko phải kiểu dữ liệu
            // bắt buộc phải gán giá trị ngay khi khởi tạo biến
            // ko khởi tạo được null cho biến var
            // kiểu dữ liệu sẽ được xác định khi gán giá trị cho biến
            var varString = "hicau";
            var varContent = "hello";
            Console.WriteLine(varString);
            Console.WriteLine(varContent);
        }
    }
}