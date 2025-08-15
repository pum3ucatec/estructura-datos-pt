// Suma de 5 números ingresados por el usuario Pedir al usuario 5 números (uno por uno) y sumarlos usando for.

using System;

namespace Sumade_5_numeros_ingresados_por_el_usuario
{
    class Ejercicio7
    {
        static void Main()
        {
            int suma = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                suma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La suma total es: {suma}");
        }
    }
}
