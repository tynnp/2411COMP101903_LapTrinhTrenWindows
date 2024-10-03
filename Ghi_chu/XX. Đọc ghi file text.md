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

## 3. Sử dụng `File` để đọc ghi file
Lớp `File` cung cấp một số lượng lớn các phương thức tĩnh để thao tác trực tiếp với file, chẳng hạn như tạo, sao chép, di chuyển, xóa file hoặc đọc và ghi dữ liệu từ file.  
Một số phương thức phổ biến:
- `File.Create()`: Tạo một file mới.
- `File.Copy()`: Sao chép một file từ vị trí này sang vị trí khác.
- `File.Delete()`: Xóa một file.
- `File.Exists()`: Kiểm tra xem một file có tồn tại hay không.
- `File.ReadAllText()`: Đọc toàn bộ nội dung của file dưới dạng chuỗi.
- `File.WriteAllText()`: Ghi chuỗi vào file (ghi đè nếu file đã tồn tại).

Ví dụ: 
```csharp
using System;
using System.IO;

class Program {
    static void Main() {
        string filePath = "example.txt";

        // Tạo một file mới và ghi dữ liệu
        File.WriteAllText(filePath, "Hello, world!");

        // Kiểm tra xem file có tồn tại không
        if (File.Exists(filePath)) {
            // Đọc nội dung của file
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File content: " + content);

            // Xóa file
            File.Delete(filePath);
            Console.WriteLine("File deleted.");
        }
    }
}
```

## 4. Sử dụng `FileInfo` để đọc ghi file
Lớp `FileInfo` đại diện cho một file cụ thể trên hệ thống và cung cấp các phương thức không tĩnh để thao tác với file đó.  
Một số thuộc tính và phương thức phổ biến:
- `Exists`: Kiểm tra xem file có tồn tại hay không.
- `Length`: Lấy kích thước của file (tính bằng byte).
- `CreationTime`: Lấy hoặc đặt thời gian tạo file.
- `Delete()`: Xóa file.
- `CopyTo()`: Sao chép file tới một vị trí mới.
- `MoveTo()`: Di chuyển file tới một vị trí mới.

Ví dụ:
```csharp
using System;
using System.IO;

class Program {
    static void Main() {
        FileInfo fileInfo = new FileInfo("example.txt");

        // Tạo và ghi vào file nếu nó không tồn tại
        if (!fileInfo.Exists) {
            using (StreamWriter writer = fileInfo.CreateText()) {
                writer.WriteLine("Hello, FileInfo!");
            }
        }

        // Kiểm tra thuộc tính file
        Console.WriteLine("File exists: " + fileInfo.Exists);
        Console.WriteLine("File size: " + fileInfo.Length + " bytes");
        Console.WriteLine("File creation time: " + fileInfo.CreationTime);

        // Xóa file
        fileInfo.Delete();
        Console.WriteLine("File deleted.");
    }
}
```