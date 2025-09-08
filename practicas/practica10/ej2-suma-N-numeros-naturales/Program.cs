using System;

class SumaRecursiva
{
    public static int CalcularSuma(int n)
    {
        if (n == 0) return 0;
        return n + CalcularSuma(n - 1);
    }

    static void MostrarProceso(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i);
            if (i < n) Console.Write(" + ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ SUMA ---");
            Console.WriteLine("1. Calcular suma con proceso");
            Console.WriteLine("2. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese un número: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Proceso: ");
                MostrarProceso(num);
                Console.WriteLine("Resultado: " + CalcularSuma(num));
            }
        } while (opcion != 2);
    }
}
