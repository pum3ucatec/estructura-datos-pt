using System;

class Program
{
    static void Main()
    {
        int contador = 0; // cuántos pares llevamos
        int numero = 2;   // empezamos desde el 2

        while (contador < 10)
        {
            Console.WriteLine(numero);
            numero += 2; // siguiente par
            contador++;  // sumamos uno a la cuenta de pares mostrados
        }
    }
}
