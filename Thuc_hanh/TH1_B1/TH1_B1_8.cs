using System;

namespace TH1_B1_8 {
    class Program {
        static void Main(string[] args) {
            double num = double.Parse(Console.ReadLine());

            // Sử dụng hàm làm tròn
            Console.WriteLine(Math.Round(num, 3));  // Dùm hàm Round làm tròn 3 chữ số

            // Sử dụng định dạng xuất
            Console.WriteLine(num.ToString("F3"));  // Chuyển sang kiểu chuỗi làm tròn 3 chữ số
            Console.WriteLine("{0:F3}", num);       // Sử dụng định dạng
            Console.WriteLine("{0:0.000}", num);    // Sử dụng định dạng
        }
    }
}