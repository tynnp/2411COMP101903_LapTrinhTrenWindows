using System;
using System.Text;

namespace TH1_B3_4 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào số nguyên a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số nguyên b: ");
            int b = int.Parse(Console.ReadLine());

            while (a != 0 && b != 0) {
                if (a > b) 
                    a = a % b;
                else 
                    b = b % a;
            } 

            Console.Write("Ước chung lớn nhất: {0}", a + b);
        }
    }
}