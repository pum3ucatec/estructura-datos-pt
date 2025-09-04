 // Dado un arreglo, crea un segundo arreglo que contenga los mismos elementos pero en orden inverso.

 int[] arreglo = { 1, 2, 3, 4, 5, 6, 7 };
        int[] inverso = new int[arreglo.Length]; // Segundo arreglo para guardar el inverso

        // Llenar el arreglo inverso recorriendo desde el final
        for (int i = 0; i < arreglo.Length; i++)
        {
            inverso[i] = arreglo[arreglo.Length - 1 - i];
        }

        // Mostrar el arreglo original
        Console.WriteLine("Arreglo original:");
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write(arreglo[i] + " ");
        }

        // Mostrar el arreglo inverso
        Console.WriteLine("\n\nArreglo en orden inverso:");
        for (int i = 0; i < inverso.Length; i++)
        {
            Console.Write(inverso[i] + " ");

        }
            