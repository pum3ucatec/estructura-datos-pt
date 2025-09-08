using System;

class InvertirCadenaRecursiva
{
    public static string Invertir(string cadena)
    {
        if (cadena.Length <= 1) return cadena;
        return Invertir(cadena.Substring(1)) + cadena[0];
    }

    static void MostrarProceso(string cadena)
    {
        Console.WriteLine($"Cadena original: {cadena}");
        string acumulado = "";
        for (int i = cadena.Length - 1; i >= 0; i--)
        {
            acumulado += cadena[i];
            Console.WriteLine("Paso: " + acumulado);
        }
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ INVERTIR CADENA ---");
            Console.WriteLine("1. Invertir cadena con proceso");
            Console.WriteLine("2. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese una cadena: ");
                string cad = Console.ReadLine();
                Console.WriteLine("Proceso: ");
                MostrarProceso(cad);
                Console.WriteLine("Resultado: " + Invertir(cad));
            }
        } while (opcion != 2);
    }
}

