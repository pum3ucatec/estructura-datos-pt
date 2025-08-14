/* 10. Adivina el número (juego) El sistema genera un número aleatorio del 1 al 50. 
El usuario intenta adivinarlo. 
Usar do-while hasta que acierte, indicando si es mayor o menor. */

using System;

class Ejercicio10
{
	static void Main()
	{
		Random random = new Random();
		int numAl = random.Next(1, 51); 
		int numU;
		int ints = 0;

		do 
		{
			Console.Write("Adivina el número entre 1 al 50: ");
			numU = int.Parse(Console.ReadLine());
			ints++;

			if (numU < numAl)
			{
				Console.WriteLine("Aumenta mas ");
			}
			else if (numU > numAl)
			{
				Console.WriteLine("Un poco menos ");
			}
			else
			{
				Console.WriteLine($"Bien! Adivinaste el número {numAl} en {ints} intentos.");
			}

		} while (numU != numAl);
	}
}
