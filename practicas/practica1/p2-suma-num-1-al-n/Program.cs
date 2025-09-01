using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero: ");
        int numero1 = Convert.ToInt16(Console.ReadLine());
        int i = 1;
        int resultado = 0;
        while (i <= numero1)
        {
            resultado += i;
            i++;
        }
        Console.WriteLine($"{resultado}");
    }
}
