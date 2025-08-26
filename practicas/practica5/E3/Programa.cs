using System;

class EliminarDuplicados
{
    static void Main(string[] args)
    {
        // Ejemplo de arreglo ordenado con duplicados
        int[] arreglo = { 1, 1, 2, 2, 3, 4, 4 };

        Console.WriteLine("Arreglo original:");
        foreach (int num in arreglo)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Llamamos al método para eliminar duplicados
        int[] sinDuplicados = QuitarDuplicados(arreglo);

        Console.WriteLine("\nArreglo sin duplicados:");
        foreach (int num in sinDuplicados)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // Método que elimina duplicados en un arreglo ordenado
    static int[] QuitarDuplicados(int[] arr)
    {
        if (arr.Length == 0) return arr;

        int n = arr.Length;
        int j = 0; // índice para el nuevo arreglo
        int[] temp = new int[n];

        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] != arr[i + 1])
            {
                temp[j++] = arr[i];
            }
        }

        // Agregar el último elemento
        temp[j++] = arr[n - 1];

        // Crear un arreglo del tamaño exacto sin duplicados
        int[] resultado = new int[j];
        for (int k = 0; k < j; k++)
        {
            resultado[k] = temp[k];
        }

        return resultado;
    }
}
