# Ejercicio 10 - Juego de adivinar el número

## 📌 Descripción
Este programa en **C#** genera un número aleatorio entre **1 y 50** y el usuario debe **adivinarlo**.  
Después de cada intento, el programa indica si el número buscado es **más alto** o **más bajo** hasta que el usuario acierte.

## 📝 Código
```csharp
using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(1, 51);
            int intento;

            Console.WriteLine("Adivina el número (1-50):");

            do
            {
                Console.Write("Tu intento: ");
                intento = int.Parse(Console.ReadLine());

                if (intento < aleatorio)
                    Console.WriteLine("Más alto");
                else if (intento > aleatorio)
                    Console.WriteLine("Más bajo");

            } while (intento != aleatorio);

            Console.WriteLine("¡Correcto! El número era " + aleatorio);
        }
    }
}
▶️ Ejecución esperada
Ejemplo de interacción con el programa:

yaml
Copiar código
Adivina el número (1-50):
Tu intento: 25
Más alto
Tu intento: 40
Más bajo
Tu intento: 33
¡Correcto! El número era 33
💡 Explicación
Random rnd = new Random(); → Genera un número aleatorio.

rnd.Next(1, 51) → Devuelve un número entre 1 y 50.

do { ... } while (intento != aleatorio); → El ciclo se repite hasta que el usuario adivine.

El programa guía con mensajes:

"Más alto" si el número ingresado es menor al correcto.

"Más bajo" si el número ingresado es mayor al correcto.