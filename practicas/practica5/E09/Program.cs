using System;

class Program
{
    static void Main()
    {
        int[,] matriz = {{1,2,3},{4,5,6},{7,8,9}};
        int filas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int top = 0, bottom = filas - 1, left = 0, right = cols - 1;

        Console.WriteLine("Matriz original:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Recorrido en espiral:");
        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++) Console.Write(matriz[top, i] + " ");
            top++;
            for (int i = top; i <= bottom; i++) Console.Write(matriz[i, right] + " ");
            right--;
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--) Console.Write(matriz[bottom, i] + " ");
                bottom--;
            }
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--) Console.Write(matriz[i, left] + " ");
                left++;
            }
        }
    }
}
