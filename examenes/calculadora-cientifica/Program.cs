// Calculadora cientifica quue te permita hacer 9 operaciones diferentes
using System;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- CALCULADORA CIENTÍFICA ---");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Raíz cuadrada");
                Console.WriteLine("6. Potenciación");
                Console.WriteLine("7. Logaritmo (base 10)");
                Console.WriteLine("8. Seno");
                Console.WriteLine("9. Coseno");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                double num1, num2, resultado;

                switch (opcion)
                {
                    case 1: // Suma
                        Console.Write("¿Cuántos números desea sumar?: ");
                        int cantidadSuma = int.Parse(Console.ReadLine());
                        resultado = 0;
                        for (int i = 1; i <= cantidadSuma; i++)
                        {
                            Console.Write($"Ingrese el número {i}: ");
                            resultado += double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"Resultado de la suma: {resultado}");
                        break;

                    case 2: // Resta
                        Console.Write("¿Cuántos números desea restar?: ");
                        int cantidadResta = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el número 1: ");
                        resultado = double.Parse(Console.ReadLine());
                        for (int i = 2; i <= cantidadResta; i++)
                        {
                            Console.Write($"Ingrese el número {i}: ");
                            resultado -= double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"Resultado de la resta: {resultado}");
                        break;

                    case 3: // Multiplicación
                        Console.Write("¿Cuántos números desea multiplicar?: ");
                        int cantidadMult = int.Parse(Console.ReadLine());
                        resultado = 1;
                        for (int i = 1; i <= cantidadMult; i++)
                        {
                            Console.Write($"Ingrese el número {i}: ");
                            resultado *= double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"Resultado de la multiplicación: {resultado}");
                        break;

                    case 4: // División
                        Console.Write("Ingrese el dividendo: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el divisor: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"Resultado: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        }
                        break;

                    case 5: // Raíz cuadrada
                        Console.Write("Ingrese un número: ");
                        num1 = double.Parse(Console.ReadLine());
                        if (num1 >= 0)
                        {
                            resultado = Math.Sqrt(num1);
                            Console.WriteLine($"Resultado: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede calcular la raíz de un número negativo.");
                        }
                        break;

                    case 6: // Potenciación
                        Console.Write("Ingrese la base: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el exponente: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = Math.Pow(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 7: // Logaritmo base 10
                        Console.Write("Ingrese un número positivo: ");
                        num1 = double.Parse(Console.ReadLine());
                        if (num1 > 0)
                        {
                            resultado = Math.Log10(num1);
                            Console.WriteLine($"Resultado: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error: El logaritmo solo está definido para números positivos.");
                        }
                        break;

                    case 8: // Seno
                        Console.Write("Ingrese un ángulo en grados: ");
                        num1 = double.Parse(Console.ReadLine());
                        resultado = Math.Sin(num1 * Math.PI / 180);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 9: // Coseno
                        Console.Write("Ingrese un ángulo en grados: ");
                        num1 = double.Parse(Console.ReadLine());
                        resultado = Math.Cos(num1 * Math.PI / 180);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 0:
                        Console.WriteLine("Saliendo de la calculadora...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }

            } while (opcion != 0);
        }
    }
}

