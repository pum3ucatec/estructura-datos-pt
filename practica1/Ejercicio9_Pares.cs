using System;

class Ejercicio9_Pares
{
    static void Main()
    {
        int i = 1, contador = 0;
        while (contador < 10)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                contador++;
            }
            i++;
        }
    }
}