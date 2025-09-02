using System;

class SumaHastaN
{
    static void Main(string[] args)
    {
        Console.Write("INGRESE UN NÚMERO N: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = CalcularSuma(numero);

        Console.WriteLine($"LA SUMA DE 1 HASTA {numero} ES: {resultado}");
    }

    static int CalcularSuma(int n)
    {
        int suma = 0;
        int contador = 1;

        while (contador <= n)
        {
            suma += contador;
            contador++;
        }

        return suma;
    }
}
