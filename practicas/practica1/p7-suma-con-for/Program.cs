
using System;


    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Console.WriteLine("Suma de 5 numeros");
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                int numero = Convert.ToInt32(Console.ReadLine());
                suma += numero;
            }

            Console.WriteLine("La suma de los numeros es: " + suma);
        }
    }
