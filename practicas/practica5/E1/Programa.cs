using System;

class RotacionArreglo
{
    static void Main(string[] args)
    {
        // Arreglo de ejemplo
        int[] Numeros = { 1, 2, 3, 4, 5 };
        int K = 2; // Cuántas posiciones rotar

        // Llamamos a la función que rota
        int[] Resultado = Rotar(Numeros, K);

        // Mostrar resultado
        Console.WriteLine("Arreglo rotado:");
        for (int i = 0; i < Resultado.Length; i++)
        {
            Console.Write(Resultado[i] + " ");
        }
        Console.WriteLine();
    }

    // Método para rotar el arreglo
    static int[] Rotar(int[] Arreglo, int K)
    {
        int N = Arreglo.Length;
        int[] Nuevo = new int[N];

        // Recorremos y colocamos cada número en su nueva posición
        for (int i = 0; i < N; i++)
        {
            int NuevaPos = (i + K) % N; // fórmula para calcular nueva posición
            Nuevo[NuevaPos] = Arreglo[i];
        }

        return Nuevo;
    }
}
