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