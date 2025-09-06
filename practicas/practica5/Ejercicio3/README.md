# Ejercicio 3 Programa en C# - Eliminar Duplicados en un Arreglo Ordenado

## Descripción
Este programa en C# elimina los **elementos duplicados** de un **arreglo ordenado**, sin utilizar colecciones como `List` o `HashSet`.  
El resultado se muestra sobrescribiendo el arreglo original, dejando solo los elementos únicos.

---

## Funcionamiento
1. El programa solicita al usuario que ingrese un arreglo **ordenado** de enteros separados por comas.
2. Elimina los valores duplicados desplazando los elementos únicos hacia adelante.
3. Retorna el nuevo tamaño del arreglo sin duplicados.
4. Muestra el arreglo final sin valores repetidos.

---

## Código Principal
```csharp
using System;

namespace EliminarDuplicados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los elementos del arreglo ordenado separados por comas: ");
            string[] entrada = Console.ReadLine().Split(',');
            int[] arr = Array.ConvertAll(entrada, int.Parse);

            int nuevoTamaño = EliminarDuplicadosOrdenados(arr);

            Console.Write("Arreglo sin duplicados: ");
            for (int i = 0; i < nuevoTamaño; i++)
            {
                Console.Write(arr[i] + (i < nuevoTamaño - 1 ? ", " : ""));
            }
        }

        public static int EliminarDuplicadosOrdenados(int[] arr)
        {
            if (arr.Length == 0) return 0;

            int indice = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[indice - 1])
                {
                    arr[indice] = arr[i];
                    indice++;
                }
            }

            return indice;
        }
    }
}
Ejemplo de Ejecución
yaml
Copiar código
Ingrese los elementos del arreglo ordenado separados por comas: 1,1,2,2,3,4,4
Arreglo sin duplicados: 1, 2, 3, 4