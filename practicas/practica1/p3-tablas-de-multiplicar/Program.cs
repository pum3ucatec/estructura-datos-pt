// Tablas de multiplicar
// Solicitar un número al usuario y mostrar su tabla de multiplicar del 1 al 10 usando for.
// Camilaa
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número para mostrar su tabla de multiplicar: ");
        int numero = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
