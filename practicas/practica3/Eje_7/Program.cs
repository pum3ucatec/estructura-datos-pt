// En un arreglo de enteros, pedir un numero y ver cuantas veces se repite ese numero en el arreglo.
using System;   
class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4, 5, 3, 2, 1, 3 };
        Console.WriteLine("Ingrese un numero para buscar en el arreglo:");
        int numeroBuscado = int.Parse(Console.ReadLine());
        int contador = 0;

        foreach (int numero in numeros)
        {
            if (numero == numeroBuscado)
            {
                contador++;
            }
        }

        Console.WriteLine($"El numero {numeroBuscado} se repite {contador} veces en el arreglo.");
    }
}