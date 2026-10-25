using System;

class NhapXuatCoBan
{
    public static void ChayMenu()
    {
        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
            Console.WriteLine("2. Tinh x^y");
            Console.WriteLine("3. Tinh can bac 2 cua x va y");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");

            string chon = Console.ReadLine();
            double x = 0, y = 0;

            if (chon == "4") break;

            switch (chon)
            {
                case "1":
                    Console.Write("Nhap x: ");
                    while (!double.TryParse(Console.ReadLine(), out x))
                        Console.Write("Loi! Nhap lai x: ");

                    Console.Write("Nhap y: ");
                    while (!double.TryParse(Console.ReadLine(), out y))
                        Console.Write("Loi! Nhap lai y: ");
                    break;
                case "2":
                    Console.WriteLine($"Ket qua x^y = {Math.Pow(x, y)}");
                    break;
                case "3":
                    Console.WriteLine($"Can bac 2 cua x: {Math.Sqrt(x)}, y: {Math.Sqrt(y)}");
                    break;
                default:
                    Console.WriteLine("Vui long chon tu 1 den 4.");
                    break;
            }
        }
    }
}