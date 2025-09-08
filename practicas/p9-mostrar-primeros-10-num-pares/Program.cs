using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;
            int contador = 0;

            while (contador < 10)
            {
                Console.WriteLine(numero);
                numero += 2;
                contador++;
            }
        }
    }
}

