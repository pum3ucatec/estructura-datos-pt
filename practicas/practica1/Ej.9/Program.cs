using System;

class Program
{
    static void Main()
    {
        Console.Write($"Ingresa el valor: ");
        int valor = int.Parse(Console.ReadLine());
        Console.WriteLine("Primeros 10 números pares:");

        for (int a = valor; a < valor + 10; a++)
        {
            int par = a * 2; // 2, 4, 6, ... 20
            Console.WriteLine(par + (a < 10 ? " " : "\n"));
        }
    }
}