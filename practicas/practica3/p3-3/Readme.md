#  Ejercicio 3 – Sumar los elementos de un arreglo

Este programa en C# recorre un **arreglo de números** y calcula la **suma total** de sus elementos utilizando un **bucle `for`**.

---

##  Código fuente

```
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 10, 15, 20 };
        int suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }
        Console.WriteLine("Suma: " + suma);
    }
}
```

## Explicación paso a paso
1. Declaración e inicialización del arreglo
```
int[] numeros = { 5, 10, 15, 20 };
```

- Se crea un arreglo de enteros llamado numeros.

- Contiene 4 elementos: 5, 10, 15 y 20.

2. Inicialización de la variable acumuladora
```
int suma = 0;
```

- suma almacenará el total de los valores del arreglo.

- Se inicia en 0 porque aún no se han sumado valores.

3. Bucle for para sumar los elementos
```
for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}
```

- int i = 0; → el contador empieza en 0 (primer índice del arreglo).

- i < numeros.Length; → el ciclo recorre todo el arreglo.

- suma += numeros[i]; → agrega el valor del elemento actual al acumulador suma.

4. Mostrar el resultado
```
Console.WriteLine("Suma: " + suma);
```

Al finalizar el bucle, se imprime la suma total de los elementos del arreglo.