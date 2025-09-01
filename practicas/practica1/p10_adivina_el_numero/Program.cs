/* 10. Adivina el número (juego) El sistema genera un número aleatorio del 1 al 50. 
El usuario intenta adivinarlo. 
Usar do-while hasta que acierte, indicando si es mayor o menor. */

using System;

class ejercicio_10
{
	static void Main()
	{
		Random random = new Random();
		int num_al = random.Next(1, 51); //num_al = numero aleatorio
		int num_u; // num_u = numero ingresado por el usuario
		int ints = 0; //ints = intentos

		do 
		{
			Console.Write("Adivina el número entre 1 al 50: ");
			num_u = int.Parse(Console.ReadLine());
			ints++;

			if (num_u < num_al)
			{
				Console.WriteLine("Aumenta mas ");
			}
			else if (num_u > num_al)
			{
				Console.WriteLine("Un poco menos ");
			}
			else
			{
				Console.WriteLine($"Bien! Adivinaste el número {num_al} en {ints} intentos.");
			}

		} while (num_u != num_al);
	}
}
