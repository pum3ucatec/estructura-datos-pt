using System;
using System.Collections.Generic;

class Program
{
    static int[] Interseccion(int[] a, int[] b)
    {
        var map = new Dictionary<int,int>();
        foreach (var v in a) { if (!map.ContainsKey(v)) map[v]=0; map[v]++; }
        var res = new List<int>();
        foreach (var v in b)
            if (map.TryGetValue(v, out int cnt) && cnt>0) { res.Add(v); map[v]=cnt-1; }
        return res.ToArray();
    }

    static void Main()
    {
        var r = Interseccion(new[]{1,2,2,1}, new[]{2,2});
        Console.WriteLine(string.Join(",", r)); // 2,2
    }
}
