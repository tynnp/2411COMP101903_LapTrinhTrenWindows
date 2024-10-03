# Đọc ghi file text
## 1. Sử dụng `StreamReader` để đọc file
`StreamReader` là một lớp trong thư viện `System.IO` của .NET, được sử dụng để đọc các chuỗi ký tự từ một luồng dữ liệu, thường là file văn bản, bằng cách sử dụng mã hóa ký tự.  
Các phương thức thông dụng của `StreamReader`:
- `Read()`: Đọc một ký tự từ luồng và trả về mã số ký tự Unicode. Trả về -1 nếu đã đọc hết file.
- `ReadLine()`: Đọc một dòng văn bản từ file và trả về dưới dạng chuỗi. Trả về `null` nếu đã đến cuối file.
- `ReadToEnd()`: Đọc toàn bộ nội dung file từ vị trí hiện tại đến cuối và trả về dưới dạng chuỗi.
- `Peek()`: Trả về ký tự tiếp theo trong luồng mà không di chuyển vị trí con trỏ đọc. Trả về -1 nếu đã đến cuối file.
- `Close()`: Đóng `StreamReader` và giải phóng tài nguyên.

Ví dụ: Đọc toàn bộ nội dung file
```csharp
using System;
using System.IO;

class Program {
    static void Main() {
        try {
            using (StreamReader sr = new StreamReader("example.txt")) {
                string content = sr.ReadToEnd(); 
                Console.WriteLine(content);      
            }
        }

        catch (Exception e) {
            Console.WriteLine($"The file could not be read: {e.Message}");
        }
    }
}
```

Ví dụ: Đọc và ghi từng dòng
``` csharp
using System;
using System.IO;

class Program {
    static void Main() {
        try {
            using (StreamReader sr = new StreamReader("example.txt")) {
                string line;
                while ((line = sr.ReadLine()) != null)
                    Console.WriteLine(line);    
            }
        }

        catch (Exception e) {
            Console.WriteLine($"The file could not be read: {e.Message}");
        }
    }
}
```

## 2. Sử dụng `StreamWriter` để ghi file
`StreamWriter` là một lớp trong thư viện `System.IO` của .NET, được sử dụng để ghi dữ liệu dạng chuỗi vào một luồng (stream), thường là file văn bản.  
Các phương thức thông dụng của `StreamWriter`:
- `Write()`: Ghi dữ liệu vào luồng mà không xuống dòng (có thể là chuỗi, ký tự, mảng ký tự, hay đối tượng).
- `WriteLine()`: Ghi một chuỗi dữ liệu và tự động xuống dòng sau khi ghi xong.
- `Flush()`: Ghi ngay tất cả dữ liệu trong buffer ra file mà không đóng luồng.
- `Close()`: Đóng `StreamWriter` và giải phóng tài nguyên.
- `Dispose()`: Tương tự `Close()`, tự động giải phóng tài nguyên khi không còn sử dụng.

Ví dụ: Ghi một chuỗi vào file, `StreamWriter` sẽ tạo file mới nếu file không tồn tại, hoặc ghi đè file nếu file đã tồn tại.
``` csharp
using System;
using System.IO;

class Program {
    static void Main() {
        try {
            using (StreamWriter sw = new StreamWriter("example.txt")) {
                sw.WriteLine("Hello, World!"); 
            }
        }
        
        catch (Exception e) {
            Console.WriteLine($"The file could not be written: {e.Message}");
        }
    }
}
```