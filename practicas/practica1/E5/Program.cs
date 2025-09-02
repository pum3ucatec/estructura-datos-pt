using System;

class EjercicioCinco
{
    static void Main()
    {
        int numero = 10; // valor inicial de la cuenta regresiva

        while (numero > 0) // se ejecuta mientras el número sea mayor a 0
        {
            Console.WriteLine(numero);
            numero--; // disminuye en cada ciclo
        }

        Console.WriteLine("¡Despegue!");
    }
}
