using System;

namespace PromedioDeElementos
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] numeros = { 80, 70, 90, 100, 60 };
            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }
            double promedio = (double)suma / numeros.Length;
            Console.WriteLine($"El promedio es: {promedio}");
            Console.WriteLine($"El array es: {string.Join(",", numeros)}");
        }
    }
}