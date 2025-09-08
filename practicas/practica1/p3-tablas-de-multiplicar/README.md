# 📘 Ejercicio 3 - Tabla de Multiplicar en C#

Este programa solicita al usuario un número y muestra su **tabla de multiplicar** del 1 al 10.

---

## 🎯 Objetivo
- Practicar el uso de **bucles for** en C#.
- Generar de forma automática la tabla de multiplicar de un número ingresado por el usuario.
- Reforzar la lectura de datos desde consola.

---

## 🔹 Código en C#

```csharp
using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
        }
    }
}
📌 Ejemplo de Ejecución
nginx
Copiar código
Ingresa un número: 7
7 x 1 = 7
7 x 2 = 14
7 x 3 = 21
7 x 4 = 28
7 x 5 = 35
7 x 6 = 42
7 x 7 = 49
7 x 8 = 56
7 x 9 = 63
7 x 10 = 70