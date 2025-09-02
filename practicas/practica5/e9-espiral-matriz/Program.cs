using System;

class RecorridoEspiral
{
    public static int[] RecorridoEspiral1(int[,] matriz)
    {
        if (matriz == null || matriz.Length == 0) return new int[0];
        
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[] resultado = new int[filas * columnas];
        int indice = 0;
        
        int filaInicio = 0, filaFin = filas - 1;
        int colInicio = 0, colFin = columnas - 1;
        
        while (filaInicio <= filaFin && colInicio <= colFin)
        {
            for (int j = colInicio; j <= colFin; j++)
                resultado[indice++] = matriz[filaInicio, j];
            filaInicio++;
            
            for (int i = filaInicio; i <= filaFin; i++)
                resultado[indice++] = matriz[i, colFin];
            colFin--;
            
            if (filaInicio <= filaFin)
            {
                for (int j = colFin; j >= colInicio; j--)
                    resultado[indice++] = matriz[filaFin, j];
                filaFin--;
            }
            
            if (colInicio <= colFin)
            {
                for (int i = filaFin; i >= filaInicio; i--)
                    resultado[indice++] = matriz[i, colInicio];
                colInicio++;
            }
        }
        
        return resultado;
    }

    public static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        
        Console.WriteLine("Matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        
        int[] resultado = RecorridoEspiral1(matriz);
        Console.WriteLine("Recorrido en espiral: " + string.Join(", ", resultado));
    }
}