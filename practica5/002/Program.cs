using System;

class Program
{
    static (int suma, int l, int r) Kadane(int[] a)
    {
        int maxGlobal = a[0], maxActual = a[0];
        int start = 0, bestL = 0, bestR = 0;
        for (int i = 1; i < a.Length; i++)
        {
            if (maxActual + a[i] < a[i]) { maxActual = a[i]; start = i; }
            else maxActual += a[i];
            if (maxActual > maxGlobal) { maxGlobal = maxActual; bestL = start; bestR = i; }
        }
        return (maxGlobal, bestL, bestR);
    }

    static void Main()
    {
        int[] a = {-2,1,-3,4,-1,2,1,-5,4};
        var (s, l, r) = Kadane(a);
        Console.WriteLine($"suma={s}, rango=[{l},{r}]"); // 6, [3,6]
    }
}
