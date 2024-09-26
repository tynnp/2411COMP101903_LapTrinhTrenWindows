using System;
using System.Text;

namespace TH1_B2_5 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập hệ số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập hệ số b: ");
            int b = int.Parse(Console.ReadLine());

            if (a == 0) {
                if (b == 0) 
                    Console.Write("VSN");
                else 
                    Console.Write("VN");
            } else 
                Console.Write("Phương trình có nghiệm là: {0:0.00}", (double) -b/a);
        }
    }
}