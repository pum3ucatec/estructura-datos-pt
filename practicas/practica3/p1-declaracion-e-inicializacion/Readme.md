#  Ejercicio 1 – Imprimir elementos de un arreglo con `for`

Este programa en C# recorre un **arreglo de números** y muestra cada elemento en la consola utilizando un **bucle `for`**.

---

##  Código fuente

```
using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
```

## Explicación paso a paso
1. Declaración e inicialización del arreglo
```
int[] numeros = { 10, 20, 30, 40, 50 };
```

- Se crea un arreglo de enteros llamado numeros.

- Contiene 5 elementos: 10, 20, 30, 40 y 50.

2. Bucle for para recorrer el arreglo
```
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
```

- int i = 0; → el contador empieza en 0, que corresponde al primer índice del arreglo.

- i < numeros.Length; → el ciclo se repite mientras i sea menor que la longitud del arreglo (5).

- i++ → incrementa el contador en 1 en cada vuelta.

**Dentro del bucle:**

- numeros[i] accede al elemento del arreglo en la posición i.

- Console.WriteLine(numeros[i]); imprime el valor en pantalla.

3. Resultado esperado

El programa mostrará:
```
10
20
30
40
50
```