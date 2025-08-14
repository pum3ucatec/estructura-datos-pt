// 4. Menú con do-while Crear un pequeño menú que se repita hasta que el usuario elija salir (ejemplo: 1. Saludar, 2. Sumar, 3. Salir).

using System;
class Ejercicio4
{
	static void Main()
	{
		int op;
		do
		{
			Console.WriteLine("Menu");
			Console.WriteLine("1. Saludar");
			Console.WriteLine("2. Sumar");
			Console.WriteLine("3. Salir");

			Console.Write("Seleccione una opcion: ");
			op = int.Parse(Console.ReadLine());

			if (op == 1)
			{
				Console.WriteLine("Holis");
			}
			else if (op == 2)
			{
				Console.WriteLine("1er numero:");
				int x = int.Parse(Console.ReadLine());
				Console.WriteLine("2do numero:");
				int y = int.Parse(Console.ReadLine());
				Console.WriteLine("La suma es: " + (x + y));
			}
			else if (op != 3)
            {
                Console.WriteLine("Opción no válida, intente de nuevo");
            }

		} while (op != 3);
		Console.WriteLine("bye");

	}
}