//Crea un programa que lea 8 números en un arreglo y muestre el mayor y el menor.  
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[8];

        Console.WriteLine("Ingresa 8 números enteros:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número #{i + 1}: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int valor))
            {
                numeros[i] = valor;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Intenta de nuevo.");
                i--; 
            }
        }

        int mayor = numeros[0];
        int menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
                mayor = numeros[i];

            if (numeros[i] < menor)
                menor = numeros[i];
        }

        Console.WriteLine($"\nEl número mayor es: {mayor}");
        Console.WriteLine($"El número menor es: {menor}");
    }
}
