/* 5. Mayor y menor valor
Crea un programa que lea 8 números en un arreglo y muestre el mayor y el menor. */

using System;

class ejercicio_5
{
    static void Main()
    {
        int[] nums = new int[8]; // nums = numeros
		
        for (int i = 0; i < nums.Length; i++)
			nums[i] = LeerEntero($"Ingresa el número #{i + 1}: ");

        int my = nums[0]; // my = mayor
        int mn = nums[0]; // mn = menor

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > my) my = nums[i];
            if (nums[i] < mn) mn = nums[i];
        }

        Console.WriteLine($"Números: [{string.Join(", ", nums)}]");
        Console.WriteLine($"Mayor: {my}");
        Console.WriteLine($"Menor: {mn}");
    }
    static int LeerEntero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int valor))
                return valor;
            Console.WriteLine("Error, intenta de nuevo.");
        }
    }
}
