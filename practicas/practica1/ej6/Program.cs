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

            if (numero <= 0)
                Console.WriteLine("¡Error! Debe ser positivo.");
        } while (numero <= 0);

        Console.WriteLine($"Número ingresado correctamente: {numero}");
    }
}
