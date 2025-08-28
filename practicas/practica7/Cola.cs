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
        Console.WriteLine($"Elemento eliminado: {eliminado}");

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
}