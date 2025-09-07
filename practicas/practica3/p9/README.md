# Ejercicio 9 - Ordenar un arreglo usando el método burbuja en C#

## 📌 Descripción
Este programa en C# permite **ordenar un arreglo de números enteros** de forma ascendente utilizando el **método de la burbuja (Bubble Sort)**.  
El objetivo es reorganizar los elementos del arreglo y mostrarlos en orden creciente en la consola.

---

## 💻 Código

```csharp
using System;

class Ejercicio9
{
    static void Main()
    {
        int[] arreglo = { 8, 3, 5, 1, 9 };

        for (int i = 0; i < arreglo.Length - 1; i++)
        {
            for (int j = 0; j < arreglo.Length - 1 - i; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Arreglo ordenado:");
        foreach (int n in arreglo)
            Console.Write(n + " ");
    }
}


📖 Explicación

Se define un arreglo arreglo con los valores {8, 3, 5, 1, 9}.

El método burbuja compara elementos consecutivos y los intercambia si están en el orden incorrecto:

El primer bucle for controla las pasadas necesarias.

El segundo bucle for compara y realiza los intercambios (swap) cuando el elemento actual es mayor que el siguiente.

Al finalizar, todos los elementos quedan ordenados de menor a mayor.
Se utiliza un foreach para mostrar los elementos del arreglo ordenado en consola, separados por espacios.

▶️ Ejemplo de salida

Arreglo ordenado:
1 3 5 8 9