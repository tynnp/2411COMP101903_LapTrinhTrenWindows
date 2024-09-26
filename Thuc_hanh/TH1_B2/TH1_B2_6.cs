using System;
using System.Text;

namespace TH1_B2_6 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào số tháng: ");
            int month = int.Parse(Console.ReadLine());
            int day = -1;

            switch (month) {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12: 
                    day = 31;
                    break;
                case 4: case 6: case 9: case 11: 
                    day = 30;
                    break;
                case 2:
                    day = 28;
                    break;
            }

            Console.Write($"Tháng {month} có {day} ngày!");
        }
    }
}