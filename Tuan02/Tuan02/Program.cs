using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" CHUONG TRINH THUC HANH C# \n");
        // NhapXuatCoBan.ChayMenu();

        Console.WriteLine("\nTEST PHAN 2: THAM SO PHUONG THUC");
        ThamSoPhuongThuc ts = new ThamSoPhuongThuc();

        int max = ts.TimMax3(15, 7, 22);
        Console.WriteLine($"Gia tri lon nhat cua 3 so la: {max}");

        double a = 5.5, b = 9.9;
        Console.WriteLine($"Truoc hoan vi: a = {a}, b = {b}");
        ts.HoanVi(ref a, ref b);
        Console.WriteLine($"Sau hoan vi: a = {a}, b = {b}");

        double maxKq, minKq;
        ts.TimMaxMin(3.2, 8.5, 1.4, out maxKq, out minKq);
        Console.WriteLine($"Trong 3 so, Max = {maxKq} va Min = {minKq}");

        Console.WriteLine("\nTEST PHAN 3: XU LY CHUOI ");
        XuLyChuoi xlChuoi = new XuLyChuoi();

        string chuoiTest = "madam";
        bool laDoiXung = xlChuoi.KiemTraDoiXung(chuoiTest);
        Console.WriteLine($"Chuoi '{chuoiTest}' co doi xung khong? {laDoiXung}");

        Console.WriteLine($"Chuoi dao nguoc cua 'Hello': {xlChuoi.DaoChuoi("Hello")}");

        xlChuoi.XuLyNhieuTu("Lap  trinh   CSharp");

        Console.WriteLine("\nTEST PHAN 4: LOP CO BAN ");
        Console.WriteLine("Nhap thong tin sinh vien:");
        SinhVien sv = new SinhVien();
        sv.Nhap();
        sv.Xuat();

        Console.WriteLine("\nNhap thong tin nhan vien:");
        NhanVien nv = new NhanVien();
        nv.Nhap();
        nv.TinhVaXuatLuong();

        Console.WriteLine("\nTEST PHAN 5: MANG");
        XuLyMang xlMang = new XuLyMang();

        // xlMang.Bai15();
        // xlMang.Bai16();
        // xlMang.Bai17();
        Console.WriteLine("\nNhan phim bat ky de thoat...");
        Console.ReadKey();
    }
}