# 🧮 Mostrar los primeros 10 números pares en C#

## 📌 Descripción
Este programa imprime en pantalla los primeros 10 números pares utilizando un bucle `while`. Es ideal para practicar estructuras de control y lógica básica en C#.

## 🧠 Conceptos clave
- Uso del bucle `while` para repetir instrucciones.
- Control de flujo mediante un contador.
- Incremento de variables para generar números pares.

## 📋 Código fuente

```csharp
using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        int numero = 2;

        Console.WriteLine("Los primeros 10 números pares son:");

        while (contador < 10)
        {
            Console.WriteLine(numero);
            numero += 2;     
            contador++;     
        }
    }
}
