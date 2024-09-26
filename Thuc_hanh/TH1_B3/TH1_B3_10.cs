using System;
using System.Text;

namespace TH1_B3_10 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào số n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhập vào số m: ");
            string m = Console.ReadLine();

            Console.Write("Nhập vào số k: ");
            int k = int.Parse(Console.ReadLine());

            int res = 0;
            while (n > 0) {
                res += n % 10;
                n /= 10;
            }

            res += m[0] - '0';

            if (res == k)
                Console.Write("Yes");
            else 
                Console.Write("No");
        }
    }
}