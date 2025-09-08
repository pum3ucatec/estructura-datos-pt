# Ejercicio 2 - Sumar números del 1 al N en C#

Este programa pide al usuario un número `N` y calcula la suma de todos los números desde **1 hasta N** utilizando un bucle `while`.

## Código

```csharp
using System;
class ejercicio_2
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int N = int.Parse(Console.ReadLine()); // N = Número ingresado desde consola

        int suma = 0;
        int a = 1; // Variable base

        while (a <= N)
        {
            suma += a;
            a++;
        }

        Console.WriteLine("La suma del 1 al " + N + " es: " + suma);
    }
}
Explicación
El programa solicita un número N al usuario.

Se inicializa la variable suma en 0 y una variable de control a = 1.

Con el bucle while (a <= N) se van sumando los valores de a a la variable suma.

En cada iteración, a aumenta en 1.

Al finalizar, se muestra en pantalla el resultado.

Ejemplo de ejecución
less
Copiar código
Ingresa un número: 5
La suma del 1 al 5 es: 15