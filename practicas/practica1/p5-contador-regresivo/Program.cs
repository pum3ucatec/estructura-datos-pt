// Mostrar una cuenta regresiva del 10 al 1 usando while.

using System;

    class Ejercicio5
    {
        static void Main()
        {
            int contador = 10;
            while (contador >= 1)
            {
                Console.WriteLine(contador);
                contador--;
            }
        }
    }