// 9. Mostrar los primeros 10 números pares Mostrar en pantalla los primeros 10 números pares usando while.

using System;

class ejercicio_9
{
	static void Main()
	{
		int cont = 0; // cont = contador
		int num = 2; // num = numero
		
		while (cont < 10) 
		{
			Console.WriteLine(num);
			num += 2;
			cont++;
		}
	}
}
