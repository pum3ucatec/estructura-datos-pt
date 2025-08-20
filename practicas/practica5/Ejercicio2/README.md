# Ejercicio 2 Programa en C# - Subarreglo con Suma Máxima (Kadane’s Algorithm)

## Descripción
Este programa en C# implementa el **Algoritmo de Kadane** para encontrar el subarreglo contiguo con la suma más grande dentro de un arreglo de números enteros (puede contener positivos y negativos).

---

## Funcionamiento
1. El programa solicita al usuario ingresar los elementos del arreglo separados por comas.
2. Convierte los datos ingresados en un arreglo de enteros.
3. Aplica el algoritmo de **Kadane** para encontrar la suma máxima posible de un subarreglo contiguo.
4. Muestra la suma máxima encontrada.

---

## Código Principal
```csharp
using System;

namespace SubarregloMaximo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los elementos del arreglo separados por comas: ");
            string[] entrada = Console.ReadLine().Split(',');
            int[] arr = Array.ConvertAll(entrada, int.Parse);

            int sumaMaxima = Kadane(arr);

            Console.WriteLine($"La suma máxima del subarreglo es: {sumaMaxima}");
        }

        public static int Kadane(int[] arr)
        {
            int maxActual = arr[0];
            int maxGlobal = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                maxActual = Math.Max(arr[i], maxActual + arr[i]);
                if (maxActual > maxGlobal)
                {
                    maxGlobal = maxActual;
                }
            }
            return maxGlobal;
        }
    }
}
Ejemplo de Ejecución
less
Copiar código
Ingrese los elementos del arreglo separados por comas: -2,1,-3,4,-1,2,1,-5,4
La suma máxima del subarreglo es: 6