// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int contador = 1;  // Contará cuántos pares hemos mostrado
        int numero = 2;    // Primer número par

        while (contador <= 10)
        {
            Console.WriteLine(numero);
            numero += 2;   // Siguiente número par
            contador++;
        }
    }
}

