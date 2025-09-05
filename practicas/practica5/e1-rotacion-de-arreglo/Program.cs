// Escribe un programa que reciba un arreglo de enteros y un número `k`, 
// y rote los elementos del arreglo hacia la derecha `k` posiciones.  
// Ejemplo: `[1, 2, 3, 4, 5]` con `k=2` → `[4, 5, 1, 2, 3]`.

using System;

class Ejercicio1
{
    static void Main()
    {
        
        Console.Write("Ingrese el tamaño del arreglo: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Ingrese los elementos del arreglo:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Ingrese el número de posiciones a rotar (k): ");
        int k = int.Parse(Console.ReadLine());
        k = k % n;

        int[] rotated = new int[n];
        for (int i = 0; i < n; i++)
        {
            rotated[(i + k) % n] = arr[i];
        }

        Console.WriteLine("\nArreglo rotado:");
        foreach (int num in rotated)
        {
            Console.Write(num + " ");
        }
    }
}

    
