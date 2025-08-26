using System;

class Ejercicio6
{
    static void Main()
    {
        int[,] mat = { {1,2,3}, {4,5,6} };
        int filas = mat.GetLength(0);
        int col = mat.GetLength(1);

        int[,] trans = new int[col, filas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < col; j++)
            {
                trans[j,i] = mat[i,j];
            }
        }

        Console.WriteLine("Matriz transpuesta:");
        for (int i = 0; i < col; i++)
        {
            for (int j = 0; j < filas; j++)
                Console.Write(trans[i,j] + " ");
            Console.WriteLine();
        }
    }
}
