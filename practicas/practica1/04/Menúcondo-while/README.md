# 📋 Menú interactivo en consola usando `while` y `switch` en C#

## 📌 Descripción
Este programa presenta un menú interactivo en consola que permite al usuario elegir entre tres opciones: saludar, sumar dos números o salir. El menú se repite hasta que el usuario selecciona la opción de salida. Es ideal para practicar estructuras de control como `while`, `switch` y manejo de entrada en C#.

## 🧠 Conceptos clave
- Bucle `while` para repetir el menú hasta que se elija salir.
- Estructura `switch` para ejecutar acciones según la opción seleccionada.
- Entrada de datos con `Console.ReadLine()` y conversión con `int.Parse`.

## 📋 Código fuente

```csharp
using System;

class Program
{
    static void Main()
    {
        int opcion = 0;

        while (opcion != 3) 
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar dos números");
            Console.WriteLine("3. Salir");
            Console.Write("Ingrese una opción: ");

            opcion = int.Parse(Console.ReadLine()!);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola! ¿Cómo estás?");
                    break;
                case 2:
                    Console.Write("Ingrese el primer número: ");
                    int num1 = int.Parse(Console.ReadLine()!);
                    Console.Write("Ingrese el segundo número: ");
                    int num2 = int.Parse(Console.ReadLine()!);
                    int suma = num1 + num2;
                    Console.WriteLine($"La suma de {num1} + {num2} es: {suma}");
                    break;
                case 3:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }
    }
}
