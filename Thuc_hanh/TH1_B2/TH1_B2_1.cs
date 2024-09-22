using System;

namespace TH1_B2_1 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Console.Write("{0}", n % 2 == 0);
        }
    }
}