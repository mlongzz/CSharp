<Query Kind="Program" />

using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLINQ
{
    // ==========================================
    // CÁC LỚP DỮ LIỆU VÀ KHỞI TẠO NGUỒN DỮ LIỆU
    // ==========================================
    public class MonHoc
    {
        public string MaMon { get; set; } = "";
        public string TenMon { get; set; } = "";
        public string He { get; set; } = "";
        public byte SoTiet { get; set; }
    }

    public class He
    {
        public string MaHe { get; set; } = "";
        public string TenHe { get; set; } = "";
    }

    public class DuLieu
    {
        public static List<MonHoc> DS_Mon()
        {
            return new List<MonHoc>
            {
                new MonHoc { MaMon = "HP2 1", TenMon = "Nền tảng C#", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP2 2", TenMon = "Công nghệ ADO.NET", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP3 1", TenMon = "Lập trình Windows Forms", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP3 2", TenMon = "Xây dựng ứng dụng Windows Forms", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP4 1", TenMon = "Lập trình Web với HTML, CSS và JavaScript", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP4 2", TenMon = "Xây dựng ứng dụng Web với ASP.NET", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP5 1", TenMon = "Lập trình CSDL SQL Server căn bản", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP5 2", TenMon = "Lập trình CSDL SQL Server nâng cao", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "JLCB", TenMon = "Joomla cơ bản", He = "CD", SoTiet = 72 },
                new MonHoc { MaMon = "LINQ", TenMon = "Language-Integrated Query", He = "CD", SoTiet = 64 },
                new MonHoc { MaMon = "DAWEB", TenMon = "Đồ án thực tế Web với ASP.NET", He = "CD", SoTiet = 40 },
                new MonHoc { MaMon = "DAWIN", TenMon = "Đồ án thực tế Windows Forms", He = "CD", SoTiet = 40 },
                new MonHoc { MaMon = "CC++", TenMon = "Lập trình hướng đối tượng với C/C++", He = "CD", SoTiet = 128 },
                new MonHoc { MaMon = "JQUE", TenMon = "JQuery", He = "CD", SoTiet = 22 },
                new MonHoc { MaMon = "XML", TenMon = "Công nghệ XML", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "CRYS", TenMon = "Crystal Report trong Visual Studio", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "BWEB", TenMon = "HTML, CSS và JavaScript", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "XYZ", TenMon = "Chưa đặt tên môn", He = "", SoTiet = 0 }
            };
        }

        public static List<He> DS_He()
        {
            return new List<He>
            {
                new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
                new He { MaHe = "CD", TenHe = "Chuyên đề" },
                new He { MaHe = "OT", TenHe = "Chứng chỉ quốc tế" }
            };
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Bai21();
            // Bai22();
            // Bai31();
            // Bai32();
            // Bai51();
            // Bai52();
            // Bai62();

            Console.ReadLine();
        }

        static void Bai21()
        {
            Console.WriteLine("Bài 2.1. Truy vấn mảng số nguyên");
            int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

            Console.WriteLine("a. Liệt kê các phần tử chia hết cho 4 và 3:");
            var chiaHet4Va3 = mangSo.Where(x => x % 4 == 0 && x % 3 == 0);
            Console.WriteLine(string.Join(", ", chiaHet4Va3));

            Console.WriteLine("\nb. Liệt kê các phần tử nhỏ hơn hoặc bằng 3:");
            var nhoHonBang3 = from so in mangSo where so <= 3 select so; 
            Console.WriteLine(string.Join(", ", nhoHonBang3));

            Console.WriteLine("\nc. Tạo một dãy mới: số chẵn chia đôi, số lẻ giữ nguyên:");
            var dayMoi = mangSo.Select(x => x % 2 == 0 ? x / 2 : x);
            Console.WriteLine(string.Join(", ", dayMoi));
        }

        static void Bai22()
        {
            Console.WriteLine("Bài 2.2. Truy vấn mảng chuỗi");
            string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga", "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

            Console.WriteLine("a. Phần tử 4 ký tự, xếp tăng dần ký tự đầu:");
            var cauA = mangChuoi.Where(s => s.Length == 4).OrderBy(s => s[0]);
            Console.WriteLine(string.Join(", ", cauA));

            Console.WriteLine("\nb. Biến đổi: <chữ thường> - <CHỮ HOA>:");
            var cauB = mangChuoi.Select(s => $"{s.ToLower()} - {s.ToUpper()}");
            foreach (var item in cauB) Console.WriteLine(item);

            Console.WriteLine("\nc. Phần tử chứa ký tự 'u':");
            var cauC = mangChuoi.Where(s => s.Contains("u"));
            Console.WriteLine(string.Join(", ", cauC));

            Console.WriteLine("\nd. Phần tử bắt đầu bằng chữ hoa:");
            var cauD = mangChuoi.Where(s => !string.IsNullOrEmpty(s) && char.IsUpper(s[0]));
            Console.WriteLine(string.Join(" ", cauD));
        }

        static void Bai31()
        {
            Console.WriteLine("Bài 3.1. Thống kê mảng số");
            int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

            Console.WriteLine($"a. Tổng số PT: {mangSo.Count()}, Chẵn: {mangSo.Count(x => x % 2 == 0)}, Lẻ: {mangSo.Count(x => x % 2 != 0)}");
            Console.WriteLine($"b. Tổng: {mangSo.Sum()}, Max: {mangSo.Max()}, Min: {mangSo.Min()}");
            Console.WriteLine($"c. Số giá trị khác nhau: {mangSo.Distinct().Count()}");
            
            Console.WriteLine("d. Phân nhóm theo số dư khi chia 5:");
            var nhomDu5 = mangSo.GroupBy(x => x % 5);
            foreach (var nhom in nhomDu5)
            {
                Console.WriteLine($"- Số dư {nhom.Key}: {string.Join(", ", nhom)}");
            }
        }

        static void Bai32()
        {
            Console.WriteLine("Bài 3.2. Thống kê mảng chuỗi");
            string[] monAn = { "Nước canh", "Bánh mì", "Cà phê", "Bún bò Huế", "Hủ tiếu heo", "Bánh dây", "Mì xào", "Mì quảng", "Cơm tấm", "Nước Chanh", "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };

            int minLen = monAn.Min(x => x.Length);
            int maxLen = monAn.Max(x => x.Length);
            Console.WriteLine($"a. Ngắn nhất: {string.Join(", ", monAn.Where(x => x.Length == minLen))}");
            Console.WriteLine($"   Dài nhất: {string.Join(", ", monAn.Where(x => x.Length == maxLen))}");

            Console.WriteLine("\nb. Phân nhóm theo từ đầu tiên:");
            var nhomTuDau = monAn.GroupBy(x => x.Split(' ')[0]);
            foreach (var nhom in nhomTuDau)
            {
                Console.WriteLine($"- {nhom.Key}: {string.Join(", ", nhom)}");
            }

            Console.WriteLine($"\nc. Số phần tử bắt đầu bằng 'Bánh': {monAn.Count(x => x.StartsWith("Bánh"))}");
        }

        static void Bai51()
        {
            Console.WriteLine("Bài 5.1. Truy vấn cơ bản ");
            var ds = DuLieu.DS_Mon();

            Console.WriteLine("a. Các môn bắt đầu bằng 'Lập trình':");
            var cauA = ds.Where(m => m.TenMon.StartsWith("Lập trình"));
            foreach (var m in cauA) Console.WriteLine($"- {m.TenMon}");

            Console.WriteLine("\nb. Môn hệ CD, số tiết giảm dần, mã môn tăng dần:");
            var cauB = ds.Where(m => m.He == "CD").OrderByDescending(m => m.SoTiet).ThenBy(m => m.MaMon);
            foreach (var m in cauB) Console.WriteLine($"- {m.MaMon}: {m.TenMon} ({m.SoTiet} tiết)");

            Console.WriteLine("\nc. Môn chứa từ 'web' (Tên môn - Hệ):");
            var cauC = ds.Where(m => m.TenMon.ToLower().Contains("web")).Select(m => new { m.TenMon, m.He });
            foreach (var m in cauC) Console.WriteLine($"- {m.TenMon} - {m.He}");

            Console.WriteLine("\nd. Môn hệ KTV, mã môn tăng dần:");
            var cauD = ds.Where(m => m.He == "KTV").OrderBy(m => m.MaMon);
            foreach (var m in cauD) Console.WriteLine($"- {m.MaMon}: {m.TenMon}");
        }

        static void Bai52()
        {
            Console.WriteLine("Bài 5.2. Thống kê trên List<MonHoc>");
            var ds = DuLieu.DS_Mon();

            Console.WriteLine($"a. Tổng số môn: {ds.Count}");
            Console.WriteLine($"b. Số môn bắt đầu 'Lập trình': {ds.Count(m => m.TenMon.StartsWith("Lập trình"))}");
            Console.WriteLine($"c. Tổng số tiết hệ KTV: {ds.Where(m => m.He == "KTV").Sum(m => m.SoTiet)}");

            Console.WriteLine("\nd. Tổng số môn mỗi hệ:");
            var cauD = ds.GroupBy(m => string.IsNullOrEmpty(m.He) ? "Chưa rõ" : m.He)
                         .Select(g => new { He = g.Key, TongMon = g.Count() });
            foreach (var item in cauD) Console.WriteLine($"- Hệ {item.He}: {item.TongMon} môn");

            Console.WriteLine("\ne. Nhóm theo số tiết (giảm dần):");
            var cauE = ds.GroupBy(m => m.SoTiet).OrderByDescending(g => g.Key);
            foreach (var item in cauE) Console.WriteLine($"- {item.Key} tiết: {item.Count()} môn");

            Console.WriteLine("\nf. Môn có số tiết cao nhất:");
            var maxTiet = ds.Max(m => m.SoTiet);
            var monMaxTiet = ds.Where(m => m.SoTiet == maxTiet);
            foreach (var m in monMaxTiet) Console.WriteLine($"- {m.TenMon} ({m.SoTiet} tiết)");

            Console.WriteLine("\ng. Thống kê theo Hệ:");
            var cauG = ds.Where(m => !string.IsNullOrEmpty(m.He))
                         .GroupBy(m => m.He)
                         .Select(g => new {
                             He = g.Key,
                             TongMon = g.Count(),
                             TongTiet = g.Sum(x => x.SoTiet),
                             MaxTiet = g.Max(x => x.SoTiet),
                             MinTiet = g.Min(x => x.SoTiet)
                         });
            foreach (var item in cauG) 
                Console.WriteLine($"- Hệ {item.He}: {item.TongMon} môn, Tổng tiết: {item.TongTiet}, Max: {item.MaxTiet}, Min: {item.MinTiet}");
        }

        static void Bai62()
        {
            Console.WriteLine("Bài 6.2. Join và các toán tử tập hợp");
            var dsMon = DuLieu.DS_Mon();
            var dsHe = DuLieu.DS_He();

            Console.WriteLine("a. Join liệt kê Tên hệ, Mã môn, Tên môn:");
            var cauA = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He
                       select new { h.TenHe, m.MaMon, m.TenMon };
            foreach (var item in cauA) Console.WriteLine($"- {item.TenHe}: {item.MaMon} - {item.TenMon}");

            Console.WriteLine("\nb. Liệt kê cả những hệ chưa có môn học (Left Outer Join):");
            var cauB = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He into groupMonHoc
                       from subMon in groupMonHoc.DefaultIfEmpty()
                       select new { 
                           h.TenHe, 
                           MaMon = subMon?.MaMon ?? "[Chưa có môn]", 
                           TenMon = subMon?.TenMon ?? "" 
                       };
            foreach (var item in cauB) Console.WriteLine($"- {item.TenHe}: {item.MaMon} {item.TenMon}");
            
            Console.WriteLine("\ne. 5 môn học đầu tiên có số tiết giảm dần:");
            var cauE = (from m in dsMon
                        join h in dsHe on m.He equals h.MaHe into gh
                        from subHe in gh.DefaultIfEmpty()
                        orderby m.SoTiet descending
                        select new { 
                            TenHe = subHe?.TenHe ?? "[Không rõ]", 
                            m.MaMon, m.TenMon, m.SoTiet 
                        }).Take(5);
            foreach (var item in cauE) Console.WriteLine($"- {item.TenHe} | {item.MaMon} | {item.TenMon} | {item.SoTiet}");
            
            Console.WriteLine("\nf. Tổng số môn học của mỗi hệ:");
            var cauF = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He into gm
                       select new { h.MaHe, h.TenHe, TongMon = gm.Count() };
            foreach (var item in cauF) Console.WriteLine($"- {item.MaHe} ({item.TenHe}): {item.TongMon} môn");
        }
    }
}