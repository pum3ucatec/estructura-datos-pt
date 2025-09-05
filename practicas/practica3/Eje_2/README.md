## **2. Arreglo con Valores Aleatorios**
### **Descripción**

Este programa demuestra cómo llenar un arreglo de 10 elementos con valores aleatorios. Utiliza la clase Random para generar números en un rango específico. Posteriormente, utiliza un bucle foreach para recorrer el arreglo y mostrar cada uno de los números generados.
### **Código**

// Se incluyen las bibliotecas necesarias para funcionalidades del sistema y de colecciones.
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Se declara un arreglo para almacenar 10 enteros.
        int[] numeros = new int[10];
        // Se crea una instancia de la clase 'Random' para generar números aleatorios.
        Random rand = new Random();

        // Se usa un bucle 'for' para recorrer el arreglo y asignar valores aleatorios.
        // 'rand.Next(1, 101)' genera un número entero entre 1 (incluido) y 101 (excluido).
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = rand.Next(1, 101);
        }

        // Se imprimen los valores generados.
        Console.WriteLine("Los valores aleatorios del arreglo son:");
        // Se usa un bucle 'foreach' para iterar sobre cada elemento del arreglo de manera sencilla.
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
    }
}

