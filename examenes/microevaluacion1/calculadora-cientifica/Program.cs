﻿using System;


    class Program
    {
        static void Main (string[] args)
        {
            int opcion;
        do
        {
            Console.WriteLine("Menu de opciones:");
            Console.WriteLine("1.Sumar");
            Console.WriteLine("2.Restar");
            Console.WriteLine("3.Multiplicar");
            Console.WriteLine("4.Dividir");
            Console.WriteLine("5.Raíz cuadrada");
            Console.WriteLine("6.Elevado");
            Console.WriteLine("7.Seno");
            Console.WriteLine("0.Salir");
            Console.WriteLine("Seleccione una opcion:");
            opcion = Convert.ToInt16(Console.ReadLine());
            double num1, num2, resultado;
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el primer numero:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 2:
                    Console.WriteLine("Ingrese el primer numero:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el primer numero:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 4:
                    Console.WriteLine("Ingrese el primer numero:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero:");
                    num2 = Convert.ToDouble(Console.ReadLine());
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
                case 5:
                    Console.WriteLine("Ingrese un numero para calcular su raiz cuadrada:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    if (num1 < 0)
                    {
                        Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
                    }
                    else
                    {
                        resultado = Math.Sqrt(num1);
                        Console.WriteLine($"Raíz cuadrada: {resultado}");
                    }
                    break;
                case 6:
                    Console.WriteLine("Ingrese un número base:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el exponente:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine($"Resultado de {num1} elevado a {num2}: {resultado}");
                    break;
                case 7:
                    Console.WriteLine("Ingrese un ángulo en grados para calcular su seno:");
                    double anguloSeno = Convert.ToDouble(Console.ReadLine());
                    double seno = Math.Sin(anguloSeno * Math.PI / 180);
                    Console.WriteLine($"Seno: {seno}");
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }
                

            } while (opcion != 0);
        }
    }