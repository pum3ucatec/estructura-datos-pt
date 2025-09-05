## **9. Ordenamiento por el Método de la Burbuja (Bubble Sort)**
### **Descripción**

Este programa implementa el clásico algoritmo de ordenamiento "Bubble Sort" para ordenar un arreglo de enteros de mayor a menor. El algoritmo compara repetidamente pares de elementos adyacentes y los intercambia si están en el orden incorrecto. El proceso se repite en pasadas sucesivas hasta que el arreglo esté completamente ordenado.
### **Código**

```
// Se incluye la biblioteca 'System'.
using System;
class Program
{
    static void Main(string[] args)
    {
        // Arreglo de ejemplo a ordenar.
        int[] arreglo = { 5, 2, 9, 1, 5, 6 };
        Console.WriteLine("Arreglo original: " + string.Join(", ", arreglo));
        
        // Se llama al método que contiene el algoritmo de ordenamiento.
        BubbleSort(arreglo);
        
        Console.WriteLine("Arreglo ordenado de mayor a menor: " + string.Join(", ", arreglo));
    }

    // Método que implementa el algoritmo de la burbuja.
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        // Bucle exterior para controlar el número de pasadas.
        for (int i = 0; i < n - 1; i++)
        {
            // Bucle interior para las comparaciones e intercambios.
            for (int j = 0; j < n - i - 1; j++)
            {
                // Se compara el elemento actual con el siguiente. La condición 'arr[j] < arr[j + 1]'
                // ordena de mayor a menor. Si se cambia a '>' se ordenaría de menor a mayor.
                if (arr[j] < arr[j + 1])
                {
                    // Intercambio de los elementos si están en el orden incorrecto.
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
```