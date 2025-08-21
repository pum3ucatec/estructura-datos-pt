// Declara una matriz de 3x3, inicialízala con valores y muestra la suma de cada fila y cada columna.  
using System;

class Ejercicio10
{
    static void Main()
    {
        int[,] matriz = {
            { 12, 3, 21 },
            { 4, 17, 16 },
            { 71, 58, 9 }
        };

        int filas = matriz.GetLength(0);   
        int columnas = matriz.GetLength(1); 

        
        for (int i = 0; i < filas; i++)
        {
            int sumaFila = 0;
            for (int j = 0; j < columnas; j++)
            {
                sumaFila += matriz[i, j];
            }
            Console.WriteLine($"Suma de la fila {i + 1}: {sumaFila}");
        }

    
        for (int j = 0; j < columnas; j++)
        {
            int sumaColumna = 0;
            for (int i = 0; i < filas; i++)
            {
                sumaColumna += matriz[i, j];
            }
            Console.WriteLine($"Suma de la columna {j + 1}: {sumaColumna}");
        }
    }

}