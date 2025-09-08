using System;
namespace suma_del_1_al_N
{
    class Program 
    {

        static void Main()
        {
            Console.WriteLine("Ingres un numero: ");
            int i = int.Parse(Console.ReadLine());

            int a = 0;

            for (int j = 1; j <= i; j++)
            {
                a += j;

            }

            Console.WriteLine($"la suma del 1 al {i} es: {a}");

        }
    }

}

