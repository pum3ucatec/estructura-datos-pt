# 🔢 Sumar del 1 al N usando `while` en C#

## 📌 Descripción
Este programa solicita al usuario un número entero positivo `N` y calcula la suma de todos los números desde 1 hasta `N` utilizando un bucle `while`. Es ideal para practicar acumuladores, bucles y entrada de datos en C#.

## 🧠 Conceptos clave
- Bucle `while` con condición ascendente.
- Acumulación de valores en una variable (`suma`).
- Entrada de datos con `Console.ReadLine()` y conversión con `int.Parse`.

## 📋 Código fuente

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número N:");
        int N = int.Parse(Console.ReadLine()!); 

        int suma = 0;
        int i = 1;

        while (i <= N)
        {
            suma += i; 
            i++;       
        }

        Console.WriteLine($"La suma de los números del 1 al {N} es: {suma}");
    }
}
