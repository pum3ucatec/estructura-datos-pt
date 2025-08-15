// Usar un bucle for para determinar si un número ingresado por el usuario es primo o no.

using System;

namespace Dtectar_nuemro_primo
{
    class Ejercicio8
    {
        static void Main()
        {
            Console.Write("Ingrese un número para verificar si es primo: ");
            int numero = int.Parse(Console.ReadLine());
            bool esPrimo = true;

            if (numero <= 1)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }
            Console.WriteLine(esPrimo ? "Es primo" : "No es primo");

        }
    }
}
