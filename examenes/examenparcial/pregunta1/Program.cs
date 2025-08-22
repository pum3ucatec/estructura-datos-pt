using System;

class Program
{
    static void Main()
    {
        int[] numeros = {1, 2, 4, 5, 6}; // Falta el número 3
        
        Console.WriteLine("Array: [" + string.Join(", ", numeros) + "]");
        Console.WriteLine("El número faltante es: " + EncontrarNumeroFaltante(numeros));
    }
    
    public static int EncontrarNumeroFaltante(int[] numeros)
    {
        int n = numeros.Length + 1;
        int sumaTotal = n * (n + 1) / 2;
        int sumaActual = 0;
        
        foreach (int num in numeros)
        {
            sumaActual += num;
        }
        
        return sumaTotal - sumaActual;
    }
}