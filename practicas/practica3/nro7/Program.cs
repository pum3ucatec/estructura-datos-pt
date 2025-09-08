using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de números en el arreglo: ");
        int n = int.Parse(Console.ReadLine());

        int[] arreglo = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Arreglo: [" + string.Join(", ", arreglo) + "]");

        Console.Write("Ingrese el número a buscar: ");
        int buscado = int.Parse(Console.ReadLine());

        int contador = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == buscado)
            {
                contador++;
            }
        }

        Console.WriteLine($"El número {buscado} aparece {contador} veces");
    }
}
