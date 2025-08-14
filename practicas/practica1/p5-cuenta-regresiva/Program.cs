// 5. Contador regresivo Mostrar una cuenta regresiva del 10 al 1 usando while.

using System;
class Ejercicio5
{
	static void Main()
	{
		int cont = 10;
		while (cont >= 0)
		{
			Console.WriteLine(cont);
			cont--;
		}
	}
}