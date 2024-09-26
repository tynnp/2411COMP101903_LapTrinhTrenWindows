using System;
using System.Text;

namespace Lab_1_BT4_3 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào đầy đủ họ tên: ");
            string fullName = Console.ReadLine();

            string[] s = fullName.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string ho, tenLot, ten;
            ho = s[0].Substring(0, 1).ToUpper() + s[0].Substring(1, s[0].Length - 1).ToLower();
            tenLot = s[1].Substring(0, 1).ToUpper() + s[1].Substring(1, s[1].Length - 1).ToLower();
            ten = s[2].Substring(0, 1).ToUpper() + s[2].Substring(1, s[2].Length - 1).ToLower();

            Console.Write("Họ tên đúng chuẩn: {0} {1} {2}", ho, tenLot, ten);
        }
    }
}

// StringSplitOptions.None: trả về các phần tử sau khi chia chuỗi, bao gồm chuỗi rỗng.
// StringSplitOptions.RemoveEmptyEntries: trả về các phần tử sau khi chia chuỗi không có chuỗi rỗng.