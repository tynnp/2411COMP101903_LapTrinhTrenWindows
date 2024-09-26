using System;
using System.Text;

namespace TH1_B3_9 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int n, m, tich = 1, tong = 0;
            Console.Write("Nhập vào chữ số n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào chữ số m: ");
            m = int.Parse(Console.ReadLine());

            while (n > 0) {
                tich *= n % 10;
                n /= 10;
            }

            for (int i = 1; i <= m; i++)
                if (m % i == 0)
                    tong += i;

            Console.WriteLine($"Tích chữ số của n = {tich}");
            Console.WriteLine($"Tổng ước của m = {tong}");
            Console.Write((tong == tich ? "YES" : "NO"));
        }
    }
}