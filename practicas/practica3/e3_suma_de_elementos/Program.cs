/* 3. Suma de elementos
Dado un arreglo de enteros, calcula la suma de todos sus elementos. */

using System;

class ejercicio_3
{
    static void Main(string[] args)
    {
        Console.Write("¿Cuántos números desea sumar? ");
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        Console.Write("Arreglo: [");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i]);
            if (i < nums.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
        Console.WriteLine($"Suma: {sum}");
    }
}