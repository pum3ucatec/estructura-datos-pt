// Leer 5 elemetos y mostar el mayor y el menor
using System;
class Program
{
    static void Main()
    {
        int mayor = int.MinValue;
        int menor = int.MaxValue;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > mayor)
            {
                mayor = numero;
            }

            if (numero < menor)
            {
                menor = numero;
            }
        }

        Console.WriteLine($"El número mayor es: {mayor}");
        Console.WriteLine($"El número menor es: {menor}");
    }
}