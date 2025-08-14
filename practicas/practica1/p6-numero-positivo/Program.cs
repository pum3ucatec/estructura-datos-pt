// 6. Validar entrada con do-while Pedir al usuario que introduzca un número positivo y seguir pidiendo hasta que lo haga correctamente.

using System;

class Ejercicio6
{
	static void Main()
	{
		int num;
		do
		{
			Console.Write("Introduce un numero positivo: ");
			num = int.Parse(Console.ReadLine());
		} while (num <= 0);
		Console.WriteLine("Número válido: " + num);
	}
}