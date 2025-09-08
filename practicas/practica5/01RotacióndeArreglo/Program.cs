//Escribe un programa que reciba un arreglo de enteros y un número `k`, y rote los elementos del arreglo hacia la derecha `k` posiciones.  
using System;

class Programa
{
    static void Main()
    {

        int[] arreglo = { 1, 2, 3, 4, 5 };
        int k = 2;

        int[] resultado = RotarDerecha(arreglo, k);


        Console.WriteLine("Arreglo rotado:");
        foreach (int num in resultado)
        {
            Console.Write(num + " ");
        }
    }

    static int[] RotarDerecha(int[] arreglo, int k)
    {
        int n = arreglo.Length;
        int[] rotado = new int[n];


        k = k % n;

        for (int i = 0; i < n; i++)
        {
            int nuevaPos = (i + k) % n;
            rotado[nuevaPos] = arreglo[i];
        }

        return rotado;
    }
}
