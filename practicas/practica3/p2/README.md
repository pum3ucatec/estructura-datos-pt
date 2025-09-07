# Ejercicio 2 - Recorrer un arreglo de 10 elementos en C#

## 📌 Descripción
Este programa en C# declara un **arreglo de 10 números enteros** y utiliza un bucle `for` para recorrerlo.  
El objetivo es mostrar cada uno de los elementos en la consola.

---

## 💻 Código

```csharp
using System;

class Ejercicio2
{
    static void Main()
    {
        int[] arreglo10 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        for (int i = 0; i < arreglo10.Length; i++)
        {
            Console.WriteLine(arreglo10[i]);
        }
    }
}

📖 Explicación

Se define un arreglo arreglo10 con diez valores enteros del 1 al 10.

El bucle for inicia en i = 0 y termina en i < arreglo10.Length, asegurando que se recorra todo el arreglo.

En cada iteración, Console.WriteLine(arreglo10[i]) imprime el valor correspondiente a la posición actual.

De esta forma, el programa muestra todos los elementos del arreglo de manera ordenada.

▶️ Ejemplo de salida

1
2
3
4
5
6
7
8
9
10