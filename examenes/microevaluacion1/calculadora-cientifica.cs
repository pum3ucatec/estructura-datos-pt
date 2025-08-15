using System;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double num1, num2;

            do
            {
                Console.WriteLine("===== CALCULADORA CIENTÍFICA =====");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz Cuadrada");
                Console.WriteLine("7. Seno");
                Console.WriteLine("8. Coseno");
                Console.WriteLine("9. Logaritmo base 10");
                Console.WriteLine("10. Tangente");
                Console.WriteLine("11. Valor absoluto");
                Console.WriteLine("12. Cubo de un número");
                Console.WriteLine("13. Factorial");
                Console.WriteLine("14. Redondear número");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");
                
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1: // Suma
                        Console.Write("Ingrese el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {num1 + num2}");
                        break;

                    case 2: // Resta
                        Console.Write("Ingrese el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {num1 - num2}");
                        break;

                    case 3: // Multiplicación
                        Console.Write("Ingrese el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {num1 * num2}");
                        break;

                    case 4: // División
                        Console.Write("Ingrese el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        if (num2 != 0)
                            Console.WriteLine($"Resultado: {num1 / num2}");
                        else
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        break;

                    case 5: // Potencia
                        Console.Write("Ingrese la base: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el exponente: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Math.Pow(num1, num2)}");
                        break;

                    case 6: // Raíz Cuadrada
                        Console.Write("Ingrese un número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        if (num1 >= 0)
                            Console.WriteLine($"Resultado: {Math.Sqrt(num1)}");
                        else
                            Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
                        break;

                    case 7: // Seno
                        Console.Write("Ingrese un ángulo en radianes: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Math.Sin(num1)}");
                        break;

                    case 8: // Coseno
                        Console.Write("Ingrese un ángulo en radianes: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Math.Cos(num1)}");
                        break;

                    case 9: // Logaritmo base 10
                        Console.Write("Ingrese un número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        if (num1 > 0)
                            Console.WriteLine($"Resultado: {Math.Log10(num1)}");
                        else
                            Console.WriteLine("Error: El logaritmo solo está definido para números positivos.");
                        break;

                    case 10: // Tangente
                        Console.Write("Ingrese un ángulo en radianes: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Math.Tan(num1)}");
                        break;

                    case 11: // Valor absoluto
                        Console.Write("Ingrese un número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Math.Abs(num1)}");
                        break;

                    case 12: // Cubo
                        Console.Write("Ingrese un número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Math.Pow(num1, 3)}");
                        break;

                    case 13: // Factorial
                        Console.Write("Ingrese un número entero positivo: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        if (n >= 0)
                        {
                            long factorial = 1;
                            for (int i = 1; i <= n; i++)
                            {
                                factorial *= i;
                            }
                            Console.WriteLine($"Resultado: {factorial}");
                        }
                        else
                        {
                            Console.WriteLine("Error: El factorial solo está definido para números enteros no negativos.");
                        }
                        break;

                    case 14: // Redondear
                        Console.Write("Ingrese un número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Math.Round(num1)}");
                        break;

                    case 0:
                        Console.WriteLine("Saliendo de la calculadora...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                        break;
                }

                Console.WriteLine(); // Espacio en blanco para mejor visualización

            } while (opcion != 0);
        }
    }
}