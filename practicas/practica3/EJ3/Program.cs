using System;

class Program
{
    static void Main()
    {
        int[] Numeros = { 5, 10, 15, 20, 25 };
        
        int Suma = 0;

        for (int I = 0; I < Numeros.Length; I++)
        {
            Suma += Numeros[I];
        }

        Console.WriteLine("La Suma De Todos Los Elementos Es: " + Suma);
    }
}
