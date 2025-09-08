using System;

class ContadorRegresivo
{
    static void Main(string[] args)
    {
        IniciarConteo(10);
    }

    static void IniciarConteo(int inicio)
    {
        int contador = inicio;

        while (contador >= 1)
        {
            Console.WriteLine(contador);
            contador--;
        }
    }
}
