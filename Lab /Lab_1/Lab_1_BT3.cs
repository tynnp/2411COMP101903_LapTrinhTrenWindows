using System;
using System.Diagnostics;
using System.Text;

namespace Lab_1_BT3 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào mảng: ");
            string[] s = (Console.ReadLine()).Split(' ');
            int[] a = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
                a[i] = int.Parse(s[i]);

            int sum = 0, max = a[0], min = a[0];
            for (int i = 0; i < a.Length; i++) {
                sum += a[i];
                max = Math.Max(max, a[i]);
                min = Math.Min(min, a[i]);
            }

            Console.WriteLine($"Tổng giá trị của mảng = {sum}");
            Console.WriteLine($"Giá trị lớn nhất của mảng = {max}");
            Console.WriteLine($"Giá trị nhỏ nhất của mảng = {min}");
        }
    }
}