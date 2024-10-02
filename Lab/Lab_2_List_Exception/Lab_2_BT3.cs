using System;
using System.Collections;
using System.Text;

public struct MatHang {
    public int MaMH;
    public string TenMH;
    public int SoLuong;
    public double DonGia;

    public MatHang(int MaMH, string TenMH, int SoLuong, double DonGia) {
        this.MaMH = MaMH;
        this.TenMH = TenMH;
        this.SoLuong = SoLuong;
        this.DonGia = DonGia;
    }

    public double ThanhTien() {
        return SoLuong * DonGia;
    }

    public override string ToString() {
        return $"{MaMH}-{TenMH}-{SoLuong}-{DonGia}-{ThanhTien()}";
    }
}

public class Program {
    public static void Main(string[] args) {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Hashtable danhSach = new Hashtable();
        char luaChon = 'y';
        int MaCanXoa;

        while (luaChon != 'n') {
            int MaMH, SoLuong;
            string TenMH = "";
            double DonGia;

            Console.Write("Nhập mã mặt hàng: ");
            while (!int.TryParse(Console.ReadLine(), out MaMH))
                Console.Write("Nhập mã mặt hàng: ");

            while (TenMH == "") {
                Console.Write("Nhập tên mặt hàng: ");
                TenMH = Console.ReadLine();
            }

            Console.Write("Nhập số lượng: ");
            while (!int.TryParse(Console.ReadLine(), out SoLuong))
                Console.Write("Nhập số lượng: ");
            
            Console.Write("Nhập đơn giá: ");
            while (!double.TryParse(Console.ReadLine(), out DonGia))
                Console.Write("Nhập đơn giá: ");

            MatHang matHang = new MatHang(MaMH, TenMH, SoLuong, DonGia);
            Add(danhSach, matHang);

            Console.Write("Đã thêm thành công! Có muốn tiếp tục? (y/n): ");
            while (!char.TryParse(Console.ReadLine().ToLower(), out luaChon) || (luaChon != 'n' && luaChon != 'y')) 
                Console.Write("Nhập lựa chọn (y/n): ");
        }

        Print(danhSach);

        Console.Write("Nhập mã mặt hàng cần xóa: ");
        while (!int.TryParse(Console.ReadLine(), out MaCanXoa))
            Console.Write("Nhập mã mặt hàng cần xóa: ");

        Delete(danhSach, MaCanXoa);
        Print(danhSach);
    }

    static void Add(Hashtable danhSach, MatHang matHang) {
        danhSach.Add(matHang.MaMH, matHang);
    }

    static bool Find(Hashtable danhSach, int MaMH) {
        return danhSach.ContainsKey(MaMH);
    }

    static void Print(Hashtable danhSach) {
        Console.WriteLine();
        foreach (DictionaryEntry matHang in danhSach)
            Console.WriteLine($"MaMH: {matHang.Key}, MatHang: {matHang.Value}");
        Console.WriteLine();
    }

    static void Delete(Hashtable danhSach, int MaMH) {
        if (Find(danhSach, MaMH)) {
            danhSach.Remove(MaMH);
            Console.WriteLine("Đã xóa!");
            return;
        } 

        Console.Write("Không tìm thấy!");
    }
}