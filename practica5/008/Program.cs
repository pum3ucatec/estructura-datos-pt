using System;

class Program
{
    static int BuscarEnRotado(int[] a, int objetivo)
    {
        int l = 0, r = a.Length - 1;
        while (l <= r)
        {
            int m = l + (r - l) / 2;
            if (a[m] == objetivo) return m;
            if (a[l] <= a[m])
            {
                if (a[l] <= objetivo && objetivo < a[m]) r = m - 1;
                else l = m + 1;
            }
            else
            {
                if (a[m] < objetivo && objetivo <= a[r]) l = m + 1;
                else r = m - 1;
            }
        }
        return -1;
    }

    static void Main()
    {
        Console.WriteLine(BuscarEnRotado(new[]{4,5,6,7,0,1,2}, 0)); // 4
    }
}
