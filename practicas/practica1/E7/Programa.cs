using System;

class SumaCinco
{
    static void Main(string[] args)
    {
        int total = PedirYNumeros(5);
        Console.WriteLine("La suma total es: " + total);
    }

    static int PedirYNumeros(int cantidad)
    {
        int suma = 0;
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            suma += int.Parse(Console.ReadLine());
        }
        return suma;
    }
}
