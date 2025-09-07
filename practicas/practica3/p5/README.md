# Ejercicio 5 - Encontrar el mayor y menor de un arreglo en C#

## 📌 Descripción
Este programa en C# declara un **arreglo de números enteros** y determina cuál es el **mayor** y el **menor** elemento del arreglo.  
El objetivo es recorrer el arreglo y comparar los elementos para encontrar los valores máximos y mínimos.

---

## 💻 Código

```csharp
using System;

class Ejercicio5
{
    static void Main()
    {
        int[] arreglo = { 12, 5, 8, 20, 3, 17, 25, 10 };
        int mayor = arreglo[0];
        int menor = arreglo[0];

        for (int i = 1; i < arreglo.Length; i++)
        {
            if (arreglo[i] > mayor) mayor = arreglo[i];
            if (arreglo[i] < menor) menor = arreglo[i];
        }

        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);
    }
}

📖 Explicación

Se define un arreglo arreglo con varios números enteros.
Se inicializan las variables mayor y menor con el primer elemento del arreglo.

El bucle for recorre el arreglo desde la segunda posición (i = 1).

Si un elemento es mayor que mayor, se actualiza mayor.

Si un elemento es menor que menor, se actualiza menor.

Al finalizar el recorrido, se muestran en consola los valores máximo y mínimo encontrados.

▶️ Ejemplo de salida

Mayor: 25
Menor: 3