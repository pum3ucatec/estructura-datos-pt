using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        int numero = 2;

        Console.WriteLine("Primeros 10 números pares:");

        while (contador < 10)
        {
            Console.WriteLine(numero);
            numero += 2;
            contador++;
        }
    }
}
