using System;
namespace Invertirarreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 8, 3, 5, 1, 9 };
            Console.WriteLine("Arreglo desordenado: [" + string.Join(", ", numeros) + "]");

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - 1 - i; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Arreglo ordenado: [" + string.Join(", ", numeros) + "]");
        }
    }
}