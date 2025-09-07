int[,] matriz = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

// Suma de filas
for (int fila = 0; fila < 3; fila++)
{
    int sumaFila = 0;
    for (int col = 0; col < 3; col++)
    {
        sumaFila += matriz[fila, col];
    }
    Console.WriteLine($"Fila {fila + 1}: {sumaFila}");
}

// Suma de columnas
for (int col = 0; col < 3; col++)
{
    int sumaCol = 0;
    for (int fila = 0; fila < 3; fila++)
    {
        sumaCol += matriz[fila, col];
    }
    Console.WriteLine($"Columna {col + 1}: {sumaCol}");
}
