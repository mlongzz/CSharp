using System;

class Bai1
{
    static void Main()
    {
        Console.Write("Moi ban nhap chieu cao h: ");
        if (!int.TryParse(Console.ReadLine(), out int h) || h <= 0)
        {
            Console.WriteLine("Chieu cao khong hop le!");
            return;
        }
        for (int k = 0; k < 3; k++)
        {
            int currentH = h + k * 2;
            Console.WriteLine($"h={currentH}");
            InTamGiac(currentH);
        }
    }

    static void InTamGiac(int h)
    {
        for (int i = 1; i <= h; i++)
        {
            Console.Write(new string(' ', (h - i) * 2));

            if (i == 1)
            {
                Console.WriteLine("*");
            }
            else if (i < h)
            {
                int innerSpaces = (i - 1) * 4 - 1;
                Console.WriteLine("*" + new string(' ', innerSpaces) + "*");
            }
            else
            {
                for (int j = 1; j <= 2 * h - 1; j++)
                {
                    Console.Write(j == 1 ? "*" : " *");
                }
                Console.WriteLine();
            }
        }
    }
}