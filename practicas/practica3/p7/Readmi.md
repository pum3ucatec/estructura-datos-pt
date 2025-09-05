# Ejercicio 7 - Contar cuántas veces aparece un número en un arreglo en C#

## 📌 Descripción
Este programa en C# permite **contar cuántas veces se repite un número ingresado por el usuario** dentro de un arreglo de enteros.  
El objetivo es recorrer el arreglo, comparar cada elemento con el número ingresado y mostrar cuántas veces aparece.

---

## 💻 Código

```csharp
using System;

class Ejercicio7
{
    static void Main()
    {
        int[] arreglo = { 2, 5, 2, 8, 2, 9 };

        Console.Write("Número buscado: ");
        int numeroBuscado = int.Parse(Console.ReadLine());

        int contador = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == numeroBuscado)
                contador++;
        }

        Console.WriteLine($"El número aparece {contador} veces");
    }
}

📖 Explicación

Se define un arreglo arreglo con varios números enteros.
El usuario ingresa un número que se almacenará en la variable numeroBuscado.

Se declara la variable contador para registrar cuántas veces aparece el número.
El bucle for recorre cada elemento del arreglo y, si coincide con numeroBuscado, se incrementa contador.

Finalmente, Console.WriteLine muestra la cantidad de veces que aparece el número en el arreglo.

▶️ Ejemplo de salida

Caso 1: número encontrado varias veces

Número buscado: 2
El número aparece 3 veces


Caso 2: número no encontrado

Número buscado: 7
El número aparece 0 veces