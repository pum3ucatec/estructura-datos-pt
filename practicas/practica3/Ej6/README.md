# Documentación del Programa en PascalCase

Este programa en C# solicita al usuario ingresar 8 números enteros, y posteriormente determina cuál es el número mayor y cuál es el menor.  
El código ha sido convertido al estilo **PascalCase** para las variables, lo que significa que cada nombre de variable comienza con mayúscula.

## Explicación del Código

1. **Declaración del Arreglo:** Se crea un arreglo llamado `Numeros` con espacio para 8 enteros.  
2. **Ingreso de Datos:** Se usa un ciclo `for` para solicitar al usuario cada número y almacenarlo en el arreglo.  
3. **Inicialización de Variables:** Se definen dos variables `Mayor` y `Menor`, inicializadas con el primer valor del arreglo.  
4. **Búsqueda de Mayor y Menor:** Se recorre el arreglo desde el segundo elemento y se comparan los valores para actualizar `Mayor` o `Menor` según corresponda.  
5. **Salida de Resultados:** Finalmente, se muestran en pantalla los valores mayor y menor ingresados.  

## Código en PascalCase

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] Numeros = new int[8];

        for (int i = 0; i < Numeros.Length; i++)
        {
            Console.Write("Ingresa el número #" + (i + 1) + ": ");
            Numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        int Mayor = Numeros[0];
        int Menor = Numeros[0];

        for (int i = 1; i < Numeros.Length; i++)
        {
            if (Numeros[i] > Mayor)
                Mayor = Numeros[i];
            if (Numeros[i] < Menor)
                Menor = Numeros[i];
        }

        Console.WriteLine("\nEl número mayor es: " + Mayor);
        Console.WriteLine("El número menor es: " + Menor);
    }
}
```