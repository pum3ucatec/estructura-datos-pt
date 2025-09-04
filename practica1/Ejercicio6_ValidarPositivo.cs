using System;

class Ejercicio6_ValidarPositivo
{
    static void Main()
    {
        int num;
        do
        {
            Console.Write("Ingrese un número positivo: ");
            num = int.Parse(Console.ReadLine());
        } while (num <= 0);

        Console.WriteLine("Número válido ingresado: " + num);
    }
}