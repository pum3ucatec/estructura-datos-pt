## **7. Contar Repeticiones de un Número**
### Descripción

Este programa cuenta la cantidad de veces que un número específico se repite dentro de un arreglo. Se inicializa un arreglo con valores predefinidos, que incluyen duplicados. El programa solicita un número al usuario y luego itera sobre el arreglo, usando un contador para rastrear las repeticiones del número buscado.
### Código

```
// Se incluye la biblioteca 'System' para la interacción con la consola.
using System;
class Program
{
    static void Main(string[] args)
    {
        // Se inicializa un arreglo con valores fijos, incluyendo duplicados para la demostración.
        int[] numeros = { 1, 2, 3, 4, 5, 3, 2, 1, 3 };
        
        Console.WriteLine("Ingrese un numero para buscar en el arreglo:");
        int numeroBuscado = int.Parse(Console.ReadLine());
        
        // Se inicializa el contador en cero.
        int contador = 0;

        // Se usa un bucle 'foreach' para recorrer cada elemento del arreglo.
        foreach (int numero in numeros)
        {
            // Se compara cada elemento con el número buscado.
            if (numero == numeroBuscado)
            {
                // Si coinciden, se incrementa el contador.
                contador++;
            }
        }

        // Se muestra el resultado final con el número de repeticiones.
        Console.WriteLine($"El numero {numeroBuscado} se repite {contador} veces en el arreglo.");
    }
}

```