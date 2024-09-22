using System;

namespace TH1_B2_3 {
    class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(a, Math.Max(b, c)));
            Console.WriteLine(Math.Min(a, Math.Min(b, c)));
        }
    }
 }