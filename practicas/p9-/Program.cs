// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int contador = 1;  
        int numero = 2;    

        while (contador <= 10)
        {
            Console.WriteLine(numero);
            numero += 2;   
            contador++;
        }
    }
}

