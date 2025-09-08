//Dado un arreglo de enteros, pide un número y cuenta cuántas veces aparece en el arreglo.  

using System;

class Program
{
    static void Main()
    {
 
        int[] numeros = { 2, 5, 2, 8, 2, 9 };

        Console.Write("Ingresa un número para contar cuántas veces aparece: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int buscado))
        {
            int contador = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    contador++;
                }
            }

            Console.WriteLine($"\nEl número {buscado} aparece {contador} vez/veces en el arreglo.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingresa un número entero.");
        }
    }
}
