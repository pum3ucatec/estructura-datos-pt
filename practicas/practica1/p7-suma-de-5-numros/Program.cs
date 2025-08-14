// 7. Suma de 5 números ingresados por el usuario Pedir al usuario 5 números (uno por uno) y sumarlos usando for.

using System;

class Ejercicio7
{
	static void Main()
	{
		int suma = 0;

		for (int a = 1; a <= 5; a++)
		{
			Console.Write("Introduce el número " + a + ": ");
			int num = int.Parse(Console.ReadLine());
			suma += num;
		}
		Console.WriteLine("La suma es: " + suma);
	}
}