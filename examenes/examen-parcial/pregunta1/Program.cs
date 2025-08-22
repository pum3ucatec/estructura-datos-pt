using System;

class pregunta1 {
    static void Main()
    {
        Console.Write("Ingrese el número de filas de la matriz: ");
        int num_filas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de columnas de la matriz: ");
        int num_columnas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[num_filas, num_columnas];

        Console.WriteLine("Ingrese los elementos de la matriz:");
        for (int i = 0; i < num_filas; i++)
        {
            for (int j = 0; j < num_columnas; j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Recorrido en espiral:");
        ImprimirEspiral(matriz, num_filas, num_columnas);
    }

    static void ImprimirEspiral(int[,] matriz, int num_filas, int num_columnas)
    {
        int inicioFila = 0, inicioCol = 0;

        while (inicioFila < num_filas && inicioCol < num_columnas)
        {
            for (int i = inicioCol; i < num_columnas; i++)
                Console.Write(matriz[inicioFila, i] + " ");
            inicioFila++;

            for (int i = inicioFila; i < num_filas; i++)
                Console.Write(matriz[i, num_columnas - 1] + " ");
            num_columnas--;

            if (inicioFila < num_filas)
            {
                for (int i = num_columnas - 1; i >= inicioCol; i--)
                    Console.Write(matriz[num_filas - 1, i] + " ");
                num_filas--;
            }

            if (inicioCol < num_columnas)
            {
                for (int i = num_filas - 1; i >= inicioFila; i--)
                    Console.Write(matriz[i, inicioCol] + " ");
                inicioCol++;
            }
        }
    }
}
