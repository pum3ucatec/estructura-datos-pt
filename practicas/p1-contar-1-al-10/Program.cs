using System;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Desea iniciar el contador del 1 al 10?");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta != "si")
            {
                Console.WriteLine("Adios!!! :D");
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i}");
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
