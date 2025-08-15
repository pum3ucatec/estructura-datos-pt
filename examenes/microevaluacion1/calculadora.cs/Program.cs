using System;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("===== CALCULADORA CIENTÍFICA =====");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("7. Seno");
                Console.WriteLine("8. Coseno");
                Console.WriteLine("9. Tangente");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");
                
                opcion = Convert.ToInt32(Console.ReadLine());

                double num1, num2, resultado;

                switch (opcion)
                {
                    case 1: // Suma
                        Console.Write("Ingrese el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 2: // Resta
                        Console.Write("Ingrese el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 3: // Multiplicación
                        Console.Write("Ingrese el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 4: // División
                        Console.Write("Ingrese el dividendo: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el divisor: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"Resultado: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre 0.");
                        }
                        break;

                    case 5: // Potencia
                        Console.Write("Ingrese la base: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el exponente: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Pow(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 6: // Raíz cuadrada
                        Console.Write("Ingrese un número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        if (num1 >= 0)
                        {
                            resultado = Math.Sqrt(num1);
                            Console.WriteLine($"Resultado: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede calcular raíz cuadrada de un número negativo.");
                        }
                        break;

                    case 7: // Seno
                        Console.Write("Ingrese el ángulo en grados: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Sin(num1 * Math.PI / 180); // Convertir a radianes
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 8: // Coseno
                        Console.Write("Ingrese el ángulo en grados: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Cos(num1 * Math.PI / 180);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 9: // Tangente
                        Console.Write("Ingrese el ángulo en grados: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Tan(num1 * Math.PI / 180);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 0:
                        Console.WriteLine("Saliendo de la calculadora...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 0);
        }
    }
}
