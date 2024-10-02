using System;
using System.Text;

public class Program {
    public static void Main(string[] args) {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        int index;
        string tmp = "";
        List<string> lst = new List<string>();

        while (true) {
            Console.Write("Nhập tên hàng hóa: ");
            tmp = Console.ReadLine().Trim();
            if (tmp.ToUpper() == "STOP") break;
            lst.Add(tmp);
        }

        Console.WriteLine("\nDanh sách hàng hóa: ");
        foreach (string str in lst) 
            Console.WriteLine(str);
        Console.WriteLine();
        
        tmp = "";
        while (string.IsNullOrWhiteSpace(tmp)) {
            Console.Write("Nhập vào tên hàng hóa cần xóa: ");
            tmp = Console.ReadLine().Trim(); 
        }
        
        if (lst.Contains(tmp)) {
            lst.Remove(tmp);
            Console.WriteLine("Đã xóa!");
        } else 
            Console.WriteLine("Không tìm thấy!");

        Console.Write("Nhập vị trí cần thêm: ");
        while (!int.TryParse(Console.ReadLine(), out index))
            Console.Write("Nhập vị trí cần thêm: ");

        tmp = "";
        while (string.IsNullOrWhiteSpace(tmp)) {
            Console.Write("Nhập tên hàng hóa muốn thêm: ");
            tmp = Console.ReadLine();
        }

        try {
            lst.Insert(index, tmp);
        } catch (Exception e) {
            Console.Write(e.Message);
        }

        Console.WriteLine("\nDanh sách hàng hóa: ");
        foreach (string str in lst) 
            Console.WriteLine(str);
        Console.WriteLine();

        Console.WriteLine("Kết thúc chương trình!");
    }
}

// using System;
// using System.Collections;
// using System.Text;

// public class Program {
//     public static void Main(string[] args) {
//         Console.InputEncoding = Encoding.UTF8;
//         Console.OutputEncoding = Encoding.UTF8;

//         int index;
//         string tmp = "";
//         ArrayList arr = new ArrayList();

//         while (true) {
//             Console.Write("Nhập tên hàng hóa: ");
//             tmp = Console.ReadLine().Trim();
//             if (tmp.ToUpper() == "STOP") break;
//             arr.Add(tmp);
//         }

//         Console.WriteLine("\nDanh sách hàng hóa: ");
//         foreach (string str in arr) 
//             Console.WriteLine(str);
//         Console.WriteLine();

//         tmp = "";
//         while (string.IsNullOrWhiteSpace(tmp)) {
//             Console.Write("Nhập vào tên hàng hóa cần xóa: ");
//             tmp = Console.ReadLine().Trim();
//         }

//         if (arr.Contains(tmp)) {
//             arr.Remove(tmp);
//             Console.WriteLine("Đã xóa!");
//         } else 
//             Console.WriteLine("Không tìm thấy!");

//         Console.Write("Nhập vị trí cần thêm: ");
//         while (!int.TryParse(Console.ReadLine(), out index)) 
//             Console.Write("Nhập vị trí cần thêm: ");

//         tmp = "";
//         while (string.IsNullOrWhiteSpace(tmp)) {
//             Console.Write("Nhập tên hàng hóa muốn thêm: ");
//             tmp = Console.ReadLine();
//         }
        
//         try {
//             arr.Insert(index, tmp);
//         } catch (Exception e) {
//             Console.Write(e.Message);
//         }

//         Console.WriteLine("\nDanh sách hàng hóa: ");
//         foreach (string str in arr)
//             Console.WriteLine(str);
//         Console.WriteLine();

//         Console.WriteLine("Kết thúc chương trình!");
//     }
// }