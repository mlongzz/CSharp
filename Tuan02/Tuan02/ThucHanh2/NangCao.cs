using System;
using System.Collections.Generic;
using Phan1_ThietKeLopCoBan; 

namespace Phan2_ThietKeLopNangCao
{
    public class ArrayPoint
    {
        private List<Point> points = new List<Point>();
        public Point this[int i]
        {
            get => points[i];
            set { if (i >= 0 && i < points.Count) points[i] = value; else points.Add(value); }
        }
        public void Add(Point p) => points.Add(p);
    }

    public class PersonList
    {
        private List<Person> list = new List<Person>();
        public PersonList() { }
        public PersonList(PersonList pl) { list = new List<Person>(pl.list); }

        public void Add(Person p) => list.Add(p);
        public PersonList LivingPeople()
        {
            PersonList result = new PersonList();
            foreach (var p in list) if (p.IsLiving()) result.Add(p);
            return result;
        }
    }

    public class DaySo
    {
        private int[] data;
        public DaySo(int n) { data = new int[n]; }
        public int this[int i] { get => data[i]; set => data[i] = value; }

        public void Nhap()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"Phan tu {i}: ");
                data[i] = int.Parse(Console.ReadLine());
            }
        }
        public void InSoChan()
        {
            foreach (var item in data) if (item % 2 == 0) Console.Write(item + " ");
        }
    }

    public class Mang2Chieu
    {
        private int[,] data;
        public Mang2Chieu(int n, int m) { data = new int[n, m]; }
        public int this[int i, int j] { get => data[i, j]; set => data[i, j] = value; }

        private bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++) if (num % i == 0) return false;
            return true;
        }
        public void TimSoNguyenTo()
        {
            foreach (var item in data) if (IsPrime(item)) Console.Write(item + " ");
        }
    }

    public class DaThuc
    {
        private DonThuc[] arr;
        public DaThuc(int n) { arr = new DonThuc[n + 1]; }
        public DonThuc this[int i] { get => arr[i]; set => arr[i] = value; }
        public double TinhGiaTri(double x)
        {
            double sum = 0;
            foreach (var dt in arr) if (dt != null) sum += dt.TinhGiaTri(x);
            return sum;
        }
    }

    public class DayPhanSo
    {
        private List<PhanSo> danhSach = new List<PhanSo>();
        public void Add(PhanSo ps) => danhSach.Add(ps);
        public PhanSo TinhTong()
        {
            PhanSo tong = new PhanSo(0, 1);
            foreach (var ps in danhSach) tong += ps;
            return tong;
        }
    }

    public class NhanVienCoBan
    {
        public string HoTen { get; set; }
        public double MucLuong { get; set; }
        public int NgayVang { get; set; }
        public double TinhLuong() => MucLuong - (NgayVang * 100000);
    }
    public class PhongBan
    {
        private List<NhanVienCoBan> ds = new List<NhanVienCoBan>();
        public void Add(NhanVienCoBan nv) => ds.Add(nv);
        public double TongLuong()
        {
            double tong = 0;
            foreach (var nv in ds) tong += nv.TinhLuong();
            return tong;
        }
    }
}