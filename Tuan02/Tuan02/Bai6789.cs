using System;

class ThamSoPhuongThuc
{
    public int TimMax3(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    public bool KiemTraNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    public void HoanVi(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }

    public void TimMaxMin(double a, double b, double c, out double max, out double min)
    {
        max = Math.Max(a, Math.Max(b, c));
        min = Math.Min(a, Math.Min(b, c));
    }
}