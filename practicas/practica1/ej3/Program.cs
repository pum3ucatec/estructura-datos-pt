using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tabla de multiplicar del {n}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}
