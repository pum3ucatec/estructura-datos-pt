using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arreglo = { 1, 2, 3, 4, 5 };
        int posiciones = 2;

        Console.WriteLine("Arreglo original: " + string.Join(", ", arreglo));
        RotarArreglo(arreglo, posiciones);
        Console.WriteLine("Arreglo rotado: " + string.Join(", ", arreglo));
    }

    static void RotarArreglo(int[] arreglo, int posiciones)
    {
        int n = arreglo.Length;
        posiciones = posiciones % n;
        Reverse(arreglo, 0, n - 1);
        Reverse(arreglo, 0, posiciones - 1);
        Reverse(arreglo, posiciones, n - 1);
    }

    static void Reverse(int[] arreglo, int inicio, int fin)
    {
        while (inicio < fin)
        {
            int temp = arreglo[inicio];
            arreglo[inicio] = arreglo[fin];
            arreglo[fin] = temp;
            inicio++;
            fin--;
        }
    }

}
