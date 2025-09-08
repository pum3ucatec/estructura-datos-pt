using System;

class Ejercicio6
{
    static void Main()
    {
        int[,] ejemplo = { {1, 2, 3}, {4, 5, 6} };
        Console.WriteLine("Ejemplo:");
        MostrarTranspuesta(ejemplo);

        Console.WriteLine("\nAhora ingresa filas y columnas de tu matriz:");
        Console.Write("Filas: ");
        int filas = int.Parse(Console.ReadLine());
        Console.Write("Columnas: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matriz = new int[filas, cols];
        Console.WriteLine("Ingresa los elementos fila por fila:");
        for (int i = 0; i < filas; i++)
        {
            string[] linea = Console.ReadLine().Split(' ');
            for (int j = 0; j < cols; j++)
                matriz[i, j] = int.Parse(linea[j]);
        }

        MostrarTranspuesta(matriz);
    }

    static void MostrarTranspuesta(int[,] m)
    {
        Console.WriteLine("Matriz original:");
        Imprimir(m);

        int[,] t = new int[m.GetLength(1), m.GetLength(0)];
        for (int i = 0; i < m.GetLength(0); i++)
            for (int j = 0; j < m.GetLength(1); j++)
                t[j, i] = m[i, j];

        Console.WriteLine("Transpuesta:");
        Imprimir(t);
    }

    static void Imprimir(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                Console.Write(m[i, j] + " ");
            Console.WriteLine();
        }
    }
}
