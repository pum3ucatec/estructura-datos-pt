using System;

class InvertirCadenaRecursiva
{
    static string InvertirCadena(string s)
    {
        if (s.Length <= 1) return s;
        return InvertirCadena(s.Substring(1)) + s[0];
    }

    static void Main()
    {
        Console.Write("Ingrese una cadena: ");
        string cadena = Console.ReadLine()!;
        Console.WriteLine($"Cadena invertida: {InvertirCadena(cadena)}");
    }
}
