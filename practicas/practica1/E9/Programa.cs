using System;

class NumerosPares
{
    static void Main(string[] args)
    {
        int numero = 1;
        int contador = 0;

        Console.WriteLine("Los primeros 10 números pares son:");

        while (contador < 10)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine(numero);
                contador++;
            }
            numero++;
        }
    }
}
