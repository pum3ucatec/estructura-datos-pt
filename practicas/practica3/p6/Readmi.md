# Ejercicio 6 - Buscar un número en un arreglo en C#

## 📌 Descripción
Este programa en C# permite **buscar un número ingresado por el usuario** dentro de un arreglo de enteros.  
El objetivo es encontrar la posición del número si existe o indicar que no se encuentra.

---

## 💻 Código

```csharp
using System;

class Ejercicio6
{
    static void Main()
    {
        int[] arreglo = { 3, 7, 11, 17, 23, 29, 31, 37, 41, 43 };

        Console.Write("Ingrese un número: ");
        int buscado = int.Parse(Console.ReadLine());

        int posicion = -1;

        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == buscado)
            {
                posicion = i;
                break;
            }
        }

        if (posicion != -1)
            Console.WriteLine($"El número {buscado} se encuentra en la posición {posicion}");
        else
            Console.WriteLine("Número no encontrado.");
    }
}

📖 Explicación

Se define un arreglo arreglo con 10 números enteros.
El usuario ingresa un número que se almacenará en la variable buscado.

Se inicializa posicion en -1 para indicar que el número aún no ha sido encontrado.
El bucle for recorre el arreglo y compara cada elemento con buscado:

Si se encuentra el número, se guarda la posición y se detiene el bucle (break).

Si no se encuentra, posicion sigue siendo -1.

Finalmente, se muestra un mensaje indicando la posición del número o que no fue encontrado.

▶️ Ejemplo de salida

Caso 1: número encontrado

Ingrese un número: 17
El número 17 se encuentra en la posición 3


Caso 2: número no encontrado

Ingrese un número: 50
Número no encontrado.