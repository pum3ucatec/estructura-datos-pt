using System;

class PotenciaRecursiva
{
    static int Potencia(int baseNum, int exp)
    {
        if (exp == 0) return 1;
        return baseNum * Potencia(baseNum, exp - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese la base: ");
        int baseNum = int.Parse(Console.ReadLine()!);
        Console.Write("Ingrese el exponente: ");
        int exp = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Resultado: {Potencia(baseNum, exp)}");
    }
}
