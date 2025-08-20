#  Ejercicio 5 Programa en C# - Intersección de Dos Arreglos

## Descripción
Este programa en C# encuentra los elementos comunes entre dos arreglos de enteros sin usar **LINQ**.  
Se asegura de considerar la cantidad de veces que aparece cada número (frecuencia).  

Ejemplo:  
`[1,2,2,1]` y `[2,2]` → `[2,2]`.

---

## Funcionamiento
1. Se piden al usuario **dos arreglos** de enteros, separados por comas.
2. Se comparan los elementos del primer arreglo con el segundo.
3. Cada vez que se encuentra coincidencia, se marca como **usado** para evitar duplicados incorrectos.
4. Se imprime la lista de intersección.

---

## Código Principal
```csharp
using System;

namespace InterseccionArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer arreglo (números separados por comas): ");
            string[] entrada1 = Console.ReadLine().Split(',');
            int[] arr1 = Array.ConvertAll(entrada1, int.Parse);

            Console.WriteLine("Ingrese el segundo arreglo (números separados por comas): ");
            string[] entrada2 = Console.ReadLine().Split(',');
            int[] arr2 = Array.ConvertAll(entrada2, int.Parse);

            bool[] usado = new bool[arr2.Length]; // Para marcar los elementos ya emparejados
            Console.Write("Intersección: [");

            bool primero = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j] && !usado[j])
                    {
                        if (!primero)
                            Console.Write(", ");
                        Console.Write(arr1[i]);
                        usado[j] = true;
                        primero = false;
                        break;
                    }
                }
            }

            Console.WriteLine("]");
        }
    }
}
Ejemplo de Ejecución
java
Copiar código
Ingrese el primer arreglo (números separados por comas): 
1,2,2,1
Ingrese el segundo arreglo (números separados por comas): 
2,2
Intersección: [2, 2]
Explicación
El programa recorre el primer arreglo elemento por elemento.

Cada vez que encuentra coincidencia con el segundo arreglo, imprime ese valor y lo marca como usado.

Así se respeta el número de veces que aparece un elemento en ambos arreglos.