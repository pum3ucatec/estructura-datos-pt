using System;

class MCDRecursivo
{
    public static int CalcularMCD(int a, int b)
    {
        if (b == 0) return a;
        return CalcularMCD(b, a % b);
    }

    static void MostrarProceso(int a, int b)
    {
        Console.WriteLine($"Proceso del MCD entre {a} y {b}:");
        while (b != 0)
        {
            Console.WriteLine($"{a} % {b} = {a % b}");
            int temp = b;
            b = a % b;
            a = temp;
        }
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ MCD ---");
            Console.WriteLine("1. Calcular MCD con proceso");
            Console.WriteLine("2. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese el primer número: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Proceso: ");
                MostrarProceso(a, b);
                Console.WriteLine("Resultado: " + CalcularMCD(a, b));
            }
        } while (opcion != 2);
    }
}

