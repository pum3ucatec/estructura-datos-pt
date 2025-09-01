// 5. Contador regresivo Mostrar una cuenta regresiva del 10 al 1 usando while.

using System;
class ejercicio_5
{
	static void Main()
	{
		int cont = 10; //cont = contador
		while (cont >= 0) // No deja que sea menor a 0
		{
			Console.WriteLine(cont);
			cont--;
		}
	}
}