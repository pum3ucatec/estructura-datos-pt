using System;

class Ejercicio4
{
    public static double Potencia(int baseNum, int exp)
    {
        if (exp == 0) return 1; // caso base

        if (exp > 0)
        {
            return baseNum * Potencia(baseNum, exp - 1);
        }
        else
        {
            return 1.0 / Potencia(baseNum, -exp); // Maneja exponentes negativos
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Potencia Recursiva ===");

        Console.Write("Ingresa la base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el exponente: ");
        int exp = int.Parse(Console.ReadLine());

        double resultado = Potencia(baseNum, exp);

        Console.WriteLine($"{baseNum}^{exp} = {resultado}");
    }
}
