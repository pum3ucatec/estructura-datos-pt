using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            double numero = 0; // Número inicial en radianes para funciones trigonométricas

            while (contador < 10)
            {
                Console.WriteLine($"Número {contador + 1}: {numero}");

                // Tangente
                double tangente = Math.Tan(numero);

                // Cotangente (1 / tan)
                double cotangente = (Math.Tan(numero) != 0) ? 1 / Math.Tan(numero) : double.NaN;

                // Secante (1 / cos)
                double secante = (Math.Cos(numero) != 0) ? 1 / Math.Cos(numero) : double.NaN;

                // Cosecante (1 / sin)
                double cosecante = (Math.Sin(numero) != 0) ? 1 / Math.Sin(numero) : double.NaN;

                // Factorial (solo para enteros >=0)
                long factorial = (numero >= 0 && numero == Math.Floor(numero)) ? Factorial((int)numero) : -1;

                Console.WriteLine($"Tangente: {tangente}");
                Console.WriteLine($"Cotangente: {cotangente}");
                Console.WriteLine($"Secante: {secante}");
                Console.WriteLine($"Cosecante: {cosecante}");
                if (factorial != -1)
                    Console.WriteLine($"Factorial: {factorial}");
                else
                    Console.WriteLine("Factorial: No definido");

                Console.WriteLine("-----------------------------");

                numero += 1; // Incrementa el número para la siguiente iteración
                contador++;
            }
        }

        static long Factorial(int n)
        {
            long fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= i;
            return fact;
        }
    }
}
