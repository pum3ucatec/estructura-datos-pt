using System;

class Program
{
    // Función recursiva para calcular la potencia
    public static int PotenciaRecursiva(int baseNum, int exp)
    {
        // Caso base
        if (exp == 0)
            return 1;

        // Caso recursivo
        return baseNum * PotenciaRecursiva(baseNum, exp - 1);
    }

    // Punto de entrada del programa
    static void Main(string[] args)
    {
        Console.Write("Ingrese la base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el exponente: ");
        int exp = int.Parse(Console.ReadLine());

        int resultado = PotenciaRecursiva(baseNum, exp);

        Console.WriteLine($"{baseNum}^{exp} = {resultado}");
    }
}
