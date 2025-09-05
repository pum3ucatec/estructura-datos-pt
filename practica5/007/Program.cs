using System;

class Program
{
    static int[] ProductoExceptoIndice(int[] a)
    {
        int n = a.Length;
        var res = new int[n];
        int pref = 1;
        for (int i = 0; i < n; i++) { res[i] = pref; pref *= a[i]; }
        int suf = 1;
        for (int i = n - 1; i >= 0; i--) { res[i] *= suf; suf *= a[i]; }
        return res;
    }

    static void Main()
    {
        Console.WriteLine(string.Join(",", ProductoExceptoIndice(new[]{1,2,3,4}))); // 24,12,8,6
    }
}
