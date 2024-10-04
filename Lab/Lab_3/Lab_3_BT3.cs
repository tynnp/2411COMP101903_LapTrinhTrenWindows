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

        dt1.inDaThuc();
        dt2.inDaThuc();
        dt3.inDaThuc();
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
        Console.Write("Nhập hệ số: ");
        _heSo = double.Parse(Console.ReadLine());
    }

    public void inDonThuc() {
        Console.Write($"({_heSo}, {_soMu}) ");
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
        Console.Write("Nhập số bậc: ");
        _soBac = int.Parse(Console.ReadLine());

        for (int i = 1; i <= _soBac; i++) {
            Console.WriteLine($"Nhập đa thức bậc {i}:");
            DonThuc donThuc = new DonThuc(i);
            donThuc.nhapDonThuc();
            _listDonThuc.Add(donThuc);
        }
    }

    public void inDaThuc() {
        for (int i = 0; i < _soBac; i++) 
            _listDonThuc[i].inDonThuc();
        Console.WriteLine();
    }
}