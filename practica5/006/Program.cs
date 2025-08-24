using System;

class Program
{
    static int[,] Transpuesta(int[,] m)
    {
        int r = m.GetLength(0), c = m.GetLength(1);
        var t = new int[c, r];
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                t[j, i] = m[i, j];
        return t;
    }

    static void Main()
    {
        var m = new int[,] { {1,2,3}, {4,5,6} };
        var t = Transpuesta(m);
        for (int i = 0; i < t.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < t.GetLength(1); j++)
                Console.Write(t[i,j] + (j+1==t.GetLength(1) ? "" : ","));
            Console.WriteLine("]");
        }
        // [1,4]
        // [2,5]
        // [3,6]
    }
}
