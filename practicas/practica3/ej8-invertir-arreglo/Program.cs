using System;
namespace Invertirarreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numerosInv = new int[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                numerosInv[i] = numeros[numeros.Length - 1 - i];
            }
            Console.WriteLine("Array original: [" + string.Join(", ", numeros) + "]");
            Console.WriteLine("Array invertido: [" + string.Join(", ", numerosInv) + "]");

        }

    }
}