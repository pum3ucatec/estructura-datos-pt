using System;
class ejercicio_6
{
    public static int contar_digitos(int n)
    {
        if (n < 10) 
            return 1;
        return 1 + contar_digitos(n / 10);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Contar Dígitos ===");

        Console.Write("Ingresa un número: ");
        int num = int.Parse(Console.ReadLine());

        int resultado = Contar_digitos(num);

        Console.WriteLine($"El número {num} tiene {resultado} dígitos.");
    }
}