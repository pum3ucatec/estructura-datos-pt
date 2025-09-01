// 8. Detectar número primo Usar un bucle for para determinar si un número ingresado por el usuario es primo o no.

using System;

class ejercicio_8
{
	static void Main()
	{
		Console.Write("Introduce un número para verificar si es primo: ");
		int num = int.Parse(Console.ReadLine());
		bool n_primo = true;

		if (num <= 1) // num = numero; no deja que sea menor a 1
		{
			n_primo = false; // n_primo = numero primo
		}
		else
		{
			for (int a = 2; a <= num / 2; a++)
			{
				if (num % a == 0)
				{
					n_primo = false;
					break;
				}
			}
		}
		if (n_primo)
			Console.WriteLine(num + " es un número primo ");
		else
			Console.WriteLine("el " + num + " no es un número primo ") ;
	}
} 