using System;

class BuscarEnRotado
{
    static void Main(string[] args)
    {
        int[] arreglo = { 4, 5, 6, 7, 0, 1, 2 };
        int objetivo = 0;

        int indice = BuscarElemento(arreglo, objetivo);

        Console.WriteLine("Arreglo: ");
        ImprimirArreglo(arreglo);

        if (indice != -1)
            Console.WriteLine($"\nEl número {objetivo} se encontró en la posición: {indice}");
        else
            Console.WriteLine($"\nEl número {objetivo} NO está en el arreglo.");
    }

    static int BuscarElemento(int[] arr, int objetivo)
    {
        int izquierda = 0, derecha = arr.Length - 1;

        while (izquierda <= derecha)
        {
            int medio = (izquierda + derecha) / 2;

            if (arr[medio] == objetivo)
                return medio;

            // Parte izquierda ordenada
            if (arr[izquierda] <= arr[medio])
            {
                if (objetivo >= arr[izquierda] && objetivo < arr[medio])
                    derecha = medio - 1;
                else
                    izquierda = medio + 1;
            }
            // Parte derecha ordenada
            else
            {
                if (objetivo > arr[medio] && objetivo <= arr[derecha])
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }
        }

        return -1; // no encontrado
    }

    static void ImprimirArreglo(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
