# Ejercicio 7 – Contar ocurrencias de un número en un arreglo

Este programa en C# permite al usuario **contar cuántas veces aparece un número** dentro de un arreglo.

---

## Código fuente

```
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 2, 5, 2, 8, 2, 9 };
        Console.Write("Ingrese un número: ");
        int buscado = int.Parse(Console.ReadLine());
        int contador = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscado) contador++;
        }

        Console.WriteLine($"El número aparece {contador} veces");
    }
}
```
## Explicación 

Se define un arreglo numeros con algunos valores.

Se pide al usuario el número a buscar (buscado).

Se inicializa contador = 0.

Se recorre el arreglo con un bucle for:

Si el elemento coincide con buscado, se incrementa contador.

Al finalizar, se imprime cuántas veces apareció el número.