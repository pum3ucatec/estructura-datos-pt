using System;

Console.WriteLine("Ejercicio 5! Intersección de dos arreglos");


int[] arr1 = { 3, 5, 2, 5, 7 };
int[] arr2 = { 5, 2, 5, 8 };


int maxLen = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;
int[] interseccion = new int[maxLen];
int k = 0;


for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {

            interseccion[k++] = arr1[i];


            arr2[j] = int.MinValue;
            break; // salimos del bucle interno
        }
    }
}


Console.WriteLine("Arreglo 1: " + string.Join(", ", arr1));
Console.WriteLine("Arreglo 2: " + string.Join(", ", arr2));
Console.Write("Intersección: ");
for (int i = 0; i < k; i++)
{
    Console.Write(interseccion[i] + " ");
}
Console.WriteLine();
