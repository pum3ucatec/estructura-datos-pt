int[,] matriz = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.WriteLine("Ejercicio 10:");
        Console.WriteLine("Matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nSuma de filas:");
        for (int i = 0; i < 3; i++)
        {
            int sumaFila = 0;
            for (int j = 0; j < 3; j++)
            {
                sumaFila += matriz[i, j];
            }
            Console.WriteLine($"Fila {i + 1}: {sumaFila}");
        }

        Console.WriteLine("\nSuma de columnas:");
        for (int j = 0; j < 3; j++)
        {
            int sumaCol = 0;
            for (int i = 0; i < 3; i++)
            {
                sumaCol += matriz[i, j];
            }
            Console.WriteLine($"Columna {j + 1}: {sumaCol}");
        }