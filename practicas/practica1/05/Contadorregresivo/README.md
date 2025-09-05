# 🚀 Cuenta regresiva del 10 al 1 usando `while` en C#

## 📌 Descripción
Este programa muestra una cuenta regresiva desde el número 10 hasta el 1 utilizando un bucle `while`. Al finalizar, imprime el mensaje “¡Despegue!”. Es ideal para practicar bucles descendentes y lógica de control simple en C#.

## 🧠 Conceptos clave
- Uso del bucle `while` con condición descendente.
- Decremento de variable (`contador--`).
- Control de flujo hasta que se cumple la condición de parada.

## 📋 Código fuente

```csharp
using System;

class Countdown
{
    static void Main()
    {
        int contador = 10;

        while (contador >= 1)
        {
            Console.WriteLine(contador);
            contador--;
        }

        Console.WriteLine("¡Despegue!");
    }
}
