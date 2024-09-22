using System;

namespace TH1_B2_4 {
    class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            int ans = 0;

            switch (c) {
                case '+':
                    ans = a + b;
                    break;

                case '-':
                    ans = a - b;
                    break;
                
                case '%':
                    ans = a % b;
                    break;
                
                case '*':
                    ans = a * b;
                    break;
            }

            Console.Write($"{a} {c} {b} = {ans}");
        }
    }
}