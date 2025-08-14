// 3. Tablas de multiplicar Solicitar un número al usuario y mostrar su tabla de multiplicar del 1 al 10 usando for.

using System;
class Ejercicio3
{
	static void Main()
	{
		Console.Write("Ingresa un número:");
		int num = int.Parse(Console.ReadLine());

		for (int a = 1; a <= 10; a++)
		{
			Console.WriteLine(num + " x " + a + " = " + (num * a));
		}
	}
}
