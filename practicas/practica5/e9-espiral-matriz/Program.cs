using System;
using System.Collections.Generic;

namespace MatrixTraversal
{
    class SpiralPrinter
    {
        // Recorre una matriz en orden espiral y devuelve la secuencia
        public static List<int> GetSpiral(int[,] grid)
        {
            List<int> path = new List<int>();
            int topRow = 0, bottomRow = grid.GetLength(0) - 1;
            int leftCol = 0, rightCol = grid.GetLength(1) - 1;

            while (topRow <= bottomRow && leftCol <= rightCol)
            {
                // Recorrido izquierda → derecha
                for (int col = leftCol; col <= rightCol; col++)
                    path.Add(grid[topRow, col]);
                topRow++;

                // Recorrido arriba → abajo
                for (int row = topRow; row <= bottomRow; row++)
                    path.Add(grid[row, rightCol]);
                rightCol--;

                // Recorrido derecha → izquierda
                if (topRow <= bottomRow)
                {
                    for (int col = rightCol; col >= leftCol; col--)
                        path.Add(grid[bottomRow, col]);
                    bottomRow--;
                }

                // Recorrido abajo → arriba
                if (leftCol <= rightCol)
                {
                    for (int row = bottomRow; row >= topRow; row--)
                        path.Add(grid[row, leftCol]);
                    leftCol++;
                }
            }

            return path;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[,] sample = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            List<int> spiralPath = SpiralPrinter.GetSpiral(sample);

            Console.WriteLine("Recorrido en espiral:");
            foreach (int value in spiralPath)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
