using System;

namespace TH1_B3_7 {
    class Program {
        static void Main(string[] args) {
            for (int i = 2; i <= 10; i++) {
                for (int j = 1; j <= 10; j++)
                    Console.WriteLine($"{i} x {j} = {i*j}");
                Console.WriteLine();
            }
        }
    }
}