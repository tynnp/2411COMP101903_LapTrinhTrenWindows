using System;
using System.Text;

public class Program {
    public static void Main(string[] args) {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        double x, y;
        Console.Write("Nhập số x: ");
        while (!double.TryParse(Console.ReadLine(), out x)) 
            Console.Write("Nhập số x: ");
        
        Console.Write("Nhập số y: ");
        while (!double.TryParse(Console.ReadLine(), out y))
            Console.Write("Nhập số y: ");

        try {
            double H = Math.Sqrt((3*x + 2*y)/(2*x - y));

            if (2*x - y == 0) 
                throw new DivideByZeroException(); 
            
            if ((3*x + 2*y)/(2*x - y) < 0)
                throw new NotNegativeException(); 
            
            Console.Write($"Kết quả = {H:0.00}");

        } catch (DivideByZeroException e) {
            Console.WriteLine(e);
        } catch (FormatException e) {
            Console.WriteLine(e);
        } catch (NotNegativeException e) {
            Console.WriteLine(e);
        } catch (Exception e) {
            Console.WriteLine(e);
        }
    }

    class NotNegativeException : Exception {
        public NotNegativeException() : base ("Gia tri nho hon 0!") {
            Console.WriteLine("TEST BUG");
        }
    }
}