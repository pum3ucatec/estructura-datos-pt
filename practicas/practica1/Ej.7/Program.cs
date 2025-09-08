using System;

namespace Suma_de_7_Valores
{
    class Program
    {

        static void Main()
        {

            int suma = 0;
            for (int i = 1; i <= 7; i++)
            {
                Console.Write($"Ingresa el valor {i}: ");
                int valor = int.Parse(Console.ReadLine());
                suma += valor;

            }
            Console.WriteLine($"la suma de los 7 valores es {suma}");
        }
    }


}