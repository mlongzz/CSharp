using System;
using System.Text;

class XuLyChuoi
{
    public bool KiemTraDoiXung(string s)
    {
        for (int i = 0; i < s.Length / 2; i++)
            if (s[i] != s[s.Length - 1 - i]) return false;
        return true;
    }

    public string DaoChuoi(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public void XuLyNhieuTu(string s)
    {
        Console.WriteLine($"Chuoi chu thuong: {s.ToLower()}");
        Console.WriteLine($"Chuoi chu hoa: {s.ToUpper()}");

        string[] tu = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"So tu trong chuoi: {tu.Length}");
    }
}