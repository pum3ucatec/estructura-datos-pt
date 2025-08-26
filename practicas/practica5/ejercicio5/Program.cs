using System;

class Ejercicio5
{
    static void Main()
    {
        int[] a = {1, 2, 2, 1};
        int[] b = {2, 2};
        Console.WriteLine("Elementos comunes:");

        bool[] usado = new bool[b.Length];
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                if (a[i] == b[j] && !usado[j])
                {
                    Console.Write(a[i] + " ");
                    usado[j] = true;
                    break;
                }
            }
        }
    }
}
