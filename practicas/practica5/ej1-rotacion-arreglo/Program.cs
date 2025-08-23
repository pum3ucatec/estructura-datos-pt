// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Ejercicio 1! Rotación de Arreglo");

static void RotarArreglo(int[] arr, int k)
{
    int n = arr.Length;
    if (n == 0) return;

    k = k % n;

    int[] resultado = new int[n];

    for (int i = 0; i < n; i++)
    {
        int nuevaPos = (i + k) % n;
        resultado[nuevaPos] = arr[i];
    }

    for (int i = 0; i < n; i++)
    {
        arr[i] = resultado[i];
    }
}


int[] arreglo = { 1, 2, 3, 4, 5 };
int k = 2;

Console.WriteLine("Arreglo original: " + string.Join(", ", arreglo));

RotarArreglo(arreglo, k);

Console.WriteLine($"Arreglo rotado {k} posiciones a la derecha: " + string.Join(", ", arreglo));
