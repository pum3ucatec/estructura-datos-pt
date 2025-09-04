
// Dado un arreglo de 10 números, pide al usuario un número y determina si está dentro del arreglo (imprime la posición si existe).

int[] numeros = new int[10];

        // Ingresar los 10 números
        Console.WriteLine("Ingrese 10 números :");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Pedir número a buscar
        Console.Write("\nIngrese un número a buscar en el arreglo: ");
        int buscar = Convert.ToInt32(Console.ReadLine());

        // Bandera para saber si se encontró
        bool encontrado = false;

        // Buscar en el arreglo
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscar)
            {
                Console.WriteLine(" El número " + buscar + " se encuentra en la posición: " + i);
                encontrado = true;
                break; // Se detiene el ciclo al encontrarlo
            }
        }

        // Si no se encontró
        if (!encontrado)
        {
            Console.WriteLine(" El número " + buscar + " no está en el arreglo.");
        }