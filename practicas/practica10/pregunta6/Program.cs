using System;

class Pregunta6
{
    static void Main()
    {
        int[] numeros = { 123, 0, 7, 987654, 456 };

        foreach (int num in numeros)
        {
            int digitos = ContarDigitosRecursivo(num);
            Console.WriteLine($"Número: {num}, Dígitos: {digitos}");
        }
    }

    public static int ContarDigitosRecursivo(int n)
    {
        // Caso base: si el número tiene un solo dígito
        if (n < 10)
            return 1;

        // Parte recursivo: se elimina el último dígito dividiendo entre 10
        return 1 + ContarDigitosRecursivo(n / 10);
    }
}
