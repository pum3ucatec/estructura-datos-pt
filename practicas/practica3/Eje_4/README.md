## **4. Promedio de Elementos Ingresados por el Usuario**
### **Descripción**

Este programa interactúa con el usuario, pidiendo que ingrese 5 números enteros. Estos números se almacenan en un arreglo. El programa calcula la suma de todos los elementos y luego divide esa suma entre la cantidad de elementos para obtener el promedio, el cual es mostrado en la consola.
### **Código**

```
// Se incluye la biblioteca 'System' para la interacción con la consola y conversión de tipos.
using System;

class Program
{
    static void Main()
    {
        // Se declara un arreglo de 5 enteros.
        int[] numeros = new int[5];
        // Se inicializa la variable de suma en 0.
        int suma = 0;

        // Bucle para pedir y leer 5 números del usuario.
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese un número: ");
            // Se lee la entrada del usuario (que es un string) y se convierte a entero.
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            // Se añade el número a la suma total.
            suma += numeros[i];
        }

        // Se calcula el promedio.
        // Se realiza un 'cast' a 'double' para asegurar que la división sea flotante y no entera.
        double promedio = (double)suma / 5;
        
        // Se imprime el resultado final.
        Console.WriteLine("El promedio es: " + promedio);
    }
}

