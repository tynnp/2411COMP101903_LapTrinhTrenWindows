using System;
using System.Text;

namespace TH1_B3_6 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào i: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Bảng cửu chương {n}: ");
            for (int i = 1; i <= 10; i++)   
                Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}