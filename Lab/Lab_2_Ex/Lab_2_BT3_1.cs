using System;
using System.Text;

public class SinhVien {
    public static void Main(string[] args) {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        List<SinhVien> list = new List<SinhVien>();
        int soLuong;

        Console.Write("Nhập số lượng sinh viên: ");
        while (!int.TryParse(Console.ReadLine(), out soLuong))
            Console.Write("Nhập số lượng sinh viên: ");

        while (soLuong > 0) {
            string MaSV, HoTen, DiaChi, DienThoai;
            DateTime NgaySinh;

            Console.Write("Mã sinh viên: ");
            MaSV = Console.ReadLine();  

            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Ngày sinh: ");
            while(!DateTime.TryParse(Console.ReadLine(), out NgaySinh))
                Console.Write("Ngày sinh: ");
            
            Console.Write("Địa chỉ: ");
            DiaChi = Console.ReadLine();

            Console.Write("Điện thoại: ");
            DienThoai = Console.ReadLine();

            SinhVien sinhVien = new SinhVien(MaSV, HoTen, NgaySinh, DiaChi, DienThoai);
            list.Add(sinhVien);
            Console.WriteLine("Đã thêm thành công!");
            soLuong--;
        }

        Console.WriteLine("Danh sách sinh viên: ");
        foreach (SinhVien sinhVien in list) 
            Console.WriteLine($"{sinhVien}");
    }

    public string MaSV {
        get; set;
    }

    public string HoTen {
        get; set;
    }

    public DateTime NgaySinh {
        get; set;
    }

    public string DiaChi {
        get; set;
    }

    public string DienThoai {
        get; set;
    }

    public int Tuoi {
        get {
            return DateTime.Now.Year - NgaySinh.Year;
        }
    }

    public SinhVien() {
        MaSV = HoTen = DiaChi = DienThoai = "";
    }

    public SinhVien(string MaSV, string HoTen, DateTime NgaySinh, string DiaChi, string DienThoai) {
        this.MaSV = MaSV;
        this.HoTen = HoTen;
        this.NgaySinh = NgaySinh;
        this.DiaChi = DiaChi;
        this.DienThoai = DienThoai;
    }

    public override string ToString()
    {
        return $"{MaSV}-{HoTen}-{NgaySinh.ToString("dd/MM/yyyy")}-{Tuoi}-{DiaChi}-{DienThoai}\n";
    }
}