// Calculadora cientifca Suma, Resta, Multiplicacion, Division, Ptencia, Raiz cuadrada, 
// Seno, Coseno, Tangente y por ultimo la opcion de salir.
// Camilaa
using System;

class CalculadoraCientifica
{
    static void Main()
    {
        Console.WriteLine("Calculadora Científica");
        Console.WriteLine("---------------------");
        Console.WriteLine("Operaciones disponibles:");
        Console.WriteLine("1. Suma (+)");
        Console.WriteLine("2. Resta (-)");
        Console.WriteLine("3. Multiplicación (*)");
        Console.WriteLine("4. División (/)");
        Console.WriteLine("5. Potencia (x^y)");
        Console.WriteLine("6. Raíz cuadrada (√)");
        Console.WriteLine("7. Seno (sin)");
        Console.WriteLine("8. Coseno (cos)");
        Console.WriteLine("9. Tangente (tan)");
        Console.WriteLine("0. Salir");
        
        bool continuar = true;
        
        while (continuar)
        {
            Console.Write("\nSeleccione una operación (1-9) o 0 para salir: ");
            string opcion = Console.ReadLine();
            
            switch (opcion)
            {
                case "1":
                    Suma();
                    break;
                case "2":
                    Resta();
                    break;
                case "3":
                    Multiplicacion();
                    break;
                case "4":
                    Division();
                    break;
                case "5":
                    Potencia();
                    break;
                case "6":
                    RaizCuadrada();
                    break;
                case "7":
                    Seno();
                    break;
                case "8":
                    Coseno();
                    break;
                case "9":
                    Tangente();
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
        
        Console.WriteLine("\nGracias por usar la calculadora. ¡Hasta pronto!");
    }
    
    static void Suma()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double resultado = num1 + num2;
        Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
    }
    
    static void Resta()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double resultado = num1 - num2;
        Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
    }
    
    static void Multiplicacion()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double resultado = num1 * num2;
        Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
    }
    
    static void Division()
    {
        Console.Write("Ingrese el numerador: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el denominador: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        if (num2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
        else
        {
            double resultado = num1 / num2;
            Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
        }
    }
    
    static void Potencia()
    {
        Console.Write("Ingrese la base: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el exponente: ");
        double exponente = Convert.ToDouble(Console.ReadLine());
        double resultado = Math.Pow(baseNum, exponente);
        Console.WriteLine($"Resultado: {baseNum}^{exponente} = {resultado}");
    }
    
    static void RaizCuadrada()
    {
        Console.Write("Ingrese el número: ");
        double num = Convert.ToDouble(Console.ReadLine());
        
        if (num < 0)
        {
            Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
        }
        else
        {
            double resultado = Math.Sqrt(num);
            Console.WriteLine($"Resultado: √{num} = {resultado}");
        }
    }
    
    static void Seno()
    {
        Console.Write("Ingrese el ángulo en grados: ");
        double angulo = Convert.ToDouble(Console.ReadLine());
        double radianes = angulo * Math.PI / 180;
        double resultado = Math.Sin(radianes);
        Console.WriteLine($"Resultado: sin({angulo}°) = {resultado}");
    }
    
    static void Coseno()
    {
        Console.Write("Ingrese el ángulo en grados: ");
        double angulo = Convert.ToDouble(Console.ReadLine());
        double radianes = angulo * Math.PI / 180;
        double resultado = Math.Cos(radianes);
        Console.WriteLine($"Resultado: cos({angulo}°) = {resultado}");
    }
    
    static void Tangente()
    {
        Console.Write("Ingrese el ángulo en grados: ");
        double angulo = Convert.ToDouble(Console.ReadLine());
        double radianes = angulo * Math.PI / 180;
        
        // Verificar si el coseno es cero (tangente indefinida)
        if (Math.Cos(radianes) == 0)
        {
            Console.WriteLine("Error: La tangente no está definida para este ángulo.");
        }
        else
        {
            double resultado = Math.Tan(radianes);
            Console.WriteLine($"Resultado: tan({angulo}°) = {resultado}");
        }
    }
}
