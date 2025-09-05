// Declarar un arreglo de 5 enteros 
// y asignarles valores.
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5];
        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;
        numeros[3] = 40;
        numeros[4] = 50;

        // Imprimir los valores del arreglo
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");
        }
    }
}
