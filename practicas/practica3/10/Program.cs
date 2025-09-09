int[,] matriz = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

for (int i = 0; i < 3; i++)
{
    int sumaFila = 0;
    for (int j = 0; j < 3; j++)
    {
        sumaFila += matriz[i, j];
    }
    Console.WriteLine("Fila " + (i + 1) + ": " + sumaFila);
}

for (int j = 0; j < 3; j++)
{
    int sumaCol = 0;
    for (int i = 0; i < 3; i++)
    {
        sumaCol += matriz[i, j];
    }
    Console.WriteLine("Columna " + (j + 1) + ": " + sumaCol);
}
