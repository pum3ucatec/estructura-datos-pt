# Ejercicio 3 - Tablas de multiplicar en C#

Este programa solicita un número al usuario y muestra su **tabla de multiplicar del 1 al 10** utilizando un bucle `for`.

## Código


using System;
class ejercicio_3
{
    static void Main()
    {
        Console.Write("Ingresa un número:");
        int num = int.Parse(Console.ReadLine()); // Número ingresado desde consola

        for (int i = 1; i <= 10; i++) // i = variable base, del 1 al 10
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
}
Explicación
El programa pide un número al usuario.

Se utiliza un bucle for que va desde i = 1 hasta i = 10.

En cada iteración, se multiplica el número ingresado por i.

El resultado se muestra en pantalla en formato de tabla.

Ejemplo de ejecución
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