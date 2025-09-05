## 5. Encontrar el Mayor y el Menor de un Arreglo
### Descripción

Este programa busca el valor más grande y el más pequeño entre 5 números ingresados por el usuario. Sin almacenar todos los números en un arreglo, el programa los procesa uno por uno, comparándolos con los valores actuales del mayor y el menor. Se inicializa el mayor con el valor mínimo posible y el menor con el máximo posible para asegurar la correcta comparación inicial.
### Código
```


// Se incluye la biblioteca 'System' para la interacción con la consola.
using System;

class Program
{
    static void Main()
    {
        // Se inicializa 'mayor' con el valor entero mínimo y 'menor' con el máximo,
        // para garantizar que cualquier número ingresado sea mayor que 'mayor'
        // y menor que 'menor' en la primera iteración.
        int mayor = int.MinValue;
        int menor = int.MaxValue;

        // Bucle para leer 5 números del usuario.
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese un número: ");
            // Se lee la entrada y se convierte a entero.
            int numero = int.Parse(Console.ReadLine());

            // Si el número ingresado es mayor que el valor actual de 'mayor',
            // se actualiza 'mayor'.
            if (numero > mayor)
            {
                mayor = numero;
            }

            // Si el número ingresado es menor que el valor actual de 'menor',
            // se actualiza 'menor'.
            if (numero < menor)
            {
                menor = numero;
            }
        }

        // Se imprimen los resultados utilizando interpolación de cadenas.
        Console.WriteLine($"El número mayor es: {mayor}");
        Console.WriteLine($"El número menor es: {menor}");
    }
}


``` 