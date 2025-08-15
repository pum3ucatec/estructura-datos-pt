using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== CALCULADORA CIENTÍFICA ===");
        Console.WriteLine("1. Suma\n2. Resta\n3. Multiplicación\n4. División\n5. Potencia\n6. Raíz cuadrada\n7. Seno\n8. Coseno");
        Console.Write("Seleccione una operación (1-8): ");

        if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 8)
        {
            Console.WriteLine("Opción no válida.");
            return;
        }

        double resultado = opcion switch
        {
            1 => Sumar(),
            2 => Restar(),
            3 => Multiplicar(),
            4 => Dividir(),
            5 => Potencia(),
            6 => RaizCuadrada(),
            7 => Seno(),
            8 => Coseno(),
            _ => 0
        };

        Console.WriteLine($"\nResultado: {resultado}\n");
    }

    static double Sumar()
    {
        Console.Write("Ingrese dos números (separados por espacio): ");
        string[] nums = Console.ReadLine()!.Split();
        return double.Parse(nums[0]) + double.Parse(nums[1]);
    }

    static double Restar()
    {
        Console.Write("Ingrese dos números (separados por espacio): ");
        string[] nums = Console.ReadLine()!.Split();
        return double.Parse(nums[0]) - double.Parse(nums[1]);
    }

    static double Multiplicar()
    {
        Console.Write("Ingrese dos números (separados por espacio): ");
        string[] nums = Console.ReadLine()!.Split();
        return double.Parse(nums[0]) * double.Parse(nums[1]);
    }

    static double Dividir()
    {
        Console.Write("Ingrese dividendo y divisor (separados por espacio): ");
        string[] nums = Console.ReadLine()!.Split();
        if (double.Parse(nums[1]) == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero");
            return double.NaN;
        }
        return double.Parse(nums[0]) / double.Parse(nums[1]);
    }

    static double Potencia()
    {
        Console.Write("Ingrese base y exponente (separados por espacio): ");
        string[] nums = Console.ReadLine()!.Split();
        return Math.Pow(double.Parse(nums[0]), double.Parse(nums[1]));
    }

    static double RaizCuadrada()
    {
        Console.Write("Ingrese un número: ");
        double num = double.Parse(Console.ReadLine()!);
        if (num < 0)
        {
            Console.WriteLine("Error: No existe raíz de números negativos");
            return double.NaN;
        }
        return Math.Sqrt(num);
    }

    static double Seno()
    {
        Console.Write("Ingrese ángulo en radianes: ");
        double angulo = double.Parse(Console.ReadLine()!);
        return Math.Sin(angulo);
    }

    static double Coseno()
    {
        Console.Write("Ingrese ángulo en radianes: ");
        double angulo = double.Parse(Console.ReadLine()!);
        return Math.Cos(angulo);
    }
}