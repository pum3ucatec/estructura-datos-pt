using System;
class Ejercicio4
{
    static void Main()
    {
        int op;

        do
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar dos números");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("¡Hola!");
            }
            else if (op == 2)
            {
                Console.Write("Número 1: ");
                int num_1 = int.Parse(Console.ReadLine());
                Console.Write("Número 2: ");
                int num_2 = int.Parse(Console.ReadLine());
                Console.WriteLine("La suma es: " + (num_1 + num_2));
            }

        } while (op != 3);

        Console.WriteLine("Chauuuu");
    }
}