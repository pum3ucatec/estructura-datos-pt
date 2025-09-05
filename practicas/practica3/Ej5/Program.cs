using System;

class Program
{
    static void Main()
    {
        int[] Numeros = new int[8];

        for (int i = 0; i < Numeros.Length; i++)
        {
            Console.Write("Ingresa el número #" + (i + 1) + ": ");
            Numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        int Mayor = Numeros[0];
        int Menor = Numeros[0];

        for (int i = 1; i < Numeros.Length; i++)
        {
            if (Numeros[i] > Mayor)
                Mayor = Numeros[i];
            if (Numeros[i] < Menor)
                Menor = Numeros[i];
        }

        Console.WriteLine("\nEl número mayor es: " + Mayor);
        Console.WriteLine("El número menor es: " + Menor);
    }
}


