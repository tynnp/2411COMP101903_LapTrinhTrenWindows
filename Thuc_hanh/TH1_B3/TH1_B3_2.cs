using System;

namespace TH1_B3_2 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int n, m;

            Console.Write("Nhập vào số nguyên n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số nguyên m: ");
            m = int.Parse(Console.ReadLine());

            for (int i = n+1; i < m; i++)
                if (i % 2 == 0)
                    Console.Write($"{i} ");
        }
    }
}