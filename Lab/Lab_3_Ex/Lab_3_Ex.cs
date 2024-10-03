using System;
using DuongTron;

namespace DuongTron {
    class Program {
        public static void Main(string[] args) {
            DuongTron dt = new DuongTron();
            dt.xuatDuongTron();

            Diem point = new Diem(1, 3);
            DuongTron dt2 = new DuongTron(point, 10);
            dt2.xuatDuongTron();

            DuongTron dt3 = new DuongTron(dt2);
            dt3.xuatDuongTron();

            double chuVi = dt2.chuVi();
            Console.Write($"Chu vi đường tròn: {chuVi}");
        }
    }

    class Diem {
        private int x, y;

        public int X {
            get {return x;}
            set {x = value;}
        }

        public int Y {
            get {return y;}
            set {y = value;}
        }

        public Diem() {
            X = Y = 0;
        }

        public Diem(int x, int y) {
            this.X = x;
            this.Y = y;
        }

        public Diem(Diem ohter) {
            this.X = ohter.X;
            this.Y = ohter.Y;
        }

        public double khoangCach(Diem other) {
            return Math.Sqrt(Math.Pow(other.Y - this.Y, 2) + Math.Pow(other.X - this.X, 2));
        }

        public void nhapDiem() {
            int x, y;

            Console.Write("Nhập tọa độ x: ");
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.Write("Nhập tọa độ x: ");

            Console.Write("Nhập tọa độ y: ");
            while (!int.TryParse(Console.ReadLine(), out y)) 
                Console.Write("Nhập tọa độ y: ");
            
            this.X = x;
            this.Y = y;
        }

        public void xuatDiem() {
            Console.WriteLine(this);
        }

        public override string ToString() {
            return $"({this.x}, {this.y})";
        }
    }

    class DuongTron {
        private Diem tam;
        private double banKinh;

        public Diem Tam {
            get {return tam;}
            set {tam = value;}
        }

        public double BanKinh {
            get {return banKinh;}
            set {banKinh = value;}
        }

        public DuongTron() {
            tam = new Diem();
            banKinh = 0;
        }

        public DuongTron(Diem tam, double bankinh) {
            this.Tam = tam;
            this.BanKinh = bankinh;
        }

        public DuongTron(DuongTron other) {
            this.Tam = other.tam;
            this.BanKinh = other.banKinh;
        }

        public void nhapDuongTron() {
            double banKinh;
            tam.nhapDiem();
            
            Console.Write("Nhập bán kính: ");
            while(!double.TryParse(Console.ReadLine(), out banKinh))
                Console.Write("Nhập bán kính: ");
        }

        public void xuatDuongTron() {
            Console.WriteLine(this);
        }

        public double dienTich() {
            return Math.PI * banKinh * banKinh;
        }

        public double chuVi() {
            return 2 * Math.PI * banKinh;
        }

        public string viTriTuongDoi(DuongTron other) {
            double d = this.tam.khoangCach(other.tam);

            if (d > this.banKinh + other.banKinh)
                return "Không giao nhau, không tiếp xúc";

            else if (d == this.banKinh + other.banKinh)
                return "Tiếp xúc ngoài";

            else if (Math.Abs(this.banKinh - other.banKinh) < d && d < (this.banKinh + other.banKinh))
                return "Cắt nhau tại hai điểm";

            else if (d == Math.Abs(this.banKinh - other.banKinh))
                return "Tiếp xúc trong";

            else 
                return "Chứa trong";
        }

        public string viTriTuongDoi(Diem diem) {
            double d = this.tam.khoangCach(diem);

            if (d > this.banKinh)
                return "Nằm ngoài đường tròn";

            else if (d == this.banKinh)
                return "Nằm trên đường tròn";

            else 
                return "Nằm trong đường tròn";
        }

        public override string ToString() {
            return $"{tam}, {banKinh}";
        }
    }
}
