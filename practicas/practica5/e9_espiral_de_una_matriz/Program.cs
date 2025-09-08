using System;

class ejercicio_9 {
    static void Main() {
        Console.WriteLine("Ingrese filas:");
        int filas = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese columnas:");
        int cols = int.Parse(Console.ReadLine());

        int[,] matriz = new int[filas, cols];
        Console.WriteLine("Ingrese los elementos:");
        for (int i = 0; i < filas; i++) {
            for (int j = 0; j < cols; j++) {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int top = 0, bottom = filas - 1, left = 0, right = cols - 1;

        Console.WriteLine("Recorrido en espiral:");
        while (top <= bottom && left <= right) {
            for (int j = left; j <= right; j++) Console.Write(matriz[top, j] + " ");
            top++;
            for (int i = top; i <= bottom; i++) Console.Write(matriz[i, right] + " ");
            right--;
            if (top <= bottom) {
                for (int j = right; j >= left; j--) Console.Write(matriz[bottom, j] + " ");
                bottom--;
            }
            if (left <= right) {
                for (int i = bottom; i >= top; i--) Console.Write(matriz[i, left] + " ");
                left++;
            }
        }
    }
}
