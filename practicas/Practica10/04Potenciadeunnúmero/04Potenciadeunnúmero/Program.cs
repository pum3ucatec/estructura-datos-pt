// Calcular base^exponente (base elevado al exponente).
using System;

class Program
{

    public static int PotenciaRecursiva(int baseNum, int exp)
    {
        if (exp < 0)
            throw new ArgumentException("El exponente debe ser no negativo.");

        if (exp == 0)
            return 1;

        return baseNum * PotenciaRecursiva(baseNum, exp - 1);
    }

  
    static void Main(string[] args)
    {
        Console.Write("Ingresa la base: ");
        bool baseValida = int.TryParse(Console.ReadLine(), out int baseNum);

        Console.Write("Ingresa el exponente (no negativo): ");
        bool expValido = int.TryParse(Console.ReadLine(), out int exp);

        if (baseValida && expValido && exp >= 0)
        {
            int resultado = PotenciaRecursiva(baseNum, exp);
            Console.WriteLine($"{baseNum}^{exp} = {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Asegúrate de ingresar números enteros y que el exponente sea no negativo.");
        }
    }
}
