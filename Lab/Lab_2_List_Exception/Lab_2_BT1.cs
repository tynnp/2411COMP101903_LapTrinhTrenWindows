using System;
using System.Text;

public class Program {
    public static void Main(string[] args) {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        double x, y;

        try {
            Console.Write("Nhập số x: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Nhập số y: ");
            y = double.Parse(Console.ReadLine());

            double H = Math.Sqrt((3*x + 2*y)/(2*x - y));

            if (2*x - y == 0) 
                throw new DivideByZeroException(); 
            
            if ((3*x + 2*y)/(2*x - y) < 0)
                throw new NotNegativeException(); 
            
            Console.Write($"Kết quả = {H:0.00}");

        } catch (DivideByZeroException e) {
            Console.WriteLine($"Error: {e.Message}");
        } catch (FormatException e) {
            Console.WriteLine($"Error: {e.Message}");
        } catch (NotNegativeException e) {
            Console.WriteLine($"Error: {e.Message}");
        } catch (Exception e) {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

    class NotNegativeException : Exception {
        public NotNegativeException() : base ("Gia tri nho hon 0!") {
            //
        }
    }
}