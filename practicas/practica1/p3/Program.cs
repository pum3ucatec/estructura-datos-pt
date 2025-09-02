using System;

class Program
{
    static void Main()
    {
        Console.Write("¿De qué número quieres la tabla?: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}
