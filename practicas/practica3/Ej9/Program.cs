
// Implementa un algoritmo sencillo (por ejemplo, Burbuja) para ordenar un arreglo de enteros de menor a mayor.

int[] numeros = { 5, 3, 8, 4, 2, 7, 1, 6 };

    Console.WriteLine("Arreglo original:");
    MostrarArreglo(numeros);

        // Algoritmo Burbuja
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    // Intercambio
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nArreglo ordenado (menor a mayor):");
        MostrarArreglo(numeros);
    

    // Método auxiliar para mostrar el arreglo
    static void MostrarArreglo(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }