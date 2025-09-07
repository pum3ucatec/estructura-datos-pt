using System;

class ContadorNumeros
{
    static void Main(string[] args)
    {
        Console.WriteLine("NÚMEROS DEL 1 AL 10:");

        MostrarSecuencia(1, 10);
    }

    static void MostrarSecuencia(int inicio, int fin)
    {
        for (int numero = inicio; numero <= fin; numero++)
        {
            Console.WriteLine(numero);
        }
    }
}
