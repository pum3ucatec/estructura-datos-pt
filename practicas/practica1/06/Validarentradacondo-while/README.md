# 🔁 Validar entrada de número positivo usando `do...while` en C#

## 📌 Descripción
Este programa solicita al usuario que introduzca un número entero positivo y continúa pidiendo la entrada hasta que se cumpla la condición. Utiliza un bucle `do...while` para garantizar al menos una ejecución y aplicar validación de entrada.

## 🧠 Conceptos clave
- Bucle `do...while` para repetir instrucciones hasta que se cumpla una condición.
- Validación de entrada con `int.TryParse`.
- Condición lógica para verificar si el número es positivo.

## 📋 Código fuente

```csharp
using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Por favor, introduce un número positivo: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                if (numero > 0)
                {
                    Console.WriteLine($"¡Gracias! Has introducido el número positivo: {numero}");
                    break;
                }
                else
                {
                    Console.WriteLine("El número no es positivo. Inténtalo de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, introduce un número entero.");
            }

        } while (true);
    }
}
