// 10. Convertir un número decimal a binario
//Pregunta:
// Convertir un número decimal en su representación binaria.
//Cami
using System;

class Ejercicio10
{
    public static string DecimalABinarioRecursivo(int n)
    {
        if (n == 0)
            return "";
        return DecimalABinarioRecursivo(n / 2) + (n % 2).ToString();
    }

    static void Main()
    {
        Console.Write("Ingrese un número decimal: ");
        int n = int.Parse(Console.ReadLine());

        string binario = DecimalABinarioRecursivo(n);
        Console.WriteLine($"El número {n} en binario es: {(binario == "" ? "0" : binario)}");
    }
}
