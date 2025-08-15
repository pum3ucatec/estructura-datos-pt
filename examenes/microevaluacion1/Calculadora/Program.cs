using System;

class Program
{
    static void Main()
    {
        int opcion;
        double num1, num2, resultado;

        do
        {
            Console.WriteLine("******** CALCULADORA CIENTÍFICA ********");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.WriteLine("7. Logaritmo (de base 10)");
            Console.WriteLine("8. Seno");
            Console.WriteLine("9. Coseno");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: // Suma
                    Console.Write("Ingresa el primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 2: // Resta
                    Console.Write("Ingresa el primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 3: // Multiplicación
                    Console.Write("Ingresa el primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 4: // División
                    Console.Write("Ingresa el primer número (no puede ser 0): ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingresa el segundo número (no puede ser 0): ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 != 0)
                        Console.WriteLine("Resultado: " + (num1 / num2));
                    else
                        Console.WriteLine("Error: no se puede dividir entre cero.");
                    break;

                case 5: // Potencia
                    Console.Write("Ingresa la base: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingresa el exponente: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 6: // Raíz cuadrada
                    Console.Write("Ingresa un número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    if (num1 >= 0)
                        Console.WriteLine("Resultado: " + Math.Sqrt(num1));
                    else
                        Console.WriteLine("Error: no se puede calcular raíz de un número negativo.");
                    break;

                case 7: // Logaritmo base 10
                    Console.Write("Ingresa un número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    if (num1 > 0)
                        Console.WriteLine("Resultado: " + Math.Log10(num1));
                    else
                        Console.WriteLine("Error: el logaritmo solo se calcula con números positivos.");
                    break;

                case 8: // Seno
                    Console.Write("Ingresa un ángulo en grados: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.Sin(num1 * Math.PI / 180); // grados a radianes
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 9: // Coseno
                    Console.Write("Ingresa un ángulo en grados: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.Cos(num1 * Math.PI / 180);
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 0:
                    Console.WriteLine("******** Saliste de la calculadora ********");
                    break;

                default:
                    Console.WriteLine("Opción inválida, intenta nuevamente.");
                    break;
            }

        } while (opcion != 0);
    }
}
