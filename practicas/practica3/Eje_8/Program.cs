// Dado un arreglo, crear unsegundo arreglo que su orden sea inverso al del primero.
using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arreglo1 = { 1, 2, 3, 4, 5 };
        int[] arreglo2 = new int[arreglo1.Length];

        for (int i = 0; i < arreglo1.Length; i++)
        {
            arreglo2[i] = arreglo1[arreglo1.Length - 1 - i];
        }

        Console.WriteLine("Arreglo original: " + string.Join(", ", arreglo1));
        Console.WriteLine("Arreglo inverso: " + string.Join(", ", arreglo2));
    }
}
