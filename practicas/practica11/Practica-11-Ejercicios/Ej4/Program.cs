using System;

class Program
{
    static string InvertirCadena(string str)
    {
        if (str.Length <= 1) return str;
        return InvertirCadena(str.Substring(1)) + str[0];
    }

    static void Main()
    {
        Console.Write("Ingrese una cadena para invertir: ");
        string texto = Console.ReadLine()!;
        Console.WriteLine($"La cadena invertida es: {InvertirCadena(texto)}");
    }
}
