using System;

class ValidarPositivo
{
    static void Main(string[] args)
    {
        int numero = PedirNumeroPositivo();
        Console.WriteLine("Número válido ingresado: " + numero);
    }

    static int PedirNumeroPositivo()
    {
        int valor;
        do
        {
            Console.Write("Ingrese un número positivo: ");
            valor = int.Parse(Console.ReadLine());
        } while (valor <= 0);

        return valor;
    }
}
