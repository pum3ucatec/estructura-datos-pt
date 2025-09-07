# Ejercicio 1 - Recorrer un arreglo en C#

## 📌 Descripción
Este programa en C# declara un **arreglo de números enteros** y utiliza un bucle `for` para recorrerlo.  
El objetivo es mostrar cada uno de los elementos en la consola.

---

## 💻 Código

```csharp
using System;

class Ejercicio1
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}

📖 Explicación

Se define un arreglo numeros con cinco valores enteros.

El bucle for inicia en i = 0 y termina en i < numeros.Length, lo que garantiza que se recorra todo el arreglo.

En cada iteración, Console.WriteLine(numeros[i]) imprime el valor correspondiente a la posición actual.

De esta forma, el programa muestra todos los elementos del arreglo de manera ordenada.

▶️ Ejemplo de salida
10
20
30
40
50