using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Giá trị không hợp lệ. Vui lòng nhập lại số lượng phần tử trong mảng: ");
        }

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.Write($"Giá trị không hợp lệ. Vui lòng nhập lại phần tử thứ {i + 1}: ");
            }
        }

        int max = array[0];
        for (int i = 1; i < n; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");
    }
}
