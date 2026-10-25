using System;

class SinhVien
{
    public string MaSV, HoTen, DiaChi;
    public int NamHoc;

    public void Nhap()
    {
        Console.Write("Nhap Ma SV: "); MaSV = Console.ReadLine();
        Console.Write("Nhap Ho Ten: "); HoTen = Console.ReadLine();
        Console.Write("Nhap Dia Chi: "); DiaChi = Console.ReadLine();
        Console.Write("Nam hoc thu may: "); int.TryParse(Console.ReadLine(), out NamHoc);
    }

    public void Xuat()
    {
        Console.WriteLine($"SV: {MaSV} - {HoTen} - {DiaChi} - Nam: {NamHoc}");
    }
}

class NhanVien
{
    public string HoTen;
    public double MucLuong;
    public int SoNgayVang;

    public void Nhap()
    {
        Console.Write("Nhap Ho Ten NV: "); HoTen = Console.ReadLine();
        Console.Write("Muc luong: "); double.TryParse(Console.ReadLine(), out MucLuong);
        Console.Write("So ngay vang: "); int.TryParse(Console.ReadLine(), out SoNgayVang);
    }

    public void TinhVaXuatLuong()
    {
        double luongThucLanh = MucLuong - (SoNgayVang * 100000);
        Console.WriteLine($"Nhan vien {HoTen} thuc lanh: {luongThucLanh:N0} VND");
    }
}