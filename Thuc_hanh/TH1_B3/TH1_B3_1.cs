using System;

namespace TH1_BT3_1 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số nguyên: " );
            int number = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 2; i*i <= number; i++)
                if (number % i == 0)
                    cnt++;
            
            Console.Write(cnt == 0);
        }
    }
}