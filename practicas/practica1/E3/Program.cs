﻿// 3. Tablas de multiplicar Solicitar un número al usuario y mostrar su tabla de multiplicar del 1 al 10 usando for.

using System;
class ejercicio_3
{
	static void Main()
	{
		Console.Write("Ingresa un número:");
		int num = int.Parse(Console.ReadLine()); //N = Numero pedido desde consola

		for (int i = 1; i <= 10; i++) // i = variable base, del 1 a 10
		{
			Console.WriteLine(num + " x " + i + " = " + (num * i));
		}
	}
}