using System;

namespace TH1_B1_7 {
    class Program {
        static void Main(string[] args) {
            int a = Console.Read();
            int b = Console.Read();
            Console.WriteLine($"{a}\n{b}\n{a + b}");
        }
    }
}

/**************************************************************************************
* Console.Read();         -> đọc 1 ký tự => trả về kiểu số nguyên.
* Console.ReadLine();     -> đọc 1 dòng input => trả về kiểu chuỗi.
* Console.ReadKey();      -> đọc 1 ký tự ngay khi người dùng nhập (không cần enter).
**************************************************************************************/