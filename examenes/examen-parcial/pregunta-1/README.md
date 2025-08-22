# Programa en C#: Encontrar el número faltante en un arreglo

Este programa en **C#** encuentra el número que falta en una secuencia de números consecutivos del `1` al `n`.  
Se utiliza la fórmula de la suma de los primeros `n` números naturales para determinar el valor faltante.

---

## Código en C#

```csharp
using System;

class Program
{
    // Método para encontrar el número faltante en un arreglo
    static int EncontrarNumeroFaltante(int[] arreglo, int n)
    {
        // ✅ Suma total de los números del 1 al n usando la fórmula:
        // suma = n * (n + 1) / 2
        int sumaTotal = n * (n + 1) / 2;

        // ✅ Suma de los elementos del arreglo recibido
        int sumaArreglo = 0;
        foreach (int num in arreglo)
        {
            sumaArreglo += num;
        }

        // ✅ El número faltante se obtiene restando la suma del arreglo
        // a la suma total esperada
        return sumaTotal - sumaArreglo;
    }

    static void Main()
    {
        // 🔹 Arreglo de ejemplo (falta el número 3)
        int[] arreglo = { 1, 2, 4, 5, 6 };

        // 🔹 Valor máximo de la secuencia (en este caso 6)
        int n = 6;

        // 🔹 Llamada al método para obtener el número faltante
        int faltante = EncontrarNumeroFaltante(arreglo, n);

        // 🔹 Mostrar el resultado en consola
        Console.WriteLine($"El número que falta es: {faltante}");
    }
}
