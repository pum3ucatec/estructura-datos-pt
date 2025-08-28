using System;

public class Cola
{
    public Nodo Front { get; private set; }
    public Nodo Rear { get; private set; }
    private int size;

    public Cola()
    {
        Front = null;
        Rear = null;
        size = 0;
    }

    public void Enqueue(string name)
    {
        Nodo nodo = new Nodo(name);

        if (IsEmpty())
        {
            Front = nodo;
            Rear = nodo;
        }
        else
        {
            Rear.Next = nodo;
            Rear = nodo;
        }

        size++;
    }

    public string Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return null;
        }

        string value = Front.Name;
        Front = Front.Next;
        size--;

        if (Front == null)
        {
            Rear = null; // La cola quedó vacía
        }

        return value;
    }

    public string Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return null;
        }

        return Front.Name;
    }

    public bool IsEmpty()
    {
        return Front == null;
    }

    public void Clear()
    {
        Front = null;
        Rear = null;
        size = 0;
    }

    public int Count()
    {
        return size;
    }

    public bool Contains(string name)
    {
        Nodo current = Front;

        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            current = current.Next;
        }

        return false;
    }

    public void View()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Nodo current = Front;
        Console.WriteLine("Contenido de la cola:");

        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }

        Console.WriteLine(); // Salto de línea final
    }
}
