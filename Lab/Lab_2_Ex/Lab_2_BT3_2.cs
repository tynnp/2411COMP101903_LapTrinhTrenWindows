using System;

public class HinhChuNhat {
    public double mChieuCao {
        get; set;
    }

    public double mChieuRong {
        get; set;
    }

    public HinhChuNhat() {
        mChieuCao = mChieuRong = 0;
    }

    public HinhChuNhat(double chieuCao, double chieuRong) {
        this.mChieuCao = chieuCao;
        this.mChieuRong = chieuRong;
    }

    public double chuVi() {
        return (mChieuCao + mChieuRong) * 2;
    }

    public double dienTich() {
        return mChieuCao * mChieuRong;
    }

    public bool kiemTraHinhVuong() {
        return mChieuCao == mChieuRong;
    }

    public override string ToString() {
        return $"{mChieuRong}-{mChieuCao}-{dienTich()}-{chuVi()}";
    }
}

public class Program {
    public static void Main(string[] args) {
        List<HinhChuNhat> list = new List<HinhChuNhat>();

        list.Add(new HinhChuNhat(3.4, 4.5));
        list.Add(new HinhChuNhat(4.4, 4.4));
        list.Add(new HinhChuNhat(2.3, 7.6));

        foreach (HinhChuNhat hcn in list) 
            Console.WriteLine(hcn);
    }
}   