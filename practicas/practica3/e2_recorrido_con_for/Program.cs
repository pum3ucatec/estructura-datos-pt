/* 2. Recorrido con for
Crea un arreglo de 10 números enteros y muéstralos en consola utilizando un ciclo for.

Explicación: El alumno debe entender cómo usar Length para recorrer el arreglo completo. */

using System;

class ejercicio_2
{
	static void Main(string[] args)
	{
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}
