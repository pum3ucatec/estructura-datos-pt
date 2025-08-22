// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pregunta 1!");



int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

List<int> resultado = RecorrerEspiral(matriz);

Console.WriteLine("Recorrido en espiral:");
Console.WriteLine(string.Join(", ", resultado));


static List<int> RecorrerEspiral(int[,] matriz)
{
    List<int> espiral = new List<int>();

    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    int inicioFila = 0, finFila = filas - 1;
    int inicioCol = 0, finCol = columnas - 1;

    while (inicioFila <= finFila && inicioCol <= finCol)
    {
        // Recorrer la fila superior
        for (int i = inicioCol; i <= finCol; i++)
            espiral.Add(matriz[inicioFila, i]);
        inicioFila++;

        // Recorrer la columna derecha
        for (int i = inicioFila; i <= finFila; i++)
            espiral.Add(matriz[i, finCol]);
        finCol--;

        // Recorrer la fila inferior (si aún queda)
        if (inicioFila <= finFila)
        {
            for (int i = finCol; i >= inicioCol; i--)
                espiral.Add(matriz[finFila, i]);
            finFila--;
        }

        // Recorrer la columna izquierda (si aún queda)
        if (inicioCol <= finCol)
        {
            for (int i = finFila; i >= inicioFila; i--)
                espiral.Add(matriz[i, inicioCol]);
            inicioCol++;
        }
    }

    return espiral;
}
