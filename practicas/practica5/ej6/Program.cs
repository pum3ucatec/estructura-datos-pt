using System;

class Program
{
    static int[,] Transpose(int[,] matrix)
    {
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        int[,] transposed = new int[cols, rows];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                transposed[j, i] = matrix[i, j];
        return transposed;
    }

    static void Main()
    {
        int[,] matrix = { {1, 2, 3}, {4, 5, 6} };
        int[,] transposed = Transpose(matrix);

        Console.WriteLine("Transpuesta:");
        for (int i = 0; i < transposed.GetLength(0); i++)
        {
            for (int j = 0; j < transposed.GetLength(1); j++)
                Console.Write(transposed[i, j] + " ");
            Console.WriteLine();
        }
    }
}
