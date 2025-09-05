## 6. Búsqueda de un Número en un Arreglo
### Descripción

Este programa crea un arreglo de 5 enteros con valores proporcionados por el usuario. Luego, le pide al usuario un número específico para buscar. El programa recorre el arreglo y usa una variable booleana como "bandera" para verificar si el número se encuentra. Una vez encontrado, el bucle se detiene para optimizar la búsqueda.
### Código

```
// Se incluye la biblioteca 'System' para la interacción con la consola.
using System;
class Program
{
    static void Main(string[] args)
    {
        // Se declara un arreglo de 5 enteros.
        int[] numeros = new int[5];
        Console.WriteLine("Ingrese 5 numeros enteros:");

        // Bucle para llenar el arreglo con la entrada del usuario.
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Se pide al usuario el número que desea buscar.
        Console.Write("Ingrese un numero para buscar en el arreglo: ");
        int numeroBuscado = int.Parse(Console.ReadLine());

        // Se usa una variable booleana como bandera para saber si el número se encontró.
        bool encontrado = false;

        // Se recorre el arreglo para buscar el número.
        foreach (int numero in numeros)
        {
            if (numero == numeroBuscado)
            {
                // Si el número coincide, se cambia la bandera a 'true' y se rompe el bucle.
                encontrado = true;
                break;
            }
        }

        // Se evalúa la bandera para mostrar el resultado.
        if (encontrado)
        {
            Console.WriteLine($"El numero {numeroBuscado} se encuentra en el arreglo.");
        }
        else
        {
            Console.WriteLine($"El numero {numeroBuscado} no se encuentra en el arreglo.");
        }
    }
}

// Se incluye la biblioteca 'System' para la interacción con la consola.
using System;
class Program
{
    static void Main(string[] args)
    {
        // Se declara un arreglo de 5 enteros.
        int[] numeros = new int[5];
        Console.WriteLine("Ingrese 5 numeros enteros:");

        // Bucle para llenar el arreglo con la entrada del usuario.
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Se pide al usuario el número que desea buscar.
        Console.Write("Ingrese un numero para buscar en el arreglo: ");
        int numeroBuscado = int.Parse(Console.ReadLine());

        // Se usa una variable booleana como bandera para saber si el número se encontró.
        bool encontrado = false;
        
        // Se recorre el arreglo para buscar el número.
        foreach (int numero in numeros)
        {
            if (numero == numeroBuscado)
            {
                // Si el número coincide, se cambia la bandera a 'true' y se rompe el bucle.
                encontrado = true;
                break;
            }
        }

        // Se evalúa la bandera para mostrar el resultado.
        if (encontrado)
        {
            Console.WriteLine($"El numero {numeroBuscado} se encuentra en el arreglo.");
        }
        else
        {
            Console.WriteLine($"El numero {numeroBuscado} no se encuentra en el arreglo.");
        }
    }
}

