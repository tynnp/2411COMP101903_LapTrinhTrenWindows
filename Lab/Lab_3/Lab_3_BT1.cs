using System;

public class Program {
    public static void Main(string[] args) {
        List<HinhHoc> list = new List<HinhHoc>();
        double tongDienTich = 0, tongChuVi = 0;
        int count = 0;
        HinhHoc chuNhatMax = new HinhChuNhat();
        HinhHoc tronMin = new HinhTron(100);
        
        try {
            using (StreamReader sr = new StreamReader("Lab_3_BT1.txt")) {
                string line;
                while ((line = sr.ReadLine()) != null) {
                    string[] str = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    HinhHoc hinh;
                    // foreach (string s in str)
                    //     Console.WriteLine(s);
                    
                    if (str[0] == "1") {
                        hinh = new HinhChuNhat(double.Parse(str[1]), double.Parse(str[2]));
                        if (hinh.DienTich > chuNhatMax.DienTich)
                            chuNhatMax = hinh;
                    } 
                    
                    else {
                        hinh = new HinhTron(double.Parse(str[1]));
                        if (hinh.ChuVi < tronMin.ChuVi)
                            tronMin = hinh;
                    }

                    count += 1;
                    tongDienTich += hinh.DienTich;
                    tongChuVi += hinh.ChuVi;
                }
            }
        }

        catch (Exception e) {
            Console.WriteLine($"Error: {e.Message}");
        }

        using (StreamWriter sw = new StreamWriter("output.txt")) {
            sw.WriteLine($"So hinh: {count}");
            sw.WriteLine($"Tong dien tich: {tongDienTich:0.00}");
            sw.WriteLine($"Tong chu vi: {tongChuVi:0.00}");
            sw.WriteLine($"Hinh chu nhat co dien tich lon nhat: {chuNhatMax}");
            sw.WriteLine($"Hinh tron co chu vi nho nhat: {tronMin}");
        }
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
        return $"S = {dienTich:0.00}; P = {chuVi:0.00}";
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
        this.TinhDienTichChuVi();
    }

    public HinhChuNhat(double chieuDai, double chieuRong) {
        this.ChieuDai = chieuDai;
        this.ChieuRong = chieuRong;
        this.TinhDienTichChuVi();
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
        return $"L = {mChieuDai}, W = {mChieuRong}; " + base.ToString();
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
        this.TinhDienTichChuVi();
    }

    public HinhTron(double banKinh) {
        this.mbanKinh = banKinh;
        this.TinhDienTichChuVi();
    }

    public override void TinhDienTichChuVi() {
        ChuVi = 2 * Math.PI * mbanKinh;
        DienTich = Math.PI * mbanKinh * mbanKinh;
    }

    public override string ToString() {
        return $"R = {mbanKinh}; " + base.ToString();
    }
}