// 6. Contar dígitos de un número
// Pregunta:
// Contar la cantidad de dígitos que tiene un número entero positivo.
//Cami
using System;

class Ejercicio6
{
    public static int ContarDigitosRecursivo(int n)
    {
        if (n == 0)
            return 0;
        return 1 + ContarDigitosRecursivo(n / 10);
    }

    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"El número {n} tiene {ContarDigitosRecursivo(n)} dígitos.");
    }
}
