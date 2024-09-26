using System;
using System.Text;

namespace TH1_B2_9 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int gio = 0, phut = 0, giay = 0;

            Console.Write("Nhập vào số giờ: ");
            gio = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số phút: ");
            phut = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số giây: ");
            giay = int.Parse(Console.ReadLine());

            if ((gio < 0 || gio > 23) || (phut < 0 || phut > 59) || (giay < 0 || giay > 59)) {
                Console.Write("NO");
            } else {
                Console.WriteLine("YES");
                int n = gio*3600 + phut*60 + giay + 1;
                Console.Write("Thời gian sau  1 giây: {0:00}:{1:00}:{2:00}", n % 24, n / 60 % 60, n % 60);
            }
        }
    }
}