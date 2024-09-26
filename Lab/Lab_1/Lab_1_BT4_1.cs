using System;
using System.Text;

namespace Lab_1_BT4_1 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string ho, chuLot, ten;
            Console.Write("Nhập vào họ: ");
            ho = Console.ReadLine();

            Console.Write("Nhập vào chữ lót: ");
            chuLot = Console.ReadLine();

            Console.Write("Nhập vào tên: ");
            ten = Console.ReadLine();

            Console.WriteLine("Xin chào! {0} {1} {2}", ho, chuLot, ten);
        }
    }
}