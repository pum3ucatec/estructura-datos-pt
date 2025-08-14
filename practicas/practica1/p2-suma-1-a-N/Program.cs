// 2. Sumar números del 1 al N Pedir al usuario un número N y sumar todos los números del 1 hasta N usando while.

using System;
class Ejercicio2
{
	static void Main()
	{
		Console.Write("Ingresa un número: ");
		int N = int.Parse(Console.ReadLine());

		int suma = 0;
		int a = 1;

		while (a <= N)
		{
			suma += a;
			a++;
		}

		Console.WriteLine("La suma del 1 al " + N + " es: " + suma);
	}
}


