using System;

class Ejercicio9
{
    static void Main()
    {
        int[,] mat = { {1,2,3}, {4,5,6}, {7,8,9} };
        int filas = 3, col = 3;
        int top = 0, bottom = filas-1, left = 0, right = col-1;

        Console.WriteLine("Recorrido en espiral:");
        while(top <= bottom && left <= right)
        {
            for(int i=left;i<=right;i++) Console.Write(mat[top,i] + " ");
            top++;
            for(int i=top;i<=bottom;i++) Console.Write(mat[i,right] + " ");
            right--;
            if(top <= bottom)
            {
                for(int i=right;i>=left;i--) Console.Write(mat[bottom,i] + " ");
                bottom--;
            }
            if(left <= right)
            {
                for(int i=bottom;i>=top;i--) Console.Write(mat[i,left] + " ");
                left++;
            }
        }
    }
}
