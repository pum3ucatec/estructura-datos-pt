using System;

class Programa3
{
    static void Main(string[] args)
    {
        int[] numeros = { 5, 10, 15, 20 };
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        Console.WriteLine("Suma: " + suma);
    }
}
