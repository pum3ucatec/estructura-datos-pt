# 🔍 Verificar si un número es primo usando `for` en C#

## 📌 Descripción
Este programa solicita al usuario un número entero positivo y determina si es primo utilizando un bucle `for`. Es un ejercicio clásico para practicar validación de entrada, estructuras de control y lógica matemática en C#.

## 🧠 Conceptos clave
- Validación de entrada con `int.TryParse`.
- Uso de bucle `for` para verificar divisibilidad.
- Condición de primalidad: un número primo solo tiene dos divisores (1 y él mismo).

## 📋 Código fuente

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número entero positivo: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int numero) && numero > 0)
        {
            bool esPrimo = true;

            if (numero == 1)
            {
                esPrimo = false; 
            }
            else
            {
                for (int i = 2; i <= numero / 2; i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break; 
                    }
                }
            }

            if (esPrimo)
                Console.WriteLine($"{numero} es un número primo.");
            else
                Console.WriteLine($"{numero} no es un número primo.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, introduce un número entero positivo.");
        }
    }
}
