using System;
using System.Text;

namespace TH1_B2_8 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào 1 số gồm 4 chữ số: ");
            int number = int.Parse(Console.ReadLine());

            int x = number/1000 * 10 + number % 10;
            int y = number/100 % 10 * 10 + number/10 % 10;

            Console.Write($"Kết quả {x} + {y} = {x + y}");
        }
    }
}