/* 3. Suma de elementos
Dado un arreglo de enteros, calcula la suma de todos sus elementos. */

using System;

class Ejercicio3
{
	static void Main(string[] args)
	{
		int[] nums = { 5, 10, 15, 20 };
		int sum = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			sum += nums[i]; 
        }

		Console.WriteLine("Arreglo: [5, 10, 15, 20]");
		Console.WriteLine($"Suma: {sum}");
	}
}

