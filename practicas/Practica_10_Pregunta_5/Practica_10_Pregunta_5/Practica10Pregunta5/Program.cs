using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(InvertirCadenaRecursiva("Adan")); 
    }

    public static string InvertirCadenaRecursiva(string cadena)
    {
        return Invertir(cadena, cadena.Length - 1);
    }

    private static string Invertir(string cadena, int indice)
    {
        if (indice < 0) return "";
        return cadena[indice].ToString() + Invertir(cadena, indice - 1);
    }
}