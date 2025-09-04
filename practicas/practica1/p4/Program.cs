using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("-- MINI MENÚ --");
            Console.WriteLine("1) Saludar");
            Console.WriteLine("2) Sumar 2 + 2");
            Console.WriteLine("3) Salir");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
                Console.WriteLine("¡Hola! 😄");
            else if (opcion == 2)
                Console.WriteLine("2 + 2 = 4");
            else if (opcion != 3)
                Console.WriteLine("Esa opción no existe.");

        } while (opcion != 3);

        Console.WriteLine("Saliste del mini menú.");
    }
}
