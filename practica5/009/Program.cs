using System;
using System.Collections.Generic;

class Program
{
    static List<int> Espiral(int[,] m)
    {
        int top = 0, left = 0, bottom = m.GetLength(0) - 1, right = m.GetLength(1) - 1;
        var res = new List<int>();
        while (top <= bottom && left <= right)
        {
            for (int j = left; j <= right; j++) res.Add(m[top, j]);
            top++;
            for (int i = top; i <= bottom; i++) res.Add(m[i, right]);
            right--;
            if (top <= bottom) { for (int j = right; j >= left; j--) res.Add(m[bottom, j]); bottom--; }
            if (left <= right) { for (int i = bottom; i >= top; i--) res.Add(m[i, left]); left++; }
        }
        return res;
    }

    static void Main()
    {
        var m = new int[,] { {1,2,3}, {4,5,6}, {7,8,9} };
        Console.WriteLine(string.Join(",", Espiral(m))); // 1,2,3,6,9,8,7,4,5
    }
}
