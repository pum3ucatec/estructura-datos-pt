using System;

class FibonacciRecursivo
{
    public static int CalcularFibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
    }

    static void MostrarProceso(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            Console.Write(CalcularFibonacci(i));
            if (i < n) Console.Write(", ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ FIBONACCI ---");
            Console.WriteLine("1. Calcular Fibonacci con proceso");
            Console.WriteLine("2. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese la posición n: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Proceso: ");
                MostrarProceso(num);
                Console.WriteLine("Resultado (n-esimo término): " + CalcularFibonacci(num));
            }
        } while (opcion != 2);
    }
}
