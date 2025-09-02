using System;
class Ejercicio10
{
    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Suma de filas
        for (int i = 0; i < 3; i++)
        {
            int suma_fila = 0;
            for (int j = 0; j < 3; j++)
            {
                suma_fila += matriz[i, j];
            }
            Console.WriteLine("Fila " + (i + 1) + ": " + suma_fila);
        }

        // Suma de columnas
        for (int j = 0; j < 3; j++)
        {
            int suma_columna = 0;
            for (int i = 0; i < 3; i++)
            {
                suma_columna += matriz[i, j];
            }
            Console.WriteLine("Columna " + (j + 1) + ": " + suma_columna);
        }

    }
}