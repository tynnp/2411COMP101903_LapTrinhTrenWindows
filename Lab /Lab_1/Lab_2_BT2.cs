using System;
using System.Net.Http.Headers;
using System.Text;

// namespace Lab_1_BT2_1 {
//     class Program {
//         static void Main(string[] args) {
//             Console.InputEncoding = Encoding.UTF8;
//             Console.OutputEncoding = Encoding.UTF8;

//             Console.Write("Nhập tham số a: ");
//             double a = double.Parse(Console.ReadLine());
//             Console.Write("Nhập tham số b: ");
//             double b = double.Parse(Console.ReadLine());

//             if (a == 0) {
//                 if (b == 0)
//                     Console.Write("Phương trình vô số nghiệm");
//                 else 
//                     Console.Write("Phương trình vô nghiệm");
//             } else {
//                 double x = -b/a;
//                 Console.Write("Phương trình có nghiệm x = {0}", x);
//             }
//         }
//     }
// }

// namespace Lab_1_BT2_2 {
//     class Program {
//         static void Main(string[] args) {
//             Console.InputEncoding = Encoding.UTF8;
//             Console.OutputEncoding = Encoding.UTF8;
//             double a, b;
//             string s; 
            
//             Console.Write("Nhập số a: ");
//             s = Console.ReadLine();
//             while (!double.TryParse(s, out a)) {
//                 Console.Write("Kiểu dữ liệu không hợp lệ! Nhập lại a: ");
//                 s = Console.ReadLine();
//             }

//             Console.Write("Nhập số b: ");
//             s = Console.ReadLine();
//             while (!double.TryParse(s, out b)) {
//                 Console.Write("Kiểu dữ liệu không hợp lệ! Nhập lại b: ");
//                 s = Console.ReadLine();
//             }

//             if (a == 0) {
//                 if (b == 0) 
//                     Console.Write("Phương trình vô số nghiệm");
//                 else 
//                     Console.Write("Phương trình vô nghiệm");
//             } else 
//                 Console.Write($"Phương trình có nghiệm x = {-b/a}");
//         }
//     }
// }

namespace Lab_1_BT2_3 {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            double a = 0, b = 0;
            
            while (true) {
                Console.Write("Nhập vào hệ số a: ");
                try {
                    a = double.Parse(Console.ReadLine());
                    break;
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }

            while (true) {
                Console.Write("Nhập vào hệ số b: ");
                try {
                    b = double.Parse(Console.ReadLine());
                    break;
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }

            if (a == 0) {
                if (b == 0) 
                    Console.Write("Phương trình vô số nghiệm.");
                else 
                    Console.Write("Phương trình vô nghiệm."); 
            } else {
                Console.Write($"Phương trình có nghiệm x = {-b/a}");
            }
        }
    }
}