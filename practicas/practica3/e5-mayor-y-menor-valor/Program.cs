// Crea un programa que lea 8 números en un arreglo y muestre el mayor y el menor. 
using System;
class Ejercicio5
{
    static void Main()
    {
        int[] numeros = { 23, 13, 54, 67, 3, 8, 1, 89 };
        int mayor, menor;

        mayor = numeros[0];
        menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
                mayor = numeros[i];
            if (numeros[i] < menor)
                menor = numeros[i];
        }

        Console.WriteLine("El mayor es:" + mayor);
        Console.WriteLine("El menor es:" + menor);
    }
}
