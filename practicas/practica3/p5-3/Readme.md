#  Ejercicio 5 – Encontrar el mayor y menor de un arreglo

Este programa en C# recorre un **arreglo de números** y determina cuál es el **mayor** y el **menor** valor.

---

##  Código fuente

```
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 12, 5, 8, 20, 3, 17, 25, 10 };
        int mayor = numeros[0], menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor) mayor = numeros[i];
            if (numeros[i] < menor) menor = numeros[i];
        }

        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);
    }
}
```
## Explicación 

- Se inicializan mayor y menor con el primer elemento del arreglo.

- Se recorre el arreglo desde el segundo elemento:

- Si un número es mayor que mayor, se actualiza.

- Si un número es menor que menor, se actualiza.

- Al final, se muestran los valores de mayor y menor.

## Resultado esperado
Mayor: 25
Menor: 3