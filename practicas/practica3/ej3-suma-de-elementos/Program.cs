using System;

    class Program
    {
        static void Main(String[] args)
        {
            int[] numeros = { 5, 10, 15, 20 };
            int resultado = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                resultado += numeros[i];
            }
            Console.WriteLine($"La suma es: {resultado}");
            Console.WriteLine($"El array es: {string.Join(",",numeros)}");
        }
    }

