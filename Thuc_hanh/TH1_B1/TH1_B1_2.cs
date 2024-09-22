using System;

namespace TH1_B1_2 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.Write("{0}", n%10 + m%10);
        }
    }
}