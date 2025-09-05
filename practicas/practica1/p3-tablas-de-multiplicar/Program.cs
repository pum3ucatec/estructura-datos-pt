// Solicitar un número al usuario y mostrar su tabla de multiplicar del 1 al 10 usando for.

using System;

    class Ejercicio3
    {
        static void Main()
        {
            int numero;

            Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTabla de multiplicar del {numero}:\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }

