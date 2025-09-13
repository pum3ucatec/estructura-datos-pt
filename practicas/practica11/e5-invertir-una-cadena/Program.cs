using System;
class Ejercicio5
{
    public static string Invertir(string cadena)
    {
        if (cadena.Length <= 1) // caso base
            return cadena;
        return Invertir(cadena.Substring(1)) + cadena[0]; // llamada recursiva
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Invertir Cadena ===");

        Console.Write("Ingresa una cadena: ");
        string cadena = Console.ReadLine();

        string resultado = Invertir(cadena);

        Console.WriteLine($"La cadena invertida es: {resultado}");
    }
}
