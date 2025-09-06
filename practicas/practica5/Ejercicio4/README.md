# Ejercicio 4  Programa en C# - Encontrar el Número que Falta

## Descripción
Este programa en C# encuentra el número que falta en un arreglo que contiene los números del `1` al `n`, pero con un valor faltante.  
La solución se basa en la **fórmula de la suma de números naturales**.

---

## Funcionamiento
1. Se lee un arreglo de números enteros desde la consola (del `1` al `n`, con un número faltante).
2. Se calcula la suma esperada de los números del `1` al `n` usando la fórmula:
suma = n * (n + 1) / 2

csharp
Copiar código
3. Se resta la suma real del arreglo a la suma esperada.
4. El resultado es el número faltante.

---

## Código Principal
```csharp
using System;

namespace NumeroFaltante
{
 class Program
 {
     static void Main(string[] args)
     {
         Console.Write("Ingrese los números del arreglo separados por comas (del 1 al n, con un número faltante): ");
         string[] entrada = Console.ReadLine().Split(',');
         int[] arr = Array.ConvertAll(entrada, int.Parse);

         int n = arr.Length + 1; // porque falta un número
         int sumaEsperada = n * (n + 1) / 2;
         int sumaActual = 0;

         foreach (int num in arr)
         {
             sumaActual += num;
         }

         int faltante = sumaEsperada - sumaActual;

         Console.WriteLine("El número faltante es: " + faltante);
     }
 }
}
Ejemplo de Ejecución
css
Copiar código
Ingrese los números del arreglo separados por comas (del 1 al n, con un número faltante): 1,2,4,5,6
El número faltante es: 3
En este ejemplo, el arreglo va del 1 al 6, pero falta el número 3.

Explicación Matemática
Si n = 6, la suma esperada es:

Copiar código
6 * (6 + 1) / 2 = 21
La suma real del arreglo [1,2,4,5,6] es:

Copiar código
18
Diferencia:

Copiar código
21 - 18 = 3