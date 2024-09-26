using System;
using System.Text;

namespace TH1_B3_5 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            long ans = 1;

            for (int i = 1; i <= n; i++)
                ans *= i;
            
            Console.Write($"Kết quả của n!: {ans}");
        }
    }
}