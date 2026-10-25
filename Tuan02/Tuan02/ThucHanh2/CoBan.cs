using System;

namespace Phan1_ThietKeLopCoBan
{
    public class SinhVien1
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public void Nhap()
        {
            Console.Write("Nhap ho ten: "); HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: "); NamSinh = int.Parse(Console.ReadLine());
        }
        public int TinhTuoi() => DateTime.Now.Year - NamSinh;
    }

    public class Point
    {
        private double x, y;
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Point() { x = 0; y = 0; }
        public Point(double x, double y) { this.x = x; this.y = y; }

        public void Input()
        {
            Console.Write("Nhap x: "); x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y: "); y = double.Parse(Console.ReadLine());
        }
        public override string ToString() => $"({x}, {y})";

        public static Point operator +(Point a, Point b) => new Point(a.x + b.x, a.y + b.y);
        public static Point operator -(Point a, Point b) => new Point(a.x - b.x, a.y - b.y);
        public static Point operator -(Point a) => new Point(-a.x, -a.y);

        public double KhoangCach(Point b) => Math.Sqrt(Math.Pow(this.x - b.x, 2) + Math.Pow(this.y - b.y, 2));
        public static double KhoangCach(Point a, Point b) => a.KhoangCach(b);
        public Point TrungDiem(Point b) => new Point((this.x + b.x) / 2, (this.y + b.y) / 2);
        public static Point TrungDiem(Point a, Point b) => a.TrungDiem(b);
    }

    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public int Yod { get; set; }

        public Person() { }
        public Person(Person p) { Id = p.Id; Name = p.Name; Yob = p.Yob; Yod = p.Yod; }

        public void Input()
        {
            Console.Write("Id: "); Id = Console.ReadLine();
            Console.Write("Name: "); Name = Console.ReadLine();
            Console.Write("Nam sinh: "); Yob = int.Parse(Console.ReadLine());
            Console.Write("Nam mat (0 neu con song): "); Yod = int.Parse(Console.ReadLine());
        }
        public void Output() => Console.WriteLine($"ID: {Id}, Name: {Name}, Sinh: {Yob}, Mat: {(Yod == 0 ? "Chua" : Yod.ToString())}");
        public bool IsLiving() => Yod == 0;
    }

    public class PhanSo
    {
        public int Tu { get; set; }
        public int Mau { get; set; }

        public PhanSo() { Tu = 0; Mau = 1; }
        public PhanSo(int tu, int mau) { Tu = tu; Mau = mau == 0 ? 1 : mau; }
        public PhanSo(PhanSo p) { Tu = p.Tu; Mau = p.Mau; }

        public override string ToString() => $"{Tu}/{Mau}";

        public static PhanSo operator +(PhanSo a, PhanSo b) => new PhanSo(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
        public static PhanSo operator -(PhanSo a, PhanSo b) => new PhanSo(a.Tu * b.Mau - b.Tu * a.Mau, a.Mau * b.Mau);
        public static PhanSo operator *(PhanSo a, PhanSo b) => new PhanSo(a.Tu * b.Tu, a.Mau * b.Mau);
        public static PhanSo operator /(PhanSo a, PhanSo b) => new PhanSo(a.Tu * b.Mau, a.Mau * b.Tu);
        public static PhanSo operator +(PhanSo a) => a;
        public static PhanSo operator -(PhanSo a) => new PhanSo(-a.Tu, a.Mau);

        public static bool operator >(PhanSo a, PhanSo b) => (double)a.Tu / a.Mau > (double)b.Tu / b.Mau;
        public static bool operator <(PhanSo a, PhanSo b) => (double)a.Tu / a.Mau < (double)b.Tu / b.Mau;
        public static bool operator >=(PhanSo a, PhanSo b) => !(a < b);
        public static bool operator <=(PhanSo a, PhanSo b) => !(a > b);
        public static bool operator ==(PhanSo a, PhanSo b) => a.Tu * b.Mau == b.Tu * a.Mau;
        public static bool operator !=(PhanSo a, PhanSo b) => !(a == b);

        public override bool Equals(object obj) => obj is PhanSo so && this == so;
        public override int GetHashCode() => Tu.GetHashCode() ^ Mau.GetHashCode();
    }

    public class DonThuc
    {
        public double HeSoA { get; set; }
        public int BacN { get; set; }

        public DonThuc(double a, int n) { HeSoA = a; BacN = n >= 0 ? n : 0; }
        public double TinhGiaTri(double x) => HeSoA * Math.Pow(x, BacN);
        public DonThuc DaoHam() => BacN == 0 ? new DonThuc(0, 0) : new DonThuc(HeSoA * BacN, BacN - 1);
        public override string ToString() => $"{HeSoA}x^{BacN}";
    }
}