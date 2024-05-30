using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        // Yêu cầu người dùng nhập một số nguyên
        Console.Write("Vui lòng nhập một số nguyên: ");
        string input = Console.ReadLine();

        // Chuyển đổi chuỗi nhập từ người dùng thành kiểu số nguyên
        int integerNumber;
        if (int.TryParse(input, out integerNumber))
        {
            // Ép kiểu số nguyên thành số thực kiểu double
            double doubleNumber = (double)integerNumber;

            // Xuất kết quả ra màn hình
            Console.WriteLine($"Số bạn đã nhập là {integerNumber} và ở dạng kép là {doubleNumber}");
        }
        else
        {
            // Thông báo lỗi nếu đầu vào không phải là số nguyên hợp lệ
            Console.WriteLine("Giá trị bạn nhập không phải là một số nguyên hợp lệ.");
        }
    }
}
