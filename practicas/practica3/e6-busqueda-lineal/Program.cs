// Dado un arreglo de 10 números, pide al usuario un número y determina si está dentro del arreglo 
//(imprime la posición si existe).  

using System;
class Ejercicio6
{
    static void Main()
    {
        int[] numeros = { 34, 56, 32, 12, 2, 89, 5, 6, 21, 4 };
        int buscar;

        bool encontrado = false;
        int posicion = -1;

        Console.WriteLine("Ingrese un número a buscar en el arreglo:");
        buscar = int.Parse(Console.ReadLine());

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscar)
            {
                encontrado = true;
                posicion = i;
                break;
            }

        }
        if (encontrado)
            Console.WriteLine("Número encontrado en la posición: " + posicion);
        else
            Console.WriteLine("Número no encontrado en el arreglo.");
    }
}
