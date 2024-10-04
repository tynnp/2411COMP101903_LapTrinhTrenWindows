using System;
using System.Diagnostics;
using System.Text;

public class Program {
    public static void Main(string[] args) {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        PrintAuthor();

        SinhVien sv = new SinhVien("Nguyễn Ngọc Phú Tỷ", new DateTime(2005, 2, 20), "Lai Vung, Đồng Tháp", "49.01.104.172", "49.01.CNTT.B", "tynnp2002@gmail.com", "0364147912");
        NhanVien nv = new NhanVien("Dương Thị Thu Diểm", new DateTime(2005, 4, 23), "Tiểu Cần, Trà Vinh", "49.01.103.011", "thudiem123456@gmail.com", "0339030832", new DateTime(2024, 10, 4), "49.01.SPTIN.B");

        sv.XemThongTin();
        nv.XemThongTin();
    }

    static void PrintAuthor() {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();

        Console.WriteLine("""

            ████████╗██╗   ██╗███╗   ██╗███╗   ██╗██████╗ 
            ╚══██╔══╝╚██╗ ██╔╝████╗  ██║████╗  ██║██╔══██╗
               ██║    ╚████╔╝ ██╔██╗ ██║██╔██╗ ██║██████╔╝
               ██║     ╚██╔╝  ██║╚██╗██║██║╚██╗██║██╔═══╝ 
               ██║      ██║   ██║ ╚████║██║ ╚████║██║     
               ╚═╝      ╚═╝   ╚═╝  ╚═══╝╚═╝  ╚═══╝╚═╝   program   
            ----------------------------------------------------

            """);
            
        Console.ForegroundColor = ConsoleColor.White;
    }
}

public class Nguoi {
    protected string _strHoTen;
    protected DateTime _ngaySinh;
    protected string _strDiaChi;

    public string HoTen {
        get {return _strHoTen;}
        set {_strHoTen = value;}
    }

    public DateTime NgaySinh {
        get {return _ngaySinh;}
        set {_ngaySinh = value;}
    }

    public string DiaChi {
        get {return _strDiaChi;}
        set {_strDiaChi = value;}
    }

    public int LayTuoi {
        get {
            return DateTime.Now.Year - _ngaySinh.Year;
        }
    }

    public Nguoi() {
        _strHoTen = _strDiaChi = "";
        _ngaySinh = new DateTime();
    }

    public Nguoi(string hoTen, DateTime ngaySinh, string diaChi) {
        this._strHoTen = hoTen;
        this._ngaySinh = ngaySinh;
        this._strDiaChi = diaChi;
    }

    public Nguoi(Nguoi other) {
        this._strHoTen = other._strHoTen;
        this._ngaySinh = other._ngaySinh;
        this._strDiaChi = other._strDiaChi;
    }

    public virtual void XemThongTin() {
        Console.WriteLine($"Họ tên: {_strHoTen}");
        Console.WriteLine($"Ngày Sinh: {_ngaySinh.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Địa Chỉ: {_strDiaChi}");
        Console.WriteLine($"Tuổi hiện tại: {LayTuoi}");
    }
}

public class SinhVien : Nguoi {
    private string _strMaSV;
    private string _strMaLop;
    private string _strEmail;
    private string _strDienThoai;

    public string MaSV {
        get {return _strMaSV;}
        set {_strMaSV = value;}
    }
    public string MaLop {
        get {return _strMaLop;}
        set {_strMaLop = value;}
    }
    public string Email {
        get {return _strEmail;}
        set {_strEmail = value;}
    }
    public string DienThoai {
        get {return _strDienThoai;}
        set {_strDienThoai = value;}
    }

    public SinhVien() {
        _strMaSV = _strMaLop = _strEmail = _strDienThoai = "";
    }

    public SinhVien(string hoTen, DateTime ngaySinh, string diaChi, string maSV, string maLop, string email, string dienThoai) : base(hoTen, ngaySinh, diaChi) {
        _strMaSV = maSV;
        _strMaLop = maLop;
        _strEmail = email;
        _strDienThoai = dienThoai;
    }

    public SinhVien(SinhVien other) : base(other) {
        _strMaSV = other._strMaSV;
        _strMaLop = other._strMaLop;
        _strEmail = other._strEmail;
        _strDienThoai = other._strDienThoai;
    }

    public override void XemThongTin() {
        Console.WriteLine("Thông tin sinh viên: ");
        base.XemThongTin();
        Console.WriteLine($"Mã sinh viên: {_strMaSV}");
        Console.WriteLine($"Mã lớp: {_strMaLop}");
        Console.WriteLine($"Email: {_strEmail}");
        Console.WriteLine($"Điện thoại: {_strDienThoai}");
        Console.WriteLine("----------------------------\n");
    }
}

public class NhanVien : Nguoi {
    private string _strMaNhanVien;
    private string _strEmail;
    private string _strDienThoai;
    private DateTime _ngayLamViec;
    private string _strMaCongTy;

    public string MaNhanVien {
        get {return _strMaNhanVien;}
        set {_strMaNhanVien = value;}
    }

    public string Email {
        get {return _strEmail;}
        set {_strEmail = value;}
    }

    public string DienThoai {
        get {return _strDienThoai;}
        set {_strDienThoai = value;}
    }

    public DateTime NgayLamViec {
        get {return _ngayLamViec;}
        set {_ngayLamViec = value;}
    }

    public string MaCongTy {
        get {return _strMaCongTy;}
        set {_strMaCongTy = value;}
    }

    public NhanVien() {
        _strMaNhanVien = _strEmail = _strDienThoai = _strMaCongTy = "";
        _ngayLamViec = new DateTime();
    }

    public NhanVien(string hoTen, DateTime ngaySinh, string diaChi, string maNhanVien, string email, string dienThoai, DateTime ngayLamViec, string maCongTy) : base(hoTen, ngaySinh, diaChi) {
        _strMaNhanVien = maNhanVien;
        _strEmail = email;
        _strDienThoai = dienThoai;
        _ngayLamViec = ngayLamViec;
        _strMaCongTy = maCongTy;
    }

    public override void XemThongTin() {
        Console.WriteLine("Thông tin nhân viên: ");
        base.XemThongTin();
        Console.WriteLine($"Mã nhân viên: {_strMaNhanVien}");
        Console.WriteLine($"Email: {_strEmail}");
        Console.WriteLine($"Điện thoại: {_strDienThoai}");
        Console.WriteLine($"Ngày làm việc: {_ngayLamViec.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Mã công ty: {_strMaCongTy}");
        Console.WriteLine("----------------------------\n");
    }
}