using System;
using System.Text;

namespace Lab_1_BT4_2 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào họ tên: ");
            string fullName = Console.ReadLine();
            string[] s = fullName.Split(' ');

            Console.WriteLine("Họ tên: " + fullName);
            Console.WriteLine("Họ: " + s[0]);

            if (s.Length > 2) {
                Console.Write("Chữ lót: ");
                for (int i = 1; i < s.Length - 1; i++)
                    Console.Write(s[i] + " ");
                Console.WriteLine();
            }
            
            Console.Write("Tên: " + s[s.Length - 1]);
        }
    }
}