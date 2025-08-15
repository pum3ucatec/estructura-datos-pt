using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para ver si es primo:");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= numero; i++)
            {
                if (numero % i == 0 && i != numero)
                {
                    Console.WriteLine("El numero no es primo.");
                    return;
                }
            }
                Console.WriteLine("El numero es primo.");
            }
        }

