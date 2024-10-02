using System;
using System.Text;

public class Program {
    public static void Main(string[] args) {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        SanPham sp = new SanPham();
        sp.nhapThongTin();
        sp.xuatThongTin();
    }
}
public class SanPham {
    public string _strMaSanPham {
        get; set;
    }

    public string _strTenSanPham {
        get; set;
    }

    public double _fGiaSanPham {
        get; set;
    }

    public SanPham() {
        _strMaSanPham = _strTenSanPham = "";
        _fGiaSanPham = 0;
    }

    public SanPham(string maSanPham, string tenSanPham, double giaSanPham) {
        this._strMaSanPham = maSanPham;
        this._strTenSanPham = tenSanPham;
        this._fGiaSanPham = giaSanPham;
    }

    public double thueVAT() {
        return _fGiaSanPham * 0.1;
    }

    public void nhapThongTin() {
        Console.Write("Nhập mã sản phẩm: ");
        _strMaSanPham = Console.ReadLine();

        Console.Write("Nhập tên sản phẩm: ");
        _strTenSanPham = Console.ReadLine();

        Console.Write("Nhập giá sản phẩm: ");
        _fGiaSanPham = double.Parse(Console.ReadLine());
    }

    public void xuatThongTin() {
        Console.WriteLine($"Mã sản phẩm: {_strMaSanPham}");
        Console.WriteLine($"Tên sản phẩm: {_strTenSanPham}");
        Console.WriteLine($"Giá sản phẩm: {_fGiaSanPham}");
        Console.WriteLine($"Thuế VAT: {thueVAT()}");
    }
}