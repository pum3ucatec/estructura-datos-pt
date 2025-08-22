using System;
class Pregunta1
{
    static void Main(string[] args)
    {
        // Definimos un arreglo de números del 1 al n, donde falta un número
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 9, 10 };

        int n = nums.Length + 1; 
        int esSum = n * (n + 1) / 2; // Suma esperada

        int acSum = 0; // Actual suma = acSum
        foreach (int num in nums)
        {
            acSum += num;
        }

        int encontrarnum = Sum - acSum;

        Console.WriteLine("El número que falta es: " + encontrarnum);
    }
}


