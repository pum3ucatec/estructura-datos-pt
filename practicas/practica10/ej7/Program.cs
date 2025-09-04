using System;

class Program
{
    public static int MCDRecursivo(int a, int b)
    {
        if (b == 0) // Caso base
            return a;
        else
            return MCDRecursivo(b, a % b); // Paso recursivo
    }

    static void Main(string[] args)
    {
        Console.WriteLine(" --Calcular el MCD RECURSIVO-- ");  
            
        Console.Write("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = MCDRecursivo(num1, num2);

        Console.WriteLine($"El MCD de {num1} y {num2} ess: {resultado}");
    }
}
