using System;

class Operaciones1_1
{
    static void Main()
    {
        int num_1 = 0, num_2 = 0, resultado = 0;

        Console.WriteLine();
        Console.WriteLine("Bienvenido a la calculadora");
        Console.WriteLine();

        Console.Write("Ingresa tu primer valor: ");
        num_1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa tu segundo valor: ");
        num_2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Elige qué operación deseas realizar");
        Console.WriteLine(" 1. SUMAR ");
        Console.WriteLine(" 2. RESTAR ");
        Console.WriteLine(" 3. MULTIPLICAR ");
        Console.WriteLine(" 4. DIVIDIR ");
        Console.WriteLine(" 5. SENO (de num_1)");
        Console.WriteLine(" 6. COSENO (de num_1)");
        Console.WriteLine(" 7. TANGENTE (de num_1)");
        Console.WriteLine(" 8. RAÍZ CUADRADA (de num_1)");
        Console.Write("Elige una opción (1-8): ");
        Console.WriteLine();

        int parametro = Convert.ToInt32(Console.ReadLine());

        switch (parametro)
        {
            case 1:
                resultado = num_1 + num_2;
                Console.WriteLine("El resultado es: " + resultado);
                break;
            case 2:
                resultado = num_1 - num_2;
                Console.WriteLine("El resultado es: " + resultado);
                break;
            case 3:
                resultado = num_1 * num_2;
                Console.WriteLine("El resultado es: " + resultado);
                break;
            case 4:
                if (num_2 != 0)
                {
                    resultado = num_1 / num_2;
                    Console.WriteLine("El resultado es: " + resultado);
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
                break;
            case 5:
                Console.WriteLine("El seno de " + num_1 + " es: " + Math.Sin(num_1 * Math.PI / 180));
                break;
            case 6:
                Console.WriteLine("El coseno de " + num_1 + " es: " + Math.Cos(num_1 * Math.PI / 180));
                break;
            case 7:
                Console.WriteLine("La tangente de " + num_1 + " es: " + Math.Tan(num_1 * Math.PI / 180));
                break;
            case 8:
                if (num_1 >= 0)
                {
                    Console.WriteLine("La raíz cuadrada de " + num_1 + " es: " + Math.Sqrt(num_1));
                }
                else
                {
                    Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
                }
                break;
            default:
                Console.WriteLine("Error, la opción no existe");
            break;
        }
    }

}