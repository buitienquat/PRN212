using System;
namespace hang
{
    class hi
    {
        static void Main(string[] args)
        {
            // hằng là thêm const
            // hằng sử dụng tương tự như biến
            const int x = 10;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
//Hằng là 1 biến những giá trị không thay đổi trobng suốt chương trình;
//Bắt buộc phải khởi tạo giá trị khi khai báo

//Để ngăn chặn việc gán giá trị khác vào
// hằng làm cho chương trình dễ đọc hơn bằng cách biến các con số vô cảm thành những tên có ý nghĩa
// hằng giúp cho chương trình dễ nâng cấp,dễ chỉnh sửa hơn
// hằng giúp cho việc tránh lỗi dễ dàng hơn