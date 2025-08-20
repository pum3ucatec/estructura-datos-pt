
// Dado un arreglo de enteros, pide un número y cuenta cuántas veces aparece en el arreglo.

int[] numeros = { 5, 8, 3, 8, 10, 8, 2, 7, 3, 8 };

        // Mostramos el arreglo en consola
        Console.WriteLine("Arreglo: ");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();

        // Pedimos al usuario el número a buscar
        Console.Write("\nIngrese un número a buscar: ");
        int buscar = Convert.ToInt32(Console.ReadLine());

        // Contador de ocurrencias
        int contador = 0;

        // Recorremos el arreglo
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscar)
            {
                contador++;
            }
        }

        // Mostramos el resultado
        if (contador > 0)
        {
            Console.WriteLine("\nEl número " + buscar + " aparece " + contador + " veces en el arreglo.");
        }
        else
        {
            Console.WriteLine("\nEl número " + buscar + " no se encuentra en el arreglo.");
        }