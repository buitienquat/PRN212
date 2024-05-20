using System;
namespace KIEUDULIEU_THAMCHIEU_Dynamic
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             + object xác định kiểu dữ liệu ngay khi viết code
             + dynamic thì khi chạy chương trình nó mới bắt đầu xác định kiểu dữ liệu
            
            - Dynamic có thể ép kiểu
            - Các đối tượng thuộc kiểu dynamic sẽ không xác định được kiểu cho đến khi 
            chương trình được thực thi. Tức là trình biên dịch sẽ bỏ qua tất cả 
            lỗi về cú pháp, việc kiểm tra này sẽ thực hiện khi chương trình thực thi.
             */
            String hoten = "Bui Tien ";
            String name = "Quat";
            dynamic full = name;
           // full++;
            Console.WriteLine(hoten+full);
        }
    }
}