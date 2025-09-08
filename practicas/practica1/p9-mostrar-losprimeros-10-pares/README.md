# Ejercicio 9 - Imprimir los primeros 10 números pares

Este programa en **C#** imprime los primeros 10 números pares utilizando un bucle `while`.

---

## 📜 Código en C#
```csharp
using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;
            int contador = 0;

            while (contador < 10)
            {
                Console.WriteLine(numero);
                numero += 2;
                contador++;
            }
        }
    }
}
📌 Explicación paso a paso
Se inicializa la variable numero = 2, que representa el primer número par.

Se inicializa la variable contador = 0 para llevar el control de cuántos pares se imprimen.

La condición while (contador < 10) asegura que el bucle se repita 10 veces.

Dentro del bucle:

Se imprime el valor actual de numero.

Luego numero aumenta en 2 (para pasar al siguiente número par).

Finalmente, contador aumenta en 1.

El proceso se repite hasta que se hayan mostrado los primeros 10 números pares.

✅ Salida esperada en consola
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