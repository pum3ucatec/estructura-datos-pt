# 📘 Ejercicio 4 - Menú Interactivo en C#

Este programa muestra un **menú interactivo en consola** que permite al usuario elegir entre tres opciones:  
1. Mostrar un saludo.  
2. Sumar dos números.  
3. Salir del programa.  

---

## 🎯 Objetivo
- Practicar el uso de **estructuras de control** como `do-while` y `switch-case`.  
- Implementar un menú dinámico en consola.  
- Reforzar la interacción con el usuario mediante entradas de teclado.

---

## 🔹 Código en C#

```csharp
using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Sumar 2 números");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("¡Hola espero andes muy bien!");
                        break;
                    case 2:
                        Console.Write("Número 1: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Número 2: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Suma: " + (a + b));
                        break;
                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (opcion != 3);
        }
    }
}
📌 Ejemplo de Ejecución
markdown
Copiar código
1. Saludar
2. Sumar 2 números
3. Salir
Elige una opción: 1
¡Hola espero andes muy bien!

1. Saludar
2. Sumar 2 números
3. Salir
Elige una opción: 2
Número 1: 5
Número 2: 7
Suma: 12

1. Saludar
2. Sumar 2 números
3. Salir
Elige una opción: 3
Saliendo...
