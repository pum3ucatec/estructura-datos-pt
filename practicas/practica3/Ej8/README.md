# Documentación del Programa Inversión de Arreglo en PascalCase

Este programa en C# invierte los elementos de un arreglo y muestra tanto el arreglo original como el invertido.  
El código ha sido convertido al estilo **PascalCase** para las variables, lo que significa que cada nombre comienza con mayúscula.

## Explicación del Código

1. **Declaración del Arreglo:** Se crea un arreglo llamado `Arreglo` con los valores `{ 1, 2, 3, 4, 5 }`.  
2. **Arreglo Invertido:** Se define un nuevo arreglo `Invertido` con la misma longitud que el original.  
3. **Inversión de Elementos:**  
   - Se recorre el arreglo original con un ciclo `for`.  
   - En cada iteración, se asigna el valor desde el final del arreglo original hacia el inicio del nuevo arreglo.  
4. **Salida de Resultados:**  
   - Se muestra en consola el arreglo original.  
   - Se muestra el arreglo invertido.  

## Código en PascalCase

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] Arreglo = { 1, 2, 3, 4, 5 };

        int[] Invertido = new int[Arreglo.Length];

        for (int i = 0; i < Arreglo.Length; i++)
        {
            Invertido[i] = Arreglo[Arreglo.Length - 1 - i];
        }

        Console.WriteLine("Arreglo original: [" + string.Join(", ", Arreglo) + "]");
        Console.WriteLine("Arreglo invertido: [" + string.Join(", ", Invertido) + "]");
    }
}
