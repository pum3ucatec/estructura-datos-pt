//Mostrar en pantalla los primeros 10 números pares usando while.
using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        int numero = 2;

        Console.WriteLine("Los primeros 10 números pares son:");

        while (contador < 10)
        {
            Console.WriteLine(numero);
            numero += 2;     
            contador++;     
        }
    }
}
