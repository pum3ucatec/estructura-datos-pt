using System;

class RotacionArreglo
{
    static void Main(string[] args)
    {
        // Arreglo de ejemplo
        int[] numeros = { 1, 2, 3, 4, 5 };
        int k = 2; // Cuántas posiciones rotar

        // Llamamos a la función que rota
        int[] resultado = Rotar(numeros, k);

        // Mostrar resultado
        Console.WriteLine("Arreglo rotado:");
        for (int i = 0; i < resultado.Length; i++)
        {
            Console.Write(resultado[i] + " ");
        }
    }

    // Método para rotar el arreglo
    static int[] Rotar(int[] arr, int k)
    {
        int n = arr.Length;
        int[] nuevo = new int[n];

        // Recorremos y colocamos cada número en su nueva posición
        for (int i = 0; i < n; i++)
        {
            int nuevaPos = (i + k) % n; // fórmula para calcular nueva posición
            nuevo[nuevaPos] = arr[i];
        }

        return nuevo;
    }
}
