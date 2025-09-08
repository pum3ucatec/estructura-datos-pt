using System;

    class Program
    {
        static void Main(string[] args)
        {
            int contador = 10;
            while (contador >= 0)
            {
                Console.WriteLine($"{contador}");
                contador--;
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
