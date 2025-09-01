using System;

class Ejercicio6
{
    static void Main()
    {
        int numero;
        do
        {
            Console.Write("Ingrese un número positivo: ");
            numero = int.Parse(Console.ReadLine());

            if (numero <= 0)
            {
                Console.WriteLine("Número no válido, debe ser positivo.");
            }

        } while (numero <= 0);

        Console.WriteLine($"Número válido ingresado: {numero}");
    }
}
