using System;

class pregunta1 {
    static void Main() {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int filaInicio = 0, filaFin = 2, colInicio = 0, colFin = 2;

        Console.Write("Recorrido en espiral: ");
        while (filaInicio <= filaFin && colInicio <= colFin) {
            for (int i = colInicio; i <= colFin; i++) Console.Write(matriz[filaInicio, i] + " ");
            filaInicio++;

            for (int i = filaInicio; i <= filaFin; i++) Console.Write(matriz[i, colFin] + " ");
            colFin--;

            if (filaInicio <= filaFin) {
                for (int i = colFin; i >= colInicio; i--) Console.Write(matriz[filaFin, i] + " ");
                filaFin--;
            }

            if (colInicio <= colFin) {
                for (int i = filaFin; i >= filaInicio; i--) Console.Write(matriz[i, colInicio] + " ");
                colInicio++;
            }
        }
    }
}
