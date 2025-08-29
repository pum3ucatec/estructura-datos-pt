using System;

public class Program
{
    // Función factorial iterativa (con while)
    public static long FactorialIterativo(int n)
    {
        if (n < 0)
        {
            return -1; // Indica un error para un número negativo
        }
        if (n == 0)
        {
            return 1;
        }

        long resultado = 1;
        int i = 1;
        while (i <= n)
        {
            resultado *= i;
            i++;
        }
        return resultado;
    }

    // Función factorial recursiva
    public static long FactorialRecursivo(int n)
    {
        if (n < 0)
        {
            return -1; // Indica un error
        }
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * FactorialRecursivo(n - 1);
    }

    // Método principal del programa
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- Menú de Factoriales ---");
            Console.WriteLine("1. Calcular Factorial con bucle while");
            Console.WriteLine("2. Calcular Factorial con recursividad");
            Console.WriteLine("3. Salir");
            Console.Write("\nSeleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "3")
            {
                break;
            }

            Console.Write("Ingrese un número entero no negativo: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero < 0)
                {
                    Console.WriteLine("Error: El número debe ser no negativo.");
                }
                else
                {
                    long resultado;
                    switch (opcion)
                    {
                        case "1":
                            resultado = FactorialIterativo(numero);
                            Console.WriteLine($"\nEl factorial de {numero} (Iterativo) es: {resultado}");
                            break;
                        case "2":
                            resultado = FactorialRecursivo(numero);
                            Console.WriteLine($"\nEl factorial de {numero} (Recursivo) es: {resultado}");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        Console.WriteLine("\nSaliendo del programa. ¡Hasta la próxima!");
    }
}