# Documentación del Programa Bubble Sort en PascalCase

Este programa en C# ordena los elementos de un arreglo de enteros utilizando el método **Bubble Sort**.  
El código ha sido convertido al estilo **PascalCase** para las variables, lo que significa que cada nombre comienza con mayúscula.

## Explicación del Código

1. **Declaración del Arreglo:** Se crea un arreglo llamado `Numeros` con valores iniciales `{ 8, 3, 5, 1, 9 }`.  
2. **Salida del Arreglo Desordenado:** Se muestra el arreglo original en consola.  
3. **Algoritmo Bubble Sort:**  
   - Se usan dos ciclos `for` anidados para recorrer el arreglo.  
   - Se compara cada par de elementos adyacentes.  
   - Si un elemento es mayor que el siguiente, se intercambian usando la variable temporal `Temp`.  
   - Este proceso se repite hasta que todos los elementos estén ordenados.  
4. **Salida del Arreglo Ordenado:** Finalmente, se muestra el arreglo ordenado en consola.

## Código en PascalCase

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] Numeros = { 8, 3, 5, 1, 9 };

        Console.WriteLine("Arreglo desordenado: [" + string.Join(", ", Numeros) + "]");

        for (int i = 0; i < Numeros.Length - 1; i++)
        {
            for (int j = 0; j < Numeros.Length - 1 - i; j++)
            {
                if (Numeros[j] > Numeros[j + 1])
                {
                    int Temp = Numeros[j];
                    Numeros[j] = Numeros[j + 1];
                    Numeros[j + 1] = Temp;
                }
            }
        }

        Console.WriteLine("Arreglo ordenado: [" + string.Join(", ", Numeros) + "]");
    }
}
