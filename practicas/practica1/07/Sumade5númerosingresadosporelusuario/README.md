# ➕ Sumar 5 números ingresados por el usuario usando `for` en C#

## 📌 Descripción
Este programa solicita al usuario que ingrese 5 números enteros (uno por uno) y calcula su suma total utilizando un bucle `for`. Incluye validación de entrada para asegurar que cada número sea válido.

## 🧠 Conceptos clave
- Uso del bucle `for` para iterar un número fijo de veces.
- Validación de entrada con `int.TryParse`.
- Acumulación de valores en una variable (`suma`).
- Repetición de iteración en caso de entrada inválida.

## 📋 Código fuente

```csharp
using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Introduce el número #{i}: ");
            string entrada = Console.ReadLine();

            // Validamos que sea un número entero
            if (int.TryParse(entrada, out int numero))
            {
                suma += numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, introduce un número entero.");
                i--; // Repetimos esta iteración
            }
        }

        Console.WriteLine($"La suma total de los 5 números es: {suma}");
    }
}
