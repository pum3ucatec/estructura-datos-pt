using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            int numero1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese el primer numero: ");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"El mayor {numero1}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"El mayor {numero2}");
            }
            else
            {
                Console.WriteLine("Los dos numeros son iguales!!!");
            }
        }
    }
}