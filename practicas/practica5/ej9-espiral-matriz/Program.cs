using System;
class Ejercicio9 {
    static void Main() {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int fila_inicio = 0, fila_fin = 2, col_inicio = 0, col_fin = 2;

        Console.Write("Recorrido en espiral: ");
        while (fila_inicio <= fila_fin && col_inicio <= col_fin) {
            for (int i = col_inicio; i <= col_fin; i++) Console.Write(matriz[fila_inicio, i] + " ");
            fila_inicio++;

            for (int i = fila_inicio; i <= fila_fin; i++) Console.Write(matriz[i, col_fin] + " ");
            col_fin--;

            if (fila_inicio <= fila_fin) {
                for (int i = col_fin; i >= col_inicio; i--) Console.Write(matriz[fila_fin, i] + " ");
                fila_fin--;
            }

            if (col_inicio <= col_fin) {
                for (int i = fila_fin; i >= fila_inicio; i--) Console.Write(matriz[i, col_inicio] + " ");
                col_inicio++;
            }
        }
    }
}
