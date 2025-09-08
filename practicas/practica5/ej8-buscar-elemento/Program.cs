using System;

Console.WriteLine("Ejercicio 8! Buscar elemento en arreglo rotado");


int[] arr = { 10, 12, 15, 2, 5, 7, 8 };
int target = 5;

Console.WriteLine("Arreglo rotado: " + string.Join(", ", arr));
Console.WriteLine("Número a buscar: " + target);

int BuscarEnRotado(int[] arr, int target)
{
    int izq = 0, der = arr.Length - 1;

    while (izq <= der)
    {
        int mid = (izq + der) / 2;

        if (arr[mid] == target)
            return mid;


        if (arr[izq] <= arr[mid])
        {
            if (target >= arr[izq] && target < arr[mid])
                der = mid - 1;
            else
                izq = mid + 1;
        }

        else
        {
            if (target > arr[mid] && target <= arr[der])
                izq = mid + 1;
            else
                der = mid - 1;
        }
    }

    return -1;
}

int indice = BuscarEnRotado(arr, target);

if (indice != -1)
    Console.WriteLine($"Número encontrado en el índice: {indice}");
else
    Console.WriteLine("Número no encontrado");
