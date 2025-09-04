using System;

public class Cola
{
	public Nodo? Front { get; private set; }
	public Nodo? Rear { get; private set; }
	private int count;

	public Cola()
	{
		this.Front = null;
		this.Rear = null;
		this.count = 0;
	}

	public void Enqueue(string name)
	{
		Nodo nodo = new Nodo(name);

		if (this.Front == null)
		{
			this.Front = nodo;
			this.Rear = nodo;
		}
		else
		{
			this.Rear!.Next = nodo;
			this.Rear = nodo;
		}

		count++;
	}

	public string? Dequeue()
	{
		if (this.Front == null)
		{
			Console.WriteLine("La cola está vacía, no se puede eliminar.");
			return null;
		}

		string eliminado = this.Front.Name;
		Console.WriteLine($"Persona eliminada: {eliminado}");

		this.Front = this.Front.Next;

		if (this.Front == null)
			this.Rear = null;

		count--;
		return eliminado;
	}

	public string? Peek()
	{
		if (this.Front == null)
		{
			Console.WriteLine("La cola está vacía.");
			return null;
		}
		return this.Front.Name;
	}

	public bool IsEmpty()
	{
		return this.Front == null;
	}

	public int GetCount()
	{
		return count;
	}

	public bool Contains(string name)
	{
		Nodo? current = this.Front;

		while (current != null)
		{
			if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
				return true;

			current = current.Next;
		}

		return false;
	}

	public void Clear()
	{
		this.Front = null;
		this.Rear = null;
		this.count = 0;
		Console.WriteLine("La cola ha sido vaciada.");
	}

	public void View()
	{
		if (this.Front == null)
		{
			Console.WriteLine("La cola está vacía.");
			return;
		}

		Nodo? current = this.Front;
		Console.Write("Cola: ");
		while (current != null)
		{
			Console.Write($"{current.Name} | ");
			current = current.Next;
		}
		Console.WriteLine();
	}

	public void Varios(string name)
	{
		string[] lista = name.Split(',');
		foreach (string n in lista)
		{
			Enqueue(n.Trim());
		}
	}
	public void Search(string name)
	{
		Nodo? current = this.Front;
		int position = 1;

		while (current != null)
		{
			if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
			{
				Console.WriteLine($"La persona '{name}' está en la posición {position} de la cola.");
				return;
			}
			current = current.Next;
			position++;
		}
		Console.WriteLine($"La persona '{name}' no se encuentra en la cola.");
	}

	public void Abandon(string name)
    {
        if (this.Front == null)
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        if (this.Front.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"La persona '{name}' abandonó la cola desde el frente.");
            this.Front = this.Front.Next;
            if (this.Front == null)
                this.Rear = null;
            count--;
            return;
        }

        Nodo? current = this.Front;
        Nodo? previous = null;

        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"La persona '{name}' abandonó la cola.");
                previous!.Next = current.Next;

                if (current == this.Rear)
                    this.Rear = previous;

                count--;
                return;
            }
            previous = current;
            current = current.Next;
        }
        Console.WriteLine($"La persona '{name}' no está en la cola.");
    }
}