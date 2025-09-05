using System;

class Program
{
    static void Main()
    {
        int numero;
        do
        {
            Console.Write("Ingrese un número positivo: ");
            numero = int.Parse(Console.ReadLine());
        } while (numero <= 0);

        Console.WriteLine($"Número válido ingresado: {numero}");
    }
}
