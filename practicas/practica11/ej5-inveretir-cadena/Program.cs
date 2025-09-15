//5. Invertir una cadena
// Pregunta:
// Invertir una cadena de texto.
//Cami
using System;

class Ejercicio5
{
    public static string InvertirCadenaRecursiva(string cadena)
    {
        if (cadena.Length <= 1)
            return cadena;
        return InvertirCadenaRecursiva(cadena.Substring(1)) + cadena[0];
    }

    static void Main()
    {
        Console.Write("Ingrese una cadena: ");
        string texto = Console.ReadLine();

        Console.WriteLine($"La cadena invertida es: {InvertirCadenaRecursiva(texto)}");
    }
}
 
