using System;

class PotenciaRecursiva
{
    public static int CalcularPotencia(int baseNum, int exp)
    {
        if (exp == 0) return 1;
        return baseNum * CalcularPotencia(baseNum, exp - 1);
    }

    static void MostrarProceso(int baseNum, int exp)
    {
        for (int i = 1; i <= exp; i++)
        {
            Console.Write(baseNum);
            if (i < exp) Console.Write(" * ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ POTENCIA ---");
            Console.WriteLine("1. Calcular potencia con proceso");
            Console.WriteLine("2. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese la base: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el exponente: ");
                int e = int.Parse(Console.ReadLine());

                Console.Write("Proceso: ");
                MostrarProceso(b, e);
                Console.WriteLine("Resultado: " + CalcularPotencia(b, e));
            }
        } while (opcion != 2);
    }
}
