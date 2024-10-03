using System;

public class Program {
    public static void Main(string[] args) {
        HinhHoc a = new HinhChuNhat(3, 4);
        HinhHoc b = new HinhTron(5);
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
} 

class HinhHoc {
    private double dienTich;
    private double chuVi;

    public double DienTich {
        get {return dienTich;}
        set {dienTich = value;}
    }

    public double ChuVi {
        get {return chuVi;}
        set {chuVi = value;}
    }

    public virtual void TinhDienTichChuVi() {}

    public override string ToString() {
        this.TinhDienTichChuVi();
        return $"Diện tích: {dienTich}, Chu Vi: {chuVi}";
    }
}

class HinhChuNhat : HinhHoc {
    private double mChieuDai;
    private double mChieuRong;

    public double ChieuDai {
        get {return mChieuDai;}
        set {mChieuDai = value;}
    }

    public double ChieuRong {
        get {return mChieuRong;}
        set {mChieuRong = value;}
    }

    public HinhChuNhat() {
        ChieuDai = ChieuRong = 0;
    }

    public HinhChuNhat(double chieuDai, double chieuRong) {
        this.ChieuDai = chieuDai;
        this.ChieuRong = chieuRong;
    }

    public HinhChuNhat(HinhChuNhat other) {
        this.DienTich = other.DienTich;
        this.ChuVi = other.ChuVi;
        this.ChieuDai = other.ChieuDai;
        this.ChieuRong = other.ChieuRong;
    }

    public override void TinhDienTichChuVi() {
        ChuVi = (ChieuDai + ChieuRong) * 2;
        DienTich = ChieuDai * ChieuRong;
    }

    public override string ToString() {
        return base.ToString();
    }
}

class HinhTron : HinhHoc {
    private double mbanKinh;

    public double BanKinh {
        get {return mbanKinh;}
        set {mbanKinh = value;}
    }

    public HinhTron() {
        BanKinh = 0;
    }

    public HinhTron(double banKinh) {
        this.mbanKinh = banKinh;
    }

    public override void TinhDienTichChuVi() {
        ChuVi = 2 * Math.PI * mbanKinh;
        DienTich = Math.PI * mbanKinh * mbanKinh;
    }

    public override string ToString() {
        return base.ToString();
    }
}