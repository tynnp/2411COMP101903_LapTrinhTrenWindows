using System;
using System.Text;

namespace Lab_1_BT2_1 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tham số a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập tham số b: ");
            double b = double.Parse(Console.ReadLine());

            if (a == 0) {
                if (b == 0)
                    Console.Write("Phương trình vô số nghiệm");
                else 
                    Console.Write("Phương trình vô nghiệm");
            } else {
                double x = -b/a;
                Console.Write("Phương trình có nghiệm x = {0}", x);
            }
        }
    }
}