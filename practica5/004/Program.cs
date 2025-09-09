using System;

class Program
{
    static int NumeroFaltante(int[] a, int n)
    {
        int x = 0;
        for (int i = 1; i <= n; i++) x ^= i;
        foreach (var v in a) x ^= v;
        return x;
    }

    static void Main()
    {
        int[] a = {1,2,4,5,6};
        Console.WriteLine(NumeroFaltante(a, 6)); // 3
    }
}
