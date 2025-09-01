using System;

static int EliminarDuplicados(int[] arr)
{
    if (arr.Length == 0) return 0;

    int j = 0;

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] != arr[j])
        {
            j++;
            arr[j] = arr[i];
        }
    }

    return j + 1;
}

Console.WriteLine("Ejercicio 3! Eliminar duplicados en arreglo ordenado");

int[] arreglo = { 1, 1, 2, 2, 3, 4, 4 };

int nuevaLongitud = EliminarDuplicados(arreglo);

Console.Write("Arreglo sin duplicados: ");
for (int i = 0; i < nuevaLongitud; i++)
{
    Console.Write(arreglo[i] + " ");
}
Console.WriteLine();

