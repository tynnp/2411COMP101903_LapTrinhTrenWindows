using System;
using System.Text;

namespace TH1_B3_3 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào một số nguyên: ");
            int number = int.Parse(Console.ReadLine());

            int check = 0;
            for (int i = 1; i < number; i++)
                if (number % i == 0)
                    check += i;
            
            if (check == number)
                Console.Write("Yes");
            else 
                Console.Write("No");
        }
    }
}