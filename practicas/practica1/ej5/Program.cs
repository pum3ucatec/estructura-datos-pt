using System;

class Program
{
    static void Main()
    {
        int i = 10;
        Console.WriteLine("Cuenta regresiva del 10 al 1:");
        while (i >= 1)
        {
            Console.WriteLine(i);
            i--;
        }
        Console.WriteLine("¡Despegue!");
    }
}
