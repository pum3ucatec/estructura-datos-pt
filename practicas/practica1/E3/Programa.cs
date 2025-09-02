using System;

class TablaDeMultiplicar
{
    static void Main(string[] args)
    {
        Console.Write("INGRESE UN NÚMERO: ");
        int numero = int.Parse(Console.ReadLine());

        MostrarTabla(numero);
    }

    static void MostrarTabla(int n)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}
