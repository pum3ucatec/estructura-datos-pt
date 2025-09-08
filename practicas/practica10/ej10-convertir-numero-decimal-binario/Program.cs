using System;

class DecimalABinarioRecursiva
{
    public static string ConvertirABinario(int n)
    {
        if (n == 0) return "";
        return ConvertirABinario(n / 2) + (n % 2);
    }

    static void MostrarProceso(int n)
    {
        Console.WriteLine("Proceso de conversión a binario:");
        int valor = n;
        int paso = 1;
        while (valor > 0)
        {
            Console.WriteLine($"Paso {paso}: {valor} % 2 = {valor % 2}, {valor}/2 = {valor / 2}");
            valor /= 2;
            paso++;
        }
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ DECIMAL A BINARIO ---");
            Console.WriteLine("1. Convertir a binario con proceso");
            Console.WriteLine("2. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese número decimal: ");
                int num = int.Parse(Console.ReadLine());
                MostrarProceso(num);
                string binario = ConvertirABinario(num);
                Console.WriteLine("Resultado: " + (binario == "" ? "0" : binario));
            }
        } while (opcion != 2);
    }
}
