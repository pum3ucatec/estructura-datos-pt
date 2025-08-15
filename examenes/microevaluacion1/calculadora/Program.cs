using System;

class CalculadoraCientifica
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n===== CALCULADORA CIENTÍFICA =====");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.WriteLine("7. Factorial");
            Console.WriteLine("8. Valor absoluto");
            Console.WriteLine("9. Porcentaje");
            Console.WriteLine("0. Salir");
            Console.Write("Elija una opción: ");
            
            opcion = int.Parse(Console.ReadLine());

            double num1, num2, resultado;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 2:
                    Console.Write("Ingrese el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 3:
                    Console.Write("Ingrese el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 4:
                    Console.Write("Ingrese el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre 0.");
                    }
                    break;

                case 5:
                    Console.Write("Ingrese la base: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el exponente: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 6:
                    Console.Write("Ingrese un número: ");
                    num1 = double.Parse(Console.ReadLine());
                    if (num1 >= 0)
                    {
                        resultado = Math.Sqrt(num1);
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede sacar raíz cuadrada de un número negativo.");
                    }
                    break;

                case 7:
                    Console.Write("Ingrese un número entero: ");
                    int n = int.Parse(Console.ReadLine());
                    if (n >= 0)
                    {
                        long fact = 1;
                        for (int i = 1; i <= n; i++)
                        {
                            fact *= i;
                        }
                        Console.WriteLine("Resultado: " + fact);
                    }
                    else
                    {
                        Console.WriteLine("Error: No existe factorial de números negativos.");
                    }
                    break;

                case 8:
                    Console.Write("Ingrese un número: ");
                    num1 = double.Parse(Console.ReadLine());
                    resultado = Math.Abs(num1);
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 9:
                    Console.Write("Ingrese el número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el porcentaje: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = (num1 * num2) / 100;
                    Console.WriteLine(num2 + "% de " + num1 + " es: " + resultado);
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    Console.WriteLine("Adiós amiguito");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}
