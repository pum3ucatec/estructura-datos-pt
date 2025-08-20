/* 1. Declaración e inicialización
Declara un arreglo de 5 enteros y asígnales valores manualmente. Luego imprime todos los valores en pantalla. */

using System;

class Ejercicio1
{
    static void Main()
    {
        int[] nums = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}

