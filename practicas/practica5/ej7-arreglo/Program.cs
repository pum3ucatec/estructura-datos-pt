using System;

Console.WriteLine("Ejercicio 7! Arreglo de productos excepto el índice");


int[] arr = { 2, 3, 4, 5 };

int n = arr.Length;
int[] resultado = new int[n];
int[] left = new int[n];
int[] right = new int[n];


left[0] = 1;
for (int i = 1; i < n; i++)
{
    left[i] = left[i - 1] * arr[i - 1];
}


right[n - 1] = 1;
for (int i = n - 2; i >= 0; i--)
{
    right[i] = right[i + 1] * arr[i + 1];
}


for (int i = 0; i < n; i++)
{
    resultado[i] = left[i] * right[i];
}


Console.WriteLine("Arreglo original: " + string.Join(", ", arr));
Console.WriteLine("Arreglo de productos excepto el índice: " + string.Join(", ", resultado));
