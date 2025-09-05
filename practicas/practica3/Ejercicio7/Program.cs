using System;

class Programa7
{
    static void Main(string[] args)
    {
        int[] numeros = { 2, 5, 2, 8, 2, 9 };

        Console.Write("Ingrese un número: ");
        int buscado = int.Parse(Console.ReadLine());

        int contador = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscado)
            {
                contador++;
            }
        }

        Console.WriteLine($"El número {buscado} aparece {contador} veces");
    }
}
