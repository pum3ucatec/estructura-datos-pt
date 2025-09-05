using System;

class Program
{
    static void RotarDerecha(int[] a, int k)
    {
        if (a.Length == 0) return;
        k %= a.Length; if (k < 0) k += a.Length;
        Reverse(a, 0, a.Length - 1);
        Reverse(a, 0, k - 1);
        Reverse(a, k, a.Length - 1);
    }
    static void Reverse(int[] a, int i, int j)
    {
        while (i < j) { (a[i], a[j]) = (a[j], a[i]); i++; j--; }
    }

    static void Main()
    {
        int[] a = {1,2,3,4,5};
        RotarDerecha(a, 2);
        Console.WriteLine(string.Join(",", a)); // 4,5,1,2,3
    }
}
