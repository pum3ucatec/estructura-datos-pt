using System;
class Ejercicio3
{
    static void Main()
    {
        int[] valores = { 5, 10, 15, 20 };
        int suma = 0;

        for (int i = 0; i < valores.Length; i++)
        {
            suma += valores[i];
        }

        Console.WriteLine("Suma: " + suma);

    }
}