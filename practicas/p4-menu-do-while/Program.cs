using System;


    class Program
    {
        static void Main

            (string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Menu de opciones:");
                Console.WriteLine("1.Sumar");
                Console.WriteLine("2.Restar");
                Console.WriteLine("3.Multiplicar");
                Console.WriteLine("4.Dividir");
                Console.WriteLine("5.Salir");
                Console.WriteLine("Seleccione una opcion:");
                opcion = Convert.ToInt16(Console.ReadLine());
                int num1, num2, resultado;
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el primer numero:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el primer numero:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el primer numero:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el primer numero:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Complex Infinity");
                        }
                        else
                        {

                            resultado = num1 / num2;
                            Console.WriteLine($"Resultado: {resultado}");
                        }
                        break;
                }

            } while (opcion != 5);
        }
    }
