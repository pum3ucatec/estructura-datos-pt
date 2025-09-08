using System;

class FactorialRecursivo
{
    public static int CalcularFactorial(int n)
    {
        if (n == 0) return 1;
        return n * CalcularFactorial(n - 1);
    }

    static void MostrarProceso(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i);
            if (i < n) Console.Write(" * ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ FACTORIAL ---");
            Console.WriteLine("1. Calcular factorial con proceso");
            Console.WriteLine("2. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese un número: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Proceso: ");
                MostrarProceso(num);
                Console.WriteLine("Resultado: " + CalcularFactorial(num));
            }
        } while (opcion != 2);
    }
}
