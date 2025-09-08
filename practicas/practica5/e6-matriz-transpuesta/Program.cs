using System;

namespace MatrixTools
{
    class Transformer
    {
        // Método que genera la matriz transpuesta de la original
        public static int[,] GetTranspose(int[,] original)
        {
            int totalRows = original.GetLength(0);
            int totalCols = original.GetLength(1);

            int[,] result = new int[totalCols, totalRows];

            for (int r = 0; r < totalRows; r++)
            {
                for (int c = 0; c < totalCols; c++)
                {
                    result[c, r] = original[r, c];
                }
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[,] flipped = Transformer.GetTranspose(data);

            Console.WriteLine("Matriz transpuesta:");
            for (int i = 0; i < flipped.GetLength(0); i++)
            {
                for (int j = 0; j < flipped.GetLength(1); j++)
                {
                    Console.Write(flipped[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
