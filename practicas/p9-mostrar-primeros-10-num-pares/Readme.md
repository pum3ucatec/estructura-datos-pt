#  Ejercicio 9 – Primeros 10 números pares con `while`

Este programa en C# imprime los **primeros 10 números pares** (del 2 al 20) utilizando un **bucle `while`**.

---

## Código fuente

```
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
```
## Explicación paso a paso
1. **Inicialización de variables**
```
int numero = 2;
int contador = 0;
```

- numero empieza en 2 porque es el primer número par.

- contador controla cuántos números se han mostrado.

2. **Bucle while**
```
while (contador < 10)
{
    Console.WriteLine(numero);
    numero += 2;
    contador++;
}
```

- La condición contador < 10 asegura que el ciclo se repita 10 veces.

- Console.WriteLine(numero); imprime el número actual.

- numero += 2; incrementa el número en 2 para generar el siguiente par.

- contador++ aumenta en 1 el contador hasta llegar a 10.

3. **Resultado esperado**

El programa mostrará:
```
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