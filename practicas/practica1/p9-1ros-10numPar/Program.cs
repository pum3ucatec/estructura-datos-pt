// 9. Mostrar los primeros 10 números pares Mostrar en pantalla los primeros 10 números pares usando while.

using System;

class Ejercicio9
{
	static void Main()
	{
		int cont = 0;
		int num = 2;
		
		while (cont < 10)
		{
			Console.WriteLine(num);
			num += 2;
			cont++;
		}
	}
}
