// 4. Potencia de un número
// Pregunta:
// Calcular base^exponente (base elevado al exponente).
// Cami
using System;

class Ejercicio4
{
    public static int PotenciaRecursiva(int baseNum, int exp)
    {
        if (exp == 0)
            return 1;
        return baseNum * PotenciaRecursiva(baseNum, exp - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese la base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el exponente: ");
        int exp = int.Parse(Console.ReadLine());

        Console.WriteLine($"{baseNum}^{exp} = {PotenciaRecursiva(baseNum, exp)}");
    }
}
