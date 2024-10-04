using System;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

public class Program {
    public static void Main(string[] args) {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        PrintAuthor();

        DaThuc dt1 = new DaThuc();
        DaThuc dt2 = new DaThuc();

        dt1.nhapDaThuc();
        dt2.nhapDaThuc();

        DaThuc dt3 = new DaThuc(dt1.congDaThuc(dt2));
        DaThuc dt4 = new DaThuc(dt1.truDaThuc(dt2));

        Console.Write("Đơn thức 1: ");
        dt1.inDaThuc();

        Console.Write("Đơn thức 2: ");
        dt2.inDaThuc();

        Console.Write("Đơn thức 1 + đơn thức 2: ");
        dt3.inDaThuc();

        Console.Write("Đơn thức 1 - đơn thức 2: ");
        dt4.inDaThuc();
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

public class DonThuc {
    private double _heSo;
    private double _soMu;

    public double HeSo {
        get {return _heSo;}
        set {_heSo = value;}
    }

    public double SoMu {
        get {return _soMu;}
        set {_soMu = value;}
    }

    public DonThuc() {
        _heSo = _soMu = 0;
    }

    public DonThuc(double heSo, double soMu) {
        _heSo = heSo;
        _soMu = soMu;
    }

    public DonThuc(double soMu) {
        _soMu = soMu;
    }

    public DonThuc congDonThuc(DonThuc other) {
        DonThuc res = new DonThuc(_heSo + other._heSo, _soMu);
        return res;
    }

    public DonThuc truDonThuc(DonThuc other) {
        DonThuc res = new DonThuc(_heSo - other._heSo, _soMu);
        return res;
    }

    public void nhapDonThuc() {
        _heSo = double.Parse(Console.ReadLine());
    }

    public void inDonThuc(ref bool dauTien) {
        if (_heSo == 0) 
            return;

        if (dauTien) {
            if (_heSo < 0)
                Console.Write("-");
            dauTien = false;
        } 
        
        else {
            if (_heSo < 0)
                Console.Write(" - ");
            else   
                Console.Write(" + ");
        }

        double n = Math.Abs(_heSo);
        if (n != 1) 
            Console.Write(n);
        
        Console.Write('x');
        if (_soMu > 1) 
            Console.Write($"^{_soMu}");
    }
}

public class DaThuc {
    private int _soBac;
    private List<DonThuc> _listDonThuc;

    public int SoBac {
        get {return _soBac;}
        set {_soBac = value;}
    }

    public List<DonThuc> ListDonThuc {
        get {return _listDonThuc;}
        set {_listDonThuc = value;}
    }

    public DaThuc() {
        _soBac = 0;
        _listDonThuc = new List<DonThuc>();
    }

    public DaThuc(int soBac) {
        _soBac = soBac;
        _listDonThuc = new List<DonThuc>();

        for (int i = 0; i < soBac; i++) 
            _listDonThuc.Add(new DonThuc(i+1));
    }

    public DaThuc(DaThuc other) {
        _soBac = other._soBac;
        _listDonThuc = other._listDonThuc;
    }

    public DaThuc congDaThuc(DaThuc other) {
        DaThuc res = new DaThuc(Math.Max(_soBac, other._soBac));

        for (int i = 0; i < res._soBac; i++) {
            if (i < _soBac && i < other._soBac) 
                res._listDonThuc[i] = _listDonThuc[i].congDonThuc(other._listDonThuc[i]);  
            else if (i < _soBac)
                res._listDonThuc[i] = _listDonThuc[i];
            else 
                res._listDonThuc[i] = other._listDonThuc[i];
        }

        return res;
    } 

    public DaThuc truDaThuc(DaThuc other) {
        DaThuc res = new DaThuc(Math.Max(_soBac, other._soBac));

        for (int i = 0; i < res._soBac; i++) {
            if (i < _soBac && i < other._soBac) 
                res._listDonThuc[i] = _listDonThuc[i].truDonThuc(other._listDonThuc[i]);  
            else if (i < _soBac)
                res._listDonThuc[i] = _listDonThuc[i];
            else 
                res._listDonThuc[i] = other._listDonThuc[i];
        }

        return res;
    }

    public void nhapDaThuc() {
        Console.Write("Nhập số bậc của đa thức: ");
        _soBac = int.Parse(Console.ReadLine());

        for (int i = 1; i <= _soBac; i++) {
            Console.Write($"Nhập hệ số đơn thức bậc {i}: ");
            DonThuc donThuc = new DonThuc(i);
            donThuc.nhapDonThuc();
            _listDonThuc.Add(donThuc);
        }

        Console.WriteLine("Nhập thành công!\n");
    }

    public void inDaThuc() {
        bool dauTien = true;
        for (int i = 0; i < _soBac; i++) 
            _listDonThuc[i].inDonThuc(ref dauTien);
        Console.WriteLine();
    }
}