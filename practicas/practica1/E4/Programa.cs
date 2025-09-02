using System;

class MenuInteractivo
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            MostrarMenu();
            Console.Write("ELIGE UNA OPCIÓN: ");
            opcion = int.Parse(Console.ReadLine());

            ProcesarOpcion(opcion);

        } while (opcion != 3);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
        Console.WriteLine("1. SALUDAR");
        Console.WriteLine("2. SUMAR DOS NÚMEROS");
        Console.WriteLine("3. SALIR");
    }

    static void ProcesarOpcion(int opcion)
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine("¡HOLA! QUE TENGAS UN BUEN DÍA.");
                break;

            case 2:
                Console.Write("INGRESE PRIMER NÚMERO: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("INGRESE SEGUNDO NÚMERO: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"RESULTADO: {num1 + num2}");
                break;

            case 3:
                Console.WriteLine("SALIENDO DEL PROGRAMA...");
                break;

            default:
                Console.WriteLine("OPCIÓN NO VÁLIDA.");
                break;
        }
    }
}
