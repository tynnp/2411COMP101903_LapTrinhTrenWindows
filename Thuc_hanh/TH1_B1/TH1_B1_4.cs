using System;

namespace TH1_B1_4 {
    class Program {
        static void Main(string[] args) {
            string number = Console.ReadLine();
            Console.Write("{0}", (number[0] - '0') + (number[1] - '0'));
        }
    }
}