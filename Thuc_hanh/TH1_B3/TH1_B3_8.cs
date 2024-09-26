using System;
using System.Text;

namespace TH1_B3_8 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số nguyên n: ");
            double n = double.Parse(Console.ReadLine());
            double ans = 0;

            for (int i = 1; i <= n; i++)
                ans += 1 / Math.Pow(i, 3);

            Console.Write($"Kết quả = {ans}");
        }
    }
}