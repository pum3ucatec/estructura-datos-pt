## **3. Suma de los Elementos de un Arreglo**
### **Descripción**

En este ejemplo, se inicializa un arreglo con valores predefinidos. El programa calcula la suma total de todos los elementos del arreglo. Para lograrlo, utiliza un bucle foreach que itera sobre cada número y los va acumulando en una variable, mostrando el resultado final.
### **Código**

// Se incluye la biblioteca 'System' para usar la consola.
using System;

class Program
{
    static void Main()
    {
        // Se inicializa un arreglo de enteros con valores directos.
        int[] numeros = { 20, 51, 49, 56, 55 };
        // Se declara una variable para acumular la suma, inicializada en 0.
        int suma = 0;

        // Se usa un bucle 'foreach' para iterar sobre cada elemento del arreglo.
        foreach (int numero in numeros)
        {
            // Se suma el valor del elemento actual a la variable 'suma'.
            suma += numero;
        }

        // Se imprime el resultado final en la consola.
        Console.WriteLine("La suma de los elementos del arreglo es: " + suma);
    }
}

