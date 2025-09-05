## **8. Crear un Arreglo Inverso**
### **Descripción**

Este programa crea una copia de un arreglo, pero con los elementos en orden inverso. Se inicializa un primer arreglo y se declara un segundo arreglo del mismo tamaño. Luego, se utiliza un bucle for para iterar sobre el arreglo original y asignar sus elementos al nuevo arreglo, pero comenzando desde el final.
### **Código**

```

// Se incluye la biblioteca 'System' para la interacción con la consola.
using System;
class Program
{
    static void Main(string[] args)
    {
        // Arreglo original con 5 elementos.
        int[] arreglo1 = { 1, 2, 3, 4, 5 };
        // Se declara un segundo arreglo con el mismo tamaño que el primero.
        int[] arreglo2 = new int[arreglo1.Length];

        // Se usa un bucle 'for' para recorrer el arreglo original.
        for (int i = 0; i < arreglo1.Length; i++)
        {
            // Se asigna el elemento del final del 'arreglo1' al 'arreglo2', invirtiendo el orden.
            // La fórmula 'arreglo1.Length - 1 - i' calcula el índice inverso.
            arreglo2[i] = arreglo1[arreglo1.Length - 1 - i];
        }

        // Se imprimen ambos arreglos para comparar los resultados.
        Console.WriteLine("Arreglo original: " + string.Join(", ", arreglo1));
        Console.WriteLine("Arreglo inverso: " + string.Join(", ", arreglo2));
    }
}
```
