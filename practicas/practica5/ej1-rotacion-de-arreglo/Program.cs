// rotacion Arreglo
/*
Escribe un programa que reciba un arreglo de enteros y un número `k`, y rote los elementos del arreglo hacia la derecha `k` posiciones.  
Ejemplo: `[1, 2, 3, 4, 5]` con `k=2` → `[4, 5, 1, 2, 3]`.
*/
// camii 
using System;

class Ejercicio1
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 2; // cantidad de rotaciones

        int n = arr.Length;
        k = k % n; // evitar rotaciones innecesarias

        int[] resultado = new int[n];

        // Colocar los últimos k elementos al inicio
        for (int i = 0; i < k; i++)
            resultado[i] = arr[n - k + i];

        // Colocar el resto después
        for (int i = k; i < n; i++)
            resultado[i] = arr[i - k];

        Console.WriteLine("La rotación: " + string.Join(", ", resultado));
    }
}
