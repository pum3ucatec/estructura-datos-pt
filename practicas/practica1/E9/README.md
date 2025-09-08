# Ejercicio 9 - Mostrar los primeros 10 números pares en C#

Este programa muestra en pantalla los **primeros 10 números pares** utilizando un bucle `while`.

## Código


using System;

class NumerosPares
{
    static void Main()
    {
        int cantidadMostrada = 0; // cuántos pares se han mostrado
        int parActual = 2;        // primer número par

        while (cantidadMostrada < 10)
        {
            Console.WriteLine(parActual);
            parActual += 2;       // avanza al siguiente par
            cantidadMostrada++;
        }

        Console.WriteLine("Fin de la lista de pares.");
    }
}
Explicación
La variable parActual comienza en 2 (primer número par).

La variable cantidadMostrada controla cuántos pares se han mostrado.

El bucle while (cantidadMostrada < 10) asegura que se impriman solo 10 pares.

En cada iteración:

Se muestra el número par.

Se incrementa en 2 (parActual += 2).

Se incrementa el contador.

Al finalizar, se imprime un mensaje de cierre.

Ejemplo de ejecución
Copiar código
2
4
6
8
10
12
14
16
18
20
Fin de la lista de pares.