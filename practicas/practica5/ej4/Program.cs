using System;

class Ejercicio4
{
    static void Main()
    {
        Console.WriteLine("Ejemplo: [1, 2, 4, 5, 6]");
        int[] ejemplo = { 1, 2, 4, 5, 6 };
        MostrarFaltante(ejemplo);

        Console.WriteLine("\nAhora ingresa tus datos (separados por espacios):");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);
        MostrarFaltante(arr);
    }

    static void MostrarFaltante(int[] arr)
    {
        Array.Sort(arr);
        int min = arr[0];
        int max = arr[arr.Length - 1];
        int sumaEsperada = (max * (max + 1)) / 2 - ((min - 1) * min) / 2;
        int sumaReal = 0;
        foreach (int num in arr) sumaReal += num;
        int faltante = sumaEsperada - sumaReal;

        Console.WriteLine("Arreglo: [" + string.Join(", ", arr) + "]");
        if (faltante == 0)
            Console.WriteLine("No falta ningún número en el rango.");
        else
            Console.WriteLine("Número faltante: " + faltante);
    }
}