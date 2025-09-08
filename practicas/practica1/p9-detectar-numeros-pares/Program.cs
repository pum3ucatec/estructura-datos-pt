// Mostrar en pantalla los primeros 10 números pares usando while.

using System;

    class Ejercicio9
    {
        static void Main()
        {
            int pares = 0;
            int num = 2;
            while (pares < 10)
            {
                Console.WriteLine(num);
                num += 2;
                pares++;
            }
        }
    }

