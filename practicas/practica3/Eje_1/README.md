## **1. Declaración y Asignación de un Arreglo**
### **Descripción**

Este programa muestra cómo declarar un arreglo de tamaño fijo (5 en este caso) y cómo asignar valores a cada una de sus posiciones de manera individual. Luego, recorre el arreglo con un bucle for para imprimir cada elemento en la consola, lo que permite visualizar el contenido del arreglo.
## **Código**

// Se utiliza la directiva 'using' para incluir las funcionalidades del sistema.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaración e inicialización de un arreglo de 5 enteros.
        // La sintaxis 'new int[5]' crea un espacio en memoria para 5 elementos.
        int[] numeros = new int[5];
        using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaración e inicialización de un arreglo de 5 enteros.
        // La sintaxis 'new int[5]' crea un espacio en memoria para 5 elementos.
        int[] numeros = new int[5];
        
        // Asignación de valores a cada posición del arreglo,
        // utilizando el índice (0 a 4) para acceder a cada elemento.
        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;
        numeros[3] = 40;
        numeros[4] = 50;

        // Imprimir los valores del arreglo en la consola.
        Console.WriteLine("Los valores del arreglo son:");
        
        // Se usa un bucle 'for' para iterar sobre cada índice del arreglo.
        // La propiedad 'numeros.Length' devuelve el tamaño total del arreglo (5).
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");
        }
    }
}

        }
    }