using System;
class ejercicio_4
{
    public static int potencia(int baseNum, int exp)
    {
        if (exp == 0) return 1;
        return baseNum * potencia(baseNum, exp - 1);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Potencia ===");

        Console.Write("Ingresa la base: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el exponente: ");
        int e = int.Parse(Console.ReadLine());

        int resultado = Potencia(b, e);

        Console.WriteLine($"{b}^{e} = {resultado}");
    }
}