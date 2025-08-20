using System;
namespace Tabla1al10
{

    class Program
    {

        static void Main()
        {
            Console.WriteLine("Elige una tabla de multiplicar: ");
            int table = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tabla del {table}");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = table * i; 
                Console.WriteLine($"{table} x {i} = {resultado}");
            }

        }
    }
        
}
