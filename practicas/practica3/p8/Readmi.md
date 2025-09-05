# Ejercicio 8 - Invertir un arreglo en C#

## 📌 Descripción
Este programa en C# permite **invertir los elementos de un arreglo**.  
Se crea un arreglo original y se genera un nuevo arreglo con los elementos en orden inverso, mostrando el resultado en consola.

---

## 💻 Código

```csharp
using System;

class Ejercicio8
{
    static void Main()
    {
        int[] arregloOriginal = { 1, 2, 3, 4, 5 };
        int[] arregloInvertido = new int[arregloOriginal.Length];

        for (int i = 0; i < arregloOriginal.Length; i++)
        {
            arregloInvertido[i] = arregloOriginal[arregloOriginal.Length - 1 - i];
        }

        Console.WriteLine("Arreglo invertido:");
        foreach (int n in arregloInvertido)
            Console.Write(n + " ");
    }
}


📖 Explicación

Se define un arreglo arregloOriginal con los valores {1, 2, 3, 4, 5}.
Se crea un arreglo arregloInvertido del mismo tamaño para almacenar los elementos en orden inverso.

El bucle for recorre cada posición del arreglo original y asigna los valores al arreglo invertido empezando desde el final.
Luego, se utiliza un bucle foreach para mostrar todos los elementos del arreglo invertido en consola, separados por espacios.

▶️ Ejemplo de salida

Arreglo invertido:
5 4 3 2 1