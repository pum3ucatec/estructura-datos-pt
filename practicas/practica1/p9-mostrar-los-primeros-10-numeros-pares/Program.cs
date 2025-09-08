// Mostrar los primeros 10 números pares
// Mostrar en pantalla los primeros 10 números pares usando while.
// Camilaa

using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        int numero = 2;
        
        while (contador < 10)
        {
            Console.WriteLine(numero);
            numero += 2;
            contador++;
        }
    }
}
