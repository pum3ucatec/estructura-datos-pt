# Ejercicio 1 - Contar del 1 al 10 en C#

Este programa muestra en pantalla los números del **1 al 10** utilizando un bucle `for`.

## Código

```csharp
using System;
class ejercicio_1
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)   // i = 1 y se adiciona hasta llegar a 10.
        {
            Console.WriteLine(i);
        }
    }
}
Explicación
Se utiliza un bucle for que comienza en i = 1.

La condición i <= 10 garantiza que el ciclo se ejecute hasta que i llegue a 10.

En cada iteración se muestra el valor de i con Console.WriteLine(i);.

El resultado en consola será:

Copiar código
1
2
3
4
5
6
7
8
9
10