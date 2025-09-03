# 📌 Suma Recursiva de un Arreglo en C#

Este programa en C# muestra cómo **sumar todos los elementos de un arreglo usando recursión**.

---

## 📜 Código

```csharp
using System;

class Program
{
    // Método recursivo para sumar un arreglo
    public static int SumaArregloRecursiva(int[] arr, int indice = 0)
    {
        // Caso base: si llegamos al final del arreglo
        if (indice >= arr.Length)
        {
            return 0;
        }

        // Paso recursivo: sumar el elemento actual + la suma del resto
        return arr[indice] + SumaArregloRecursiva(arr, indice + 1);
    }

    static void Main(string[] args)
    {
        // Ejemplo de arreglo
        int[] numeros = { 5, 10, 15, 20 };

        // Llamamos al método recursivo
        int resultado = SumaArregloRecursiva(numeros);

        // Mostramos el resultado
        Console.WriteLine("La suma del arreglo es: " + resultado);
    }
}
