using System;

class Program
{
    // Función recursiva para calcular el McdRecursivo
    public static int McdRecursivo(int a, int b)
    {
        // Caso base: si b es 0, el resultado es a
        if (b == 0)
            return a;

        // Llamada recursiva: el McdRecursivo se repite con (b, a % b)
        return McdRecursivo(b, a % b);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("*** Calcular MCD de dos números ***");

        Console.Write("Ingresa el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = McdRecursivo(num1, num2);

        Console.WriteLine($"El MCD de {num1} y {num2} es: {resultado}");
    }
}
