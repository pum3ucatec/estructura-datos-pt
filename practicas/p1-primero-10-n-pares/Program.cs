using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        int num = 2;

        while (contador < 10)
        {
            Console.WriteLine(num);
            num += 2;
            contador++;
        }
    }
}
