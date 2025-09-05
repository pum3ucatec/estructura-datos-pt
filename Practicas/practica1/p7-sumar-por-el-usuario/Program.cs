using System;

class Ejercicio7
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingrese número {i}: ");
            int numero = int.Parse(Console.ReadLine());
            suma += numero;
        }

        Console.WriteLine($"La suma de los 5 números es: {suma}");
    }
}
