using System;

class ContarDigitosRecursivo
{
    public static int Contar(int n)
    {
        if (n < 10) return 1;
        return 1 + Contar(n / 10);
    }

    static void MostrarProceso(int n)
    {
        Console.WriteLine($"Número: {n}");
        int pasos = 0;
        while (n > 0)
        {
            pasos++;
            Console.WriteLine($"Paso {pasos}: {n} -> {n / 10}");
            n /= 10;
        }
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ CONTAR DÍGITOS ---");
            Console.WriteLine("1. Contar dígitos con proceso");
            Console.WriteLine("2. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese un número: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Proceso: ");
                MostrarProceso(num);
                Console.WriteLine("Resultado: " + Contar(num));
            }
        } while (opcion != 2);
    }
}
