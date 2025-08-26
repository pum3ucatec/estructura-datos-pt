/* 1. Rotación de Arreglo
Escribe un programa que reciba un arreglo de enteros y un número k, y rote los elementos del arreglo hacia la derecha k posiciones.
Ejemplo: [1, 2, 3, 4, 5] con k=2 → [4, 5, 1, 2, 3]. */

using System;
using System.Linq;

class Ejercicio1
{
    static void Main() {
        Console.WriteLine("Ingrese los números separados por espacio:");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.Write("Ingrese el valor de k (rotaciones): ");
        int k = int.Parse(Console.ReadLine());

        int n = arr.Length;
        k = k % n;
        int[] rotado = arr.Skip(n - k).Concat(arr.Take(n - k)).ToArray();

        Console.WriteLine("Arreglo rotado: " + string.Join(" ", rotado));
    }
}
