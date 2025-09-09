// 7. Suma de 5 números ingresados por el usuario Pedir al usuario 5 números (uno por uno) y sumarlos usando for.

using System;

class ejercicio_7
{
	static void Main()
	{
		int suma = 0;

		for (int i = 1; i <= 5; i++) // i = variable base, del 1 al 5
		{
			Console.Write("Introduce el número " + i + ": ");
			int num = int.Parse(Console.ReadLine());
			suma += num; // num = número ingresado
		}
		Console.WriteLine("La suma es: " + suma);
	}
}