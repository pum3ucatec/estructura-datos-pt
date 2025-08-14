// 8. Detectar número primo Usar un bucle for para determinar si un número ingresado por el usuario es primo o no.

using System;

class Ejercicio8
{
	static void Main()
	{
		Console.Write("Introduce un número para verificar si es primo: ");
		int num = int.Parse(Console.ReadLine());
		bool YPrimo = true;

		if (num <= 1)
		{
			YPrimo = false;
		}
		else
		{
			for (int a = 2; a <= num / 2; a++)
			{
				if (num % a == 0)
				{
					YPrimo = false;
					break;
				}
			}
		}
		if (YPrimo)
			Console.WriteLine(num + " es un número primo ");
		else
			Console.WriteLine("el " + num + " no es un número primo ") ;
	}
} 