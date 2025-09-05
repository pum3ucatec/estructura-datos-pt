#  Ejercicio 2 – Crear e imprimir un arreglo con números consecutivos

Este programa en C# crea un **arreglo de 10 números consecutivos** (del 1 al 10) y luego imprime cada elemento en la consola utilizando **bucles `for`**.

---

##  Código fuente

```
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = i + 1;
        }
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
```

## Explicación paso a paso
1. Crear el arreglo
```
int[] numeros = new int[10];
```

- Se declara un arreglo de enteros llamado numeros con 10 posiciones.

- Inicialmente, todos los elementos son 0.

2. Llenar el arreglo con números consecutivos
```
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = i + 1;
}
```

- int i = 0; → el contador empieza en 0 (primer índice del arreglo).

- i < numeros.Length; → se recorre todo el arreglo.

- numeros[i] = i + 1; → asigna a cada posición el número consecutivo (1 al 10).

3. Imprimir los números
```
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
```

- Se recorre el arreglo nuevamente con un bucle for.

- Console.WriteLine(numeros[i]); imprime cada elemento en la consola.

4. Resultado esperado

El programa mostrará:
```
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