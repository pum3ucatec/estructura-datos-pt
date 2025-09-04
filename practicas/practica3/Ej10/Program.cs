
// Declara una matriz de 3x3, inicialízala con valores y muestra la suma de cada fila y cada columna.

 int[,] matriz = {
            { 2, 4, 6 },
            { 1, 3, 5 },
            { 7, 8, 9 }
        };

        int filas = matriz.GetLength(0);     // Número de filas
        int columnas = matriz.GetLength(1);  // Número de columnas

        Console.WriteLine("Matriz de 3x3 :");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Calcular suma de cada fila
        Console.WriteLine("\nSuma de cada fila:");
        for (int i = 0; i < filas; i++)
        {
            int sumaFila = 0;
            for (int j = 0; j < columnas; j++)
            {
                sumaFila += matriz[i, j];
            }
            Console.WriteLine("Fila " + (i + 1) + ": " + sumaFila);
        }

        // Calcular suma de cada columna
        Console.WriteLine("\nSuma de cada columna:");
        for (int j = 0; j < columnas; j++)
        {
            int sumaColumna = 0;
            for (int i = 0; i < filas; i++)
            {
                sumaColumna += matriz[i, j];
            }
            Console.WriteLine("Columna " + (j + 1) + ": " + sumaColumna);
        }
