using System;
using System.Collections.Generic;

class Program
{
    static List<int> Espiral(int[,] matriz)
    {
        var res = new List<int>();
        int nFilas = matriz.GetLength(0), nCols = matriz.GetLength(1);
        int fIni = 0, fFin = nFilas - 1, cIni = 0, cFin = nCols - 1;

        while (fIni <= fFin && cIni <= cFin)
        {
            // izquierda → derecha
            for (int c = cIni; c <= cFin; c++) res.Add(matriz[fIni, c]);
            fIni++;

            // arriba → abajo
            for (int f = fIni; f <= fFin; f++) res.Add(matriz[f, cFin]);
            cFin--;

            // derecha → izquierda
            if (fIni <= fFin)
            {
                for (int c = cFin; c >= cIni; c--) res.Add(matriz[fFin, c]);
                fFin--;
            }

            // abajo → arriba
            if (cIni <= cFin)
            {
                for (int f = fFin; f >= fIni; f--) res.Add(matriz[f, cIni]);
                cIni++;
            }
        }
        return res;
    }

    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        var espiral = Espiral(matriz);
        Console.WriteLine("[" + string.Join(", ", espiral) + "]");
        // Salida: [1, 2, 3, 6, 9, 8, 7, 4, 5]
    }
}
