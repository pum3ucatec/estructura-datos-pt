using System;

class Program
{
    static void Main()
    {
        int i = 10; // empezamos en 10

        while (i >= 1) // mientras no lleguemos a 0
        {
            Console.WriteLine(i); // mostramos el número actual
            i--; // bajamos de uno en uno
        }

        Console.WriteLine("¡Despegue! 🚀");
    }
}
