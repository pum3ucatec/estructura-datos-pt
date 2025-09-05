//Dado un arreglo de 10 números, pide al usuario un número y determina si está dentro del arreglo (imprime la posición si existe).  
using System;

class Program
{
    static void Main()
    {

        int[] numeros = { 12, 7, 25, 30, 17, 5, 42, 9, 33, 21 };

        Console.Write("Ingresa un número para buscar en el arreglo: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int buscado))
        {
            bool encontrado = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    Console.WriteLine($"El número {buscado} se encuentra en la posición {i} del arreglo.");
                    encontrado = true;
                    break; 
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"El número {buscado} no se encuentra en el arreglo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingresa un número entero.");
        }
    }
}
