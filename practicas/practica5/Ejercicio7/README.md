# 📌 Ejercicio 7: Arreglo de Productos Excepto el Índice

## 📖 Enunciado
Dado un arreglo de enteros, construir un **nuevo arreglo** donde cada posición contenga el **producto de todos los elementos excepto el de esa posición**, **sin usar división**.

---

## ✨ Ejemplo
Entrada: [1, 2, 3, 4]
Salida: [24, 12, 8, 6]

pgsql
Copiar código

---

## 📌 Código en C#
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4 };

        Console.WriteLine("Arreglo original:");
        ImprimirArreglo(numeros);

        int[] resultado = ProductoExceptoIndice(numeros);

        Console.WriteLine("\nArreglo de productos excepto el índice:");
        ImprimirArreglo(resultado);
    }

    static int[] ProductoExceptoIndice(int[] arr)
    {
        int n = arr.Length;
        int[] izquierda = new int[n];
        int[] derecha = new int[n];
        int[] resultado = new int[n];

        izquierda[0] = 1;
        derecha[n - 1] = 1;

        for (int i = 1; i < n; i++)
            izquierda[i] = izquierda[i - 1] * arr[i - 1];

        for (int i = n - 2; i >= 0; i--)
            derecha[i] = derecha[i + 1] * arr[i + 1];

        for (int i = 0; i < n; i++)
            resultado[i] = izquierda[i] * derecha[i];

        return resultado;
    }

    static void ImprimirArreglo(int[] arr)
    {
        foreach (var num in arr)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
🛠️ Explicación paso a paso
Idea principal:

No se permite usar división.

Se usan dos arreglos auxiliares:

izquierda[i] → producto de todos los elementos antes de i.

derecha[i] → producto de todos los elementos después de i.

Construcción del resultado:

csharp
Copiar código
resultado[i] = izquierda[i] * derecha[i];
Ejemplo:

makefile
Copiar código
Arreglo: [1, 2, 3, 4]

izquierda: [1, 1, 2, 6]
derecha:   [24, 12, 4, 1]

resultado: [24, 12, 8, 6]
✅ Ejemplo de ejecución
yaml
Copiar código
Arreglo original:
1 2 3 4 

Arreglo de productos excepto el índice:
24 12 8 6
yaml
Copiar código
