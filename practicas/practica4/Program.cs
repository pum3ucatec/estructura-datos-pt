using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Ingresa un número decimal:");
        int numero = int.Parse(Console.ReadLine());

        Stack<int> pila = new Stack<int>();

        int n = numero;

        // Divisiones sucesivas entre 2
        while (n > 0)
        {
            int residuo = n % 2; // obtenemos el bit
            pila.Push(residuo);  // se apila
            n = n / 2;           // se divide entre 2
        }

        Console.WriteLine($"Número decimal: {numero}");
        Console.Write("Número binario: ");

        // Desapilar para formar el binario
        while (pila.Count > 0)
        {
            Console.Write(pila.Pop());
        }

        Console.WriteLine();
    }
}
