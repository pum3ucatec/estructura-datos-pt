#  Ejercicio 5 – Conteo regresivo con `while`

Este programa en C# muestra en pantalla un **conteo regresivo desde 30 hasta 1** utilizando un bucle `while`.

---

## Código fuente

```
using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 30;
            while (c > 0)
            {
                Console.WriteLine(c);
                c--;
            }
        }
    }
}
```
Explicación paso a paso
1. **Inicialización**
```
int c = 30;
```

- Se crea una variable entera c con valor inicial 30.

- Esta será la base del conteo regresivo.

2. **Bucle while**
```
while (c > 0)
{
    Console.WriteLine(c);
    c--;
}
```

- La condición c > 0 asegura que el ciclo se ejecute mientras c sea mayor que 0.

- Console.WriteLine(c); imprime el valor actual de c.

- c--; reduce el valor de c en 1 en cada iteración.

3. **Resultado esperado**

El programa imprimirá:
```
30
29
28
27
...
3
2
1
```