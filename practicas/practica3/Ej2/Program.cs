using System;

class Program
{
    static void Main()
    {
        int[] Numeros = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

        for (int I = 0; I < Numeros.Length; I++)
        {
            Console.WriteLine("Elemento En Posicion " + I + ": " + Numeros[I]);
        }
    }
}


