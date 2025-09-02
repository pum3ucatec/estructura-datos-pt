using System;

class EliminarDuplicados
{
    static void Main(string[] args)
    {
        int[] Numeros = { 1, 1, 2, 2, 3, 4, 4 };

        Console.WriteLine("Arreglo original:");
        foreach (int Num in Numeros)
        {
            Console.Write(Num + " ");
        }
        Console.WriteLine();

        int[] SinDuplicados = QuitarDuplicados(Numeros);

        Console.WriteLine("\nArreglo sin duplicados:");
        foreach (int Num in SinDuplicados)
        {
            Console.Write(Num + " ");
        }
        Console.WriteLine();
    }

    static int[] QuitarDuplicados(int[] Arr)
    {
        if (Arr.Length == 0) return Arr;

        int N = Arr.Length;
        int J = 0;
        int[] Temp = new int[N];

        for (int I = 0; I < N - 1; I++)
        {
            if (Arr[I] != Arr[I + 1])
            {
                Temp[J++] = Arr[I];
            }
        }

        Temp[J++] = Arr[N - 1];

        int[] Resultado = new int[J];
        for (int K = 0; K < J; K++)
        {
            Resultado[K] = Temp[K];
        }

        return Resultado;
    }
}
