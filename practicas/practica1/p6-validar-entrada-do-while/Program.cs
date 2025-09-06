using System;
class Ejercicio6
{
    static void Main()
    {
        int num;

        do
        {
            Console.Write("Ingresa un número positivo: ");
            num = int.Parse(Console.ReadLine());
        } while (num <= 0);

        Console.WriteLine("Ingresaste: " + num);
    }
}