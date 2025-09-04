using System;

class ejercicio_6 {
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

        Console.WriteLine("Matriz Transpuesta:");
        for (int j = 0; j < cols; j++) {
            for (int i = 0; i < filas; i++) {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
