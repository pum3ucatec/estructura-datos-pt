//Mostrar una cuenta regresiva del 10 al 1 usando while.

using System;

class Countdown
{
    static void Main()
    {
        int contador = 10;

        while (contador >= 1)
        {
            Console.WriteLine(contador);
            contador--;
        }

        Console.WriteLine("¡Despegue!");
    }
}
