using System;
using System.Collections.Generic;

class Pila
{
    private Stack<int> stack;
    public Pila()
    {
        stack = new Stack<int>();
    }

    public void Push(int valor)
    {
        stack.Push(valor);
        Console.WriteLine($"Se insertó: {valor}");
    }
	
    public void Pop()
	{
		if (stack.Count > 0)
		{
			int valor = stack.Pop();
			Console.WriteLine($"Se eliminó: {valor}");
		}
		else
		{
			Console.WriteLine("La pila está vacía. No se puede eliminar.");
		}
	}

    public int Peek()
    {
        if (stack.Count > 0)
        {
            return stack.Peek();
        }
        else
        {
            Console.WriteLine("La pila está vacía.");
            return -1;
        }
    }

    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    public void Clear()
    {
        stack.Clear();
        Console.WriteLine("La pila ha sido vaciada.");
    }

    public void Mostrar()
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        Console.WriteLine("Elementos de la pila (de arriba hacia abajo):");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }
}

class Principal
{
    static void Main(string[] args)
    {
        Pila pila = new Pila();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ PILA =====");
            Console.WriteLine("1. Mostrar pila");
            Console.WriteLine("2. Insertar (Push)");
            Console.WriteLine("3. Eliminar (Pop)");
            Console.WriteLine("4. Ver cima (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Limpiar pila (Clear)");
            Console.WriteLine("7. Insertar varios elementos (Push n)");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    pila.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el número a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        pila.Push(valor);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    pila.Pop();
                    break;
                case 4:
                    int cima = pila.Peek();
                    if (cima != -1)
                        Console.WriteLine($"Elemento en la cima: {cima}");
                    break;
                case 5:
                    Console.WriteLine(pila.IsEmpty() ? "La pila está vacía." : "La pila NO está vacía.");
                    break;
                case 6:
                    pila.Clear();
                    break;
                case 7:
                    Console.Write("Ingrese los números a insertar (separados por espacio): ");
                    string input = Console.ReadLine();
                    string[] valores = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string val in valores)
                    {
                        if (int.TryParse(val, out int num))
                        {
                            pila.Push(num);
                        }
                        else
                        {
                            Console.WriteLine($"'{val}' no es un número válido.");
                        }
                    }
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}