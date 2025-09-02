using System;

class Programa
{
    static void Main()
    {
        int suma = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            suma += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"La suma de los 5 números es: {suma}");
    }
}
