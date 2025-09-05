// Un arreglo de 5 enteros. Pedir al ususario un numero y ver si esta en el arreglo.
using System;
class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5];
        Console.WriteLine("Ingrese 5 numeros enteros:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Ingrese un numero para buscar en el arreglo: ");
        int numeroBuscado = int.Parse(Console.ReadLine());

        bool encontrado = false;
        foreach (int numero in numeros)
        {
            if (numero == numeroBuscado)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            Console.WriteLine($"El numero {numeroBuscado} se encuentra en el arreglo.");
        }
        else
        {
            Console.WriteLine($"El numero {numeroBuscado} no se encuentra en el arreglo.");
        }
    }
}