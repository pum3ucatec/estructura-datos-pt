// Pedir al usuario un número N y sumar todos los números del 1 hasta N usando while

using System;

    class Ejercicio2
    {
        static void Main()
        {
            int N, suma = 0, contador = 1;

            Console.Write("Ingrese un número N: ");
            N = int.Parse(Console.ReadLine());

            while (contador <= N)
            {
                suma += contador;
                contador++;
            }

            Console.WriteLine($"La suma de los números del 1 al {N} es: {suma}");
        }
    }

