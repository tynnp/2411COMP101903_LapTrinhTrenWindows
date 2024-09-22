using System;

namespace TH1_B1_5 {
    class Program {
        static void Main(string[] args) {
            string n = Console.ReadLine();
            Console.Write("{0}", (n[0] - '0') + (n[1] - '0') + ((n[2] - '0')));
        }
    }
}