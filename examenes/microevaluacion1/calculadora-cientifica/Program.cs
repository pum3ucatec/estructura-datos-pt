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
            int num1, num2;
            double num3, num4, resultado;
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¿Cuantos numeros desea sumar?:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    resultado = 0; 
                    for (int i = 1; i <= num1; i++)
                    {
                        Console.WriteLine($"Ingrese el numero {i}:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado += num2;
                    }
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 2:
                   Console.WriteLine("¿Cuantos numeros desea restar?:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    resultado = 0;
                    Console.WriteLine("Ingrese el primer numero:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resultado = num2;
                    int con = 2;
                    for (int i = 1; i < num1; i++)
                    {
                        Console.WriteLine($"Ingrese el numero {con}:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado -= num2;
                        con++;
                    }
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 3:
                    Console.WriteLine("¿Cuantos numeros desea multiplicarr?:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    resultado = 1;
                    for (int i = 1; i <= num1; i++)
                    {
                        Console.WriteLine($"Ingrese el numero {i}:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado *= num2;
                    }
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

                        resultado = (double)num1 / num2;
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    break;
                case 5:
                    Console.WriteLine("Ingrese un numero para calcular su raiz cuadrada:");
                    num3 = Convert.ToDouble(Console.ReadLine());
                    if (num3 < 0)
                    {
                        Console.WriteLine("Error: Math");
                    }
                    else
                    {
                        resultado = Math.Sqrt(num3);
                        Console.WriteLine($"Raíz cuadrada: {resultado}");
                    }
                    break;
                case 6:
                    Console.WriteLine("Ingrese un número base:");
                    num3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el exponente:");
                    num4 = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.Pow(num3, num4);
                    Console.WriteLine($"Resultado de {num3} elevado a {num4}: {resultado}");
                    break;
                case 7:
                    Console.WriteLine("Ingrese un ángulo en grados para calcular su seno:");
                    num3 = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.Sin(num3 * Math.PI / 180);
                    Console.WriteLine($"Seno: {resultado}");
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