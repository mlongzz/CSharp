using System;
using System.Collections.Generic;

namespace Phan3_KeThuaVaDaHinh
{
    public class SanPham : IComparable<SanPham>
    {
        public string Ten { get; set; }
        public double Gia { get; set; }

        public int CompareTo(SanPham other) => this.Gia.CompareTo(other.Gia);
    }

    public delegate bool SoSanhDelegate(object a, object b);
    public class BoSapXep
    {
        public static void Sort(object[] arr, SoSanhDelegate cmp)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (cmp(arr[i], arr[j]))
                    {
                        object temp = arr[i]; arr[i] = arr[j]; arr[j] = temp;
                    }
        }
    }
    public abstract class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public double LuongCoBan { get; set; }
        public abstract double TinhLuong();
    }

    public class NVKinhDoanh : NhanVien
    {
        public int SoHopDong { get; set; }
        public override double TinhLuong() => LuongCoBan + (SoHopDong * 500000);
    }

    public class NVSanXuat : NhanVien
    {
        public int SoSanPham { get; set; }
        public override double TinhLuong()
        {
            double luong = SoSanPham * 1000;
            if (SoSanPham > 3000) luong += luong * 0.05;
            return luong;
        }
    }
    public abstract class ThiSinh
    {
        public string SBD { get; set; }
        public string HoTen { get; set; }
        public double Bai1 { get; set; }
        public double Bai2 { get; set; }
        public double Bai3 { get; set; }
        public double TongDiem { get; protected set; }

        public abstract void TinhTongDiem();
    }

    public class ThiSinhChuyen : ThiSinh
    {
        public double TiengAnh { get; set; }
        public override void TinhTongDiem()
        {
            TongDiem = Bai1 + Bai2 + Bai3;
            if (TiengAnh >= 9) TongDiem += 2;
            else if (TiengAnh >= 7) TongDiem += 1;
        }
    }

    public class ThiSinhSieuCup : ThiSinh
    {
        public double CSDL { get; set; }
        public override void TinhTongDiem()
        {
            TongDiem = Bai1 + Bai2 + Bai3 + CSDL;
        }
    }
}