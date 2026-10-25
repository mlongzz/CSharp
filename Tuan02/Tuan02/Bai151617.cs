using System;
using System.Collections.Generic;

class XuLyMang
{
    public void Bai15()
    {
        Console.Write("Nhap so phan tu n = ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Mang vua nhap: " + string.Join(", ", a));

        int max = a[0], min = a[0];
        List<int> nguyenTo = new List<int>();
        ThamSoPhuongThuc ts = new ThamSoPhuongThuc(); 

        foreach (int x in a)
        {
            if (x > max) max = x;
            if (x < min) min = x;
            if (ts.KiemTraNguyenTo(x)) nguyenTo.Add(x);
        }

        Console.WriteLine($"Max = {max}, Min = {min}");
        Console.WriteLine("Cac so nguyen to: " + string.Join(", ", nguyenTo));
    }

    public void Bai16()
    {
        Console.Write("Nhap so nguoi n = ");
        int n = int.Parse(Console.ReadLine());
        string[] ds = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap ten thu {i + 1}: ");
            ds[i] = Console.ReadLine();
        }

        Array.Sort(ds);
        Console.WriteLine("Danh sach sau khi sap xep: \n" + string.Join("\n", ds));
    }

    public void Bai17()
    {
        Console.Write("Nhap so hang n: "); int n = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot m: "); int m = int.Parse(Console.ReadLine());

        int[,] a = new int[n, m];
        Random rnd = new Random();
        List<int> chan = new List<int>();
        List<int> le = new List<int>();

        Console.WriteLine("Mang sinh ngau nhien:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = rnd.Next(10, 101); 
                Console.Write(a[i, j] + "\t");

                if (a[i, j] % 2 == 0) chan.Add(a[i, j]);
                else le.Add(a[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Mang chan: " + string.Join(", ", chan));
        Console.WriteLine("Mang le: " + string.Join(", ", le));
    }
}