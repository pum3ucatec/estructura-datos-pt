# Ejercicio 3 - Sumar los elementos de un arreglo en C#

## 📌 Descripción
Este programa en C# declara un **arreglo de números enteros** y calcula la **suma de todos sus elementos**.  
El objetivo es recorrer el arreglo, sumar cada valor y mostrar el resultado en la consola.

---

## 💻 Código

```csharp
using System;

class Ejercicio3
{
    static void Main()
    {
        int[] arreglo = { 5, 10, 15, 20 };
        int suma = 0;

        for (int i = 0; i < arreglo.Length; i++)
        {
            suma += arreglo[i];
        }

        Console.WriteLine("Suma: " + suma);
    }
}

📖 Explicación

Se define un arreglo arreglo con los valores {5, 10, 15, 20}.
Se declara una variable suma inicializada en 0 para almacenar el total.

El bucle for recorre cada elemento del arreglo.
En cada iteración, se suma el valor del elemento actual a la variable suma.

Finalmente, Console.WriteLine muestra la suma total de los elementos en la consola.

▶️ Ejemplo de salida

Suma: 50