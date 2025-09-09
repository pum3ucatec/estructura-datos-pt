using System;

class Program
{
    static int EliminarDuplicadosOrdenado(int[] a)
    {
        if (a.Length == 0) return 0;
        int w = 1;
        for (int r = 1; r < a.Length; r++)
            if (a[r] != a[w - 1]) a[w++] = a[r];
        return w;
    }

    static void Main()
    {
        int[] a = {1,1,2,2,3,4,4};
        int len = EliminarDuplicadosOrdenado(a);
        Console.WriteLine(string.Join(",", new ArraySegment<int>(a, 0, len))); // 1,2,3,4
    }
}
