# Ejercicio 4 - Calcular el promedio de un arreglo en C#

## 📌 Descripción
Este programa en C# declara un **arreglo de notas** y calcula el **promedio** de todos sus elementos.  
El objetivo es recorrer el arreglo, sumar los valores, calcular el promedio y mostrarlo en la consola.

---

## 💻 Código

```csharp
using System;

class Ejercicio4
{
    static void Main()
    {
        int[] notas = { 80, 70, 90, 60, 100 };
        int total = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }

        double promedio = (double)total / notas.Length;
        Console.WriteLine("Promedio: " + promedio);
    }
}
📖 Explicación

Se define un arreglo notas con cinco valores enteros.
Se declara la variable total para acumular la suma de todas las notas.

El bucle for recorre cada elemento del arreglo y suma su valor a total.
Luego, se calcula el promedio dividiendo total entre la cantidad de elementos (notas.Length).
Se convierte la división a double para obtener un resultado con decimales.

Finalmente, Console.WriteLine muestra el promedio en la consola.

▶️ Ejemplo de salida

Promedio: 80