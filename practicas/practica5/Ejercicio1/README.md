# 📘 Ejercicio 1 - Rotación de Arreglo

## 📌 Descripción
Este programa en **C#** permite **rotar un arreglo de enteros hacia la derecha** un número `k` de posiciones.  
La rotación se logra **invirtiendo segmentos del arreglo** para optimizar el proceso.

---

## ⚙️ Funcionamiento
1. Se define un arreglo y un número `k`.  
2. Se rota el arreglo usando la técnica de **tres reversos**:
   - Invertir todo el arreglo.
   - Invertir los primeros `k` elementos.
   - Invertir los elementos restantes.  
3. Se imprime el arreglo resultante en consola.  

---

## 📝 Código en C#
```csharp
using System;

namespace Ejercicio1
{
    class Program
    {
        static void RotateArray(int[] arr, int k)
        {
            k = k % arr.Length; // Evita rotaciones innecesarias
            Reverse(arr, 0, arr.Length - 1);
            Reverse(arr, 0, k - 1);
            Reverse(arr, k, arr.Length - 1);
        }

        static void Reverse(int[] arr, int inicio, int fin)
        {
            while (inicio < fin)
            {
                int temp = arr[inicio];
                arr[inicio] = arr[fin];
                arr[fin] = temp;
                inicio++;
                fin--;
            }
        }

        static void Main(string[] args)
        {
            int[] arreglo = { 1, 2, 3, 4, 5 };
            int k = 2;

            Console.WriteLine("Arreglo original: " + string.Join(", ", arreglo));

            RotateArray(arreglo, k);

            Console.WriteLine($"Arreglo rotado {k} posiciones: " + string.Join(", ", arreglo));
        }
    }
}


▶️ Ejemplo de Ejecución
yaml
Copiar código
Arreglo original: 1, 2, 3, 4, 5
Arreglo rotado 2 posiciones: 4, 5, 1, 2, 3
💡 Explicación
Se usa la técnica de reversos para evitar rotar elemento por elemento, lo que hace al algoritmo más eficiente.

Complejidad:

Tiempo: O(n)

Espacio adicional: O(1)