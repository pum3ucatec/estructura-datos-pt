//2. Suma de los primeros N números naturales
// Pregunta:
// Calcular la suma de los primeros n números naturales.
// Cami
using System;

class Ejercicio2
{
    public static int SumaRecursiva(int n)
    {
        if (n == 0)
            return 0;
        return n + SumaRecursiva(n - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"La suma de los primeros {n} números es: {SumaRecursiva(n)}");
    }
}

