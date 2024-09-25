using System;
using System.Text;

namespace Lab_1_BT1 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào tên người dùng: ");
            string name = Console.ReadLine();
            Console.WriteLine("Xin chào " + name + "!");
        }
    }
}