using System;
using System.Collections.Generic;

public class Program
{
	public static void Main(string[] args)
	{
		List<int> numeros = new List<int>();
		bool salir = false;
		while (!salir)
		{
			Console.WriteLine("\n--- MENÚ ---");
			Console.WriteLine("1. Agregar elemento");
			Console.WriteLine("2. Eliminar elemento por valor");
			Console.WriteLine("3. Eliminar elemento por índice");
			Console.WriteLine("4. Contar elementos");
			Console.WriteLine("5. Insertar elemento en posición");
			Console.WriteLine("6. Buscar elemento");
			Console.WriteLine("7. Mostrar lista");
            Console.WriteLine("8. Eliminar alrededor de un valor");
			Console.WriteLine("9. Salir");
			Console.Write("Seleccione una opción: ");
			string opcion = Console.ReadLine() ?? "";

			switch (opcion)
			{
				case "1":
					Console.Write("Ingrese el número a agregar: ");
					if (int.TryParse(Console.ReadLine(), out int numAgregar))
					{
						numeros.Add(numAgregar);
						Console.WriteLine("Elemento agregado.");
					}
					else
						Console.WriteLine("Valor inválido.");
					break;
				case "2":
					Console.Write("Ingrese el número a eliminar: ");
					if (int.TryParse(Console.ReadLine(), out int numEliminar))
					{
						if (numeros.Remove(numEliminar))
							Console.WriteLine("Elemento eliminado.");
						else
							Console.WriteLine("Elemento no encontrado.");
					}
					else
						Console.WriteLine("Valor inválido.");
					break;
				case "3":
					Console.Write("Ingrese el índice a eliminar: ");
					if (int.TryParse(Console.ReadLine(), out int indiceEliminar))
					{
						if (indiceEliminar >= 0 && indiceEliminar < numeros.Count)
						{
							numeros.RemoveAt(indiceEliminar);
							Console.WriteLine("Elemento eliminado en índice " + indiceEliminar);
						}
						else
							Console.WriteLine("Índice fuera de rango.");
					}
					else
						Console.WriteLine("Valor inválido.");
					break;
				case "4":
					Console.WriteLine($"Cantidad de elementos: {numeros.Count}");
					break;
				case "5":
					Console.Write("Ingrese el número a insertar: ");
					if (int.TryParse(Console.ReadLine(), out int numInsertar))
					{
						Console.Write("Ingrese la posición donde insertar: ");
						if (int.TryParse(Console.ReadLine(), out int posicion))
						{
							if (posicion >= 0 && posicion <= numeros.Count)
							{
								numeros.Insert(posicion, numInsertar);
								Console.WriteLine("Elemento insertado.");
							}
							else
								Console.WriteLine("Posición fuera de rango.");
						}
						else
							Console.WriteLine("Valor de posición inválido.");
					}
					else
						Console.WriteLine("Valor inválido.");
					break;
				case "6":
					Console.Write("Ingrese el número a buscar: ");
					if (int.TryParse(Console.ReadLine(), out int numBuscar))
					{
						int indice = numeros.IndexOf(numBuscar);
						if (indice != -1)
							Console.WriteLine($"Elemento encontrado en índice {indice}.");
						else
							Console.WriteLine("Elemento no encontrado.");
					}
					else
						Console.WriteLine("Valor inválido.");
					break;
				case "7":
					Console.WriteLine("Contenido de la lista:");
					MostrarLista(numeros);
					break;
                case "8":
					Console.Write("Ingrese el número alrededor del cual eliminar: ");
					if (int.TryParse(Console.ReadLine(), out int valorAlrededor))
					{
						int indice = numeros.IndexOf(valorAlrededor);
						if (indice != -1)
						{
							// Eliminar el anterior si existe
							if (indice - 1 >= 0)
							{
								Console.WriteLine($"Eliminando el elemento anterior: {numeros[indice - 1]}");
								numeros.RemoveAt(indice - 1);
								indice--; // Ajustar el índice después de eliminar
							}
							// Eliminar el siguiente si existe
							if (indice + 1 < numeros.Count)
							{
								Console.WriteLine($"Eliminando el elemento siguiente: {numeros[indice + 1]}");
								numeros.RemoveAt(indice + 1);
							}
							Console.WriteLine("Elementos alrededor eliminados.");
						}
						else
						{
							Console.WriteLine("Valor no encontrado en la lista.");
						}
					}
					else
					{
						Console.WriteLine("Valor inválido.");
					}
					break;
				case "9":
					salir = true;
					break;
				default:
					Console.WriteLine("Opción inválida.");
					break;
			}
		}
	}

	public static void MostrarLista<T>(List<T> lista)
	{
		if (lista.Count == 0)
		{
			Console.WriteLine("(Lista vacía)");
			return;
		}
		foreach (T item in lista)
		{
			Console.WriteLine(item);
		}
	}
}