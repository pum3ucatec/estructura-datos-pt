# 📘 Ejercicio 2 - Suma de los primeros N números

Este programa en C# solicita al usuario un número entero `N` y calcula la **suma de los primeros N números naturales** utilizando un ciclo `while`.

---

## 🎯 Objetivos
- Practicar el uso de bucles `while`.
- Implementar la suma acumulativa de números.
- Interactuar con el usuario mediante entrada y salida en consola.

---

## 🔹 Código Fuente

```csharp
using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número N: ");
            int N = int.Parse(Console.ReadLine());
            int suma = 0;
            int contador = 1;

            while (contador <= N)
            {
                suma += contador;
                contador++;
            }

            Console.WriteLine("Suma: " + suma);
        }
    }
}



📌 Ejemplo de Ejecución
Ingresa un número N: 5
Suma: 15

🛠️ Explicación del Código

Se pide al usuario que ingrese un valor N.

Se inicializan:

suma = 0 → Acumula la suma.

contador = 1 → Comienza desde 1.

Se usa un ciclo while que ejecuta mientras contador <= N.

En cada iteración:

Se suma el valor de contador a suma.

Se incrementa contador en 1.

Finalmente se imprime el resultado.