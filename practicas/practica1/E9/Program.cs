using System;

class NumerosPares
{
    static void Main()
    {
        int cantidadMostrada = 0; // cuántos pares se han mostrado
        int parActual = 2;        // primer número par

        while (cantidadMostrada < 10)
        {
            Console.WriteLine(parActual);
            parActual += 2;       // avanza al siguiente par
            cantidadMostrada++;
        }

        Console.WriteLine("Fin de la lista de pares.");
    }
}
