using System;

namespace TH1_B1_3 {
    class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c = a;
            a = b;
            b = c;

            Console.Write($"a={a} b={b}");
        }
    }
}