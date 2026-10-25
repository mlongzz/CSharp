using System;
using Phan1_ThietKeLopCoBan;
using Phan2_ThietKeLopNangCao;
using Phan3_KeThuaVaDaHinh;

namespace ThucHanhTuan2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PHAN 1: THIET KE LOP CO BAN");
          
            Point p1 = new Point(3, 4);
            Point p2 = new Point(6, 8);
            Console.WriteLine($"Diem P1: {p1}");
            Console.WriteLine($"Khoang cach P1 den P2: {p1.KhoangCach(p2)}");

            PhanSo ps1 = new PhanSo(1, 2);
            PhanSo ps2 = new PhanSo(3, 4);
            PhanSo tongPS = ps1 + ps2;
            Console.WriteLine($"\nTong 2 phan so {ps1} + {ps2} = {tongPS}");


            Console.WriteLine("\nTEST PHAN 3: KE THUA VA DA HINH");

            NVKinhDoanh nvkd = new NVKinhDoanh()
            {
                MaNV = "NV01",
                HoTen = "Nguyen Van A",
                LuongCoBan = 5000000,
                SoHopDong = 3
            };
            Console.WriteLine($"Nhan vien KD {nvkd.HoTen} co luong: {nvkd.TinhLuong():N0} VND");

            NVSanXuat nvsx = new NVSanXuat()
            {
                MaNV = "NV02",
                HoTen = "Tran Thi B",
                SoSanPham = 3500
            };
            Console.WriteLine($"Nhan vien SX {nvsx.HoTen} co luong: {nvsx.TinhLuong():N0} VND");

            ThiSinhChuyen tsChuyen = new ThiSinhChuyen()
            {
                SBD = "C01",
                HoTen = "Le Van C",
                Bai1 = 8,
                Bai2 = 9,
                Bai3 = 7.5,
                TiengAnh = 9.5
            };
            tsChuyen.TinhTongDiem();
            Console.WriteLine($"\nThi sinh Chuyen {tsChuyen.HoTen} - Tong diem: {tsChuyen.TongDiem}");

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}