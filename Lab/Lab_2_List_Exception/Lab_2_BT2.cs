using System;
using System.Text;

public class Program {
    public static void Main(string[] args) {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        int n;
        Console.Write("Nhập số lượng phần tử: ");
        while (!int.TryParse(Console.ReadLine(), out n))
            Console.Write("Nhập số lượng phần tử: ");
        
        Random ran = new Random((int) DateTime.Now.Ticks);
        List<int> lst = new List<int>();

        for (int i = 0; i < n; i++) 
            lst.Add(ran.Next(100));
        lst.Sort();

        foreach (int num in lst) 
            Console.Write($"{num} ");
    }
}

// using System;
// using System.Text;

// public class Program {
//     public static void Main(string[] args) {
//         Console.InputEncoding = Encoding.UTF8;
//         Console.OutputEncoding = Encoding.UTF8;

//         int n;
//         Console.Write("Nhập số lượng phần tử: ");
//         while (!int.TryParse(Console.ReadLine(), out n)) 
//             Console.WriteLine("Nhập số lượng phần tử: ");
        
//         int[] a = new int[n];
//         Random random = new Random((int)DateTime.Now.Ticks);

//         for (int i = 0; i < n; i++) {
//             a[i] = random.Next(100);
//             Console.Write($"{a[i]} ");
//         }

//         Console.WriteLine();
//         sort(a, n);

//         for (int i = 0; i < n; i++)
//             Console.Write($"{a[i]} ");
//     }

//     public static void sort(int[] a, int n) {
//         for (int i = 1; i < n; i++) {
//             int j = i;
//             while (j > 0 && a[j-1] > a[j]) {
//                 swap(ref a[j-1], ref a[j]);
//                 j--;
//             }
//         }
//     }

//     public static void swap(ref int a, ref int b) {
//         int c = a;
//         a = b; 
//         b = c;
//     }
// }