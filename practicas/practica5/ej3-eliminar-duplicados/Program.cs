using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 11, 21, 21, 33, 44, 4, 55, 55 };
        int n = numeros.Length;

        if (n == 0) return;

        int j = 0;

        for (int i = 1; i < n; i++)
        {
            if (numeros[j] != numeros[i])
            {
                j++;
                numeros[j] = numeros[i];
            }
        }

        Console.Write("Arreglo sin numeros duplicados: ");
        for (int i = 0; i <= j; i++)
        {
            Console.Write(numeros[i] + " ");
        }
    }
}

