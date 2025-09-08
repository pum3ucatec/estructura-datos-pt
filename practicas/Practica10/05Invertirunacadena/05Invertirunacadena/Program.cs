//Invertir una cadena de texto.
using System;

class Program
{

    public static string InvertirCadenaRecursiva(string cadena)
    {
        if (string.IsNullOrEmpty(cadena) || cadena.Length == 1)
            return cadena;

        return InvertirCadenaRecursiva(cadena.Substring(1)) + cadena[0];
    }

  
    static void Main(string[] args)
    {
        Console.Write("Ingresa una cadena de texto: ");
        string entrada = Console.ReadLine();

        if (!string.IsNullOrEmpty(entrada))
        {
            string invertida = InvertirCadenaRecursiva(entrada);
            Console.WriteLine($"Cadena invertida: {invertida}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingresa una cadena no vacía.");
        }
    }
}
