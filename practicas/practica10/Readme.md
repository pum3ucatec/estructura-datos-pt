
# Búsqueda Recursiva Simple en C#

Este es un programa de consola fundamental en C# que muestra cómo implementar un algoritmo de búsqueda de elementos en un arreglo utilizando la **recursividad**. El código define un arreglo predeterminado y busca dos números diferentes para ilustrar tanto un caso de éxito como uno de fracaso.

## ¿Cómo Funciona la Búsqueda Recursiva?

La lógica reside en la función `BuscarElementoRecursivo`, que opera de la siguiente manera:

-   **Caso Base 1 (Final del Arreglo)**: Si el índice de búsqueda supera la longitud del arreglo, significa que el elemento no se encontró y la función devuelve `false`.
-   **Caso Base 2 (Elemento Encontrado)**: Si el valor en la posición actual del arreglo (`arr[indice]`) coincide con el número buscado, la función devuelve `true`.
-   **Paso Recursivo**: Si ninguna de las condiciones anteriores se cumple, la función se llama a sí misma, pero avanza al siguiente índice (`indice + 1`) para continuar la búsqueda.

##  Cómo Ejecutar el Código

1.  Guarda el código en un archivo llamado `Program.cs`.
2.  Abre una terminal (como PowerShell, CMD o Terminal) en la misma carpeta donde guardaste el archivo.
3.  Si no tienes un proyecto de .NET, créalo con `dotnet new console`. Asegúrate de que tu código esté en el archivo `Program.cs`.
4.  Ejecuta el programa con el siguiente comando:
    ```bash
    dotnet run
    ```

##  Salida Esperada

Al ejecutar el código, la salida en la consola será exactamente la siguiente:

```console
¿El número 7 está en el arreglo?
Respuesta: True

¿El número 5 está en el arreglo?
Respuesta: False
```

## Código Fuente Completo

```csharp
using System;

public class Program
{
    public static void Main()
    {
        int[] arreglo = {4, 2, 7, 1, 9};
        int numeroBuscado = 7;
        
        // Llamar al método recursivo
        bool resultado = BuscarElementoRecursivo(arreglo, numeroBuscado);
        
        // Mostrar el resultado
        Console.WriteLine("¿El número " + numeroBuscado + " está en el arreglo?");
        Console.WriteLine("Respuesta: " + resultado);
        
        // Probar con otro número que no existe
        Console.WriteLine("\n¿El número 5 está en el arreglo?");
        Console.WriteLine("Respuesta: " + BuscarElementoRecursivo(arreglo, 5));
    }
    
    /// <summary>
    /// Busca un elemento en un arreglo de forma recursiva.
    /// </summary>
    /// <param name="arr">El arreglo donde buscar.</param>
    /// <param name="valor">El valor a encontrar.</param>
    /// <param name="indice">El índice actual de la búsqueda (parámetro opcional).</param>
    /// <returns>True si el valor se encuentra, de lo contrario False.</returns>
    public static bool BuscarElementoRecursivo(int[] arr, int valor, int indice = 0)
    {
        // Caso Base 1: Si el índice está fuera de los límites, el elemento no está.
        if (indice >= arr.Length) return false;

        // Caso Base 2: Si encontramos el valor, devolvemos true.
        if (arr[indice] == valor) return true;
        
        // Paso Recursivo: Llamamos a la función con el siguiente índice.
        return BuscarElementoRecursivo(arr, valor, indice + 1);
    }
}
```