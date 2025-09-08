using System;

    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Ingrese un numero positivo:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("¡¡¡El numero debe ser positivo!!!");
                }
                else
                {
                    Console.WriteLine($"El numero es: {num}");
                }
            }

            while (num < 0);
        }
    }
