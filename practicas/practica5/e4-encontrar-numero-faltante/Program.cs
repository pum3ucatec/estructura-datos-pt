using System;

class NumeroFaltante
{
    public static int EncontrarNumeroFaltante(int[] arr)
    {
        int n = arr.Length + 1;
        int sumaEsperada = n * (n + 1) / 2;
        int sumaActual = 0;
        
        foreach (int num in arr)
        {
            sumaActual += num;
        }
        
        return sumaEsperada - sumaActual;
    }

    public static void Main()
    {
        int[] arr = {1, 2, 4, 5, 6};
        Console.WriteLine("Arreglo: " + string.Join(", ", arr));
        
        int faltante = EncontrarNumeroFaltante(arr);
        Console.WriteLine("Número faltante: " + faltante);
    }
}