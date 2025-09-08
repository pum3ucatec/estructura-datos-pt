using System;

class Program
{
    static void Main()
    {
        int[,] mat = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        SpiralPrint(mat);
    }

    static void SpiralPrint(int[,] mat)
    {
        int filas = mat.GetLength(0);
        int columnas = mat.GetLength(1);

        int top = 0, bottom = filas - 1;
        int left = 0, right = columnas - 1;

        while (top <= bottom && left <= right)
        {
            // Ir de izquierda a derecha
            for (int i = left; i <= right; i++)
                Console.Write(mat[top, i] + " ");
            top++;

            // Ir de arriba hacia abajo
            for (int i = top; i <= bottom; i++)
                Console.Write(mat[i, right] + " ");
            right--;

            // Ir de derecha a izquierda
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    Console.Write(mat[bottom, i] + " ");
                bottom--;
            }

            // Ir de abajo hacia arriba
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    Console.Write(mat[i, left] + " ");
                left++;
            }
        }
    }
}
