using System;

namespace NumeroFaltante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los números del arreglo separados por comas (del 1 al n, con un número faltante): ");
            string[] entrada = Console.ReadLine().Split(',');
            int[] arr = Array.ConvertAll(entrada, int.Parse);

            int n = arr.Length + 1; // porque falta un número
            int sumaEsperada = n * (n + 1) / 2;
            int sumaActual = 0;

            foreach (int num in arr)
            {
                sumaActual += num;
            }

            int faltante = sumaEsperada - sumaActual;

            Console.WriteLine("El número faltante es: " + faltante);
        }
    }
}
