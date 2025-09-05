# Documentación del Programa Contador de Ocurrencias en PascalCase

Este programa en C# permite al usuario ingresar un número y contar cuántas veces aparece dentro de un arreglo predefinido.  
El código ha sido convertido al estilo **PascalCase** para las variables, lo que significa que cada nombre comienza con mayúscula.

## Explicación del Código

1. **Declaración del Arreglo:** Se crea un arreglo llamado `Numeros` con valores predefinidos `{ 2, 5, 2, 8, 2, 9 }`.  
2. **Número a Buscar:** El usuario ingresa el número que desea contar en el arreglo.  
3. **Inicialización del Contador:** Se define la variable `Contador` para llevar la cuenta de las apariciones del número buscado.  
4. **Recorrido del Arreglo:** Se utiliza un ciclo `for` para recorrer el arreglo y comparar cada valor con el número buscado.  
   - Si se encuentra coincidencia, el contador se incrementa en uno.  
5. **Salida de Resultados:** Finalmente, se muestra el arreglo completo, el número buscado y la cantidad de veces que aparece.  

## Código en PascalCase

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] Numeros = { 2, 5, 2, 8, 2, 9 };

        Console.Write("Ingresa el número que deseas contar: ");
        int Buscado = Convert.ToInt32(Console.ReadLine());

        int Contador = 0;

        for (int i = 0; i < Numeros.Length; i++)
        {
            if (Numeros[i] == Buscado)
            {
                Contador++;
            }
        }

        Console.WriteLine("\nArreglo: [" + string.Join(", ", Numeros) + "]");
        Console.WriteLine("Número buscado: " + Buscado);
        Console.WriteLine("El número aparece " + Contador + " veces.");
    }
}
