using System;

class Ejercicio9
{
    static void Main()
    {
        int[,] ejemplo = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
        Console.WriteLine("Ejemplo:");
        ImprimirEspiral(ejemplo);

        Console.WriteLine("\nAhora ingresa filas y columnas:");
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

        ImprimirEspiral(matriz);
    }

    static void ImprimirEspiral(int[,] m)
    {
        int top = 0, bottom = m.GetLength(0) - 1;
        int left = 0, right = m.GetLength(1) - 1;
        Console.Write("Espiral: [");
        bool primero = true;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++) Mostrar(m[top, i], ref primero);
            top++;
            for (int i = top; i <= bottom; i++) Mostrar(m[i, right], ref primero);
            right--;
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--) Mostrar(m[bottom, i], ref primero);
                bottom--;
            }
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--) Mostrar(m[i, left], ref primero);
                left++;
            }
        }
        Console.WriteLine("]");
    }

    static void Mostrar(int valor, ref bool primero)
    {
        if (!primero) Console.Write(", ");
        Console.Write(valor);
        primero = false;
    }
}