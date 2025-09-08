# Ejercicio 5 - Contador regresivo en C#

Este programa muestra una **cuenta regresiva** desde el número 10 hasta el 1 utilizando un bucle `while`.



```csharp
using System;

class EjercicioCinco
{
    static void Main()
    {
        int numero = 10; // valor inicial de la cuenta regresiva

        while (numero > 0) // se ejecuta mientras el número sea mayor a 0
        {
            Console.WriteLine(numero);
            numero--; // disminuye en cada ciclo
        }

        Console.WriteLine("¡Despegue!");
    }
}
Explicación
Se define la variable numero con valor inicial 10.

Con el bucle while (numero > 0), se muestran en pantalla los números de forma descendente.

En cada iteración, numero disminuye en 1.

Al finalizar, aparece el mensaje "¡Despegue!" como cierre de la cuenta regresiva.

Ejemplo de ejecución
Copiar código
10
9
8
7
6
5
4
3
2
1
¡Despegue!