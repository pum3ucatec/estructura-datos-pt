using System;

public class Cola
{
    public Nodo Front { get; private set; }
    public Nodo Rear { get; private set; }
    private int size;

    public Cola()
    {
        this.Front = null;
        this.Rear = null;
        this.size = 0;
    }

    public void Enqueue(string name)
    {
        Nodo nodo = new Nodo(name);
        if (IsEmpty())
        {
            this.Front = nodo;
            this.Rear = nodo;
        }
        else
        {
            this.Rear.Next = nodo;
            this.Rear = nodo;
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
            Rear = null; // la cola quedó vacía
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

    // Nueva operación: Buscar la posición de un elemento (1-based)
    public int Search(string name)
    {
        Nodo current = Front;
        int position = 1;
        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return position;
            }
            current = current.Next;
            position++;
        }
        return -1;
    }

    // Nueva operación: Eliminar un elemento por posición (1-based)
    public string RemoveAt(int position)
    {
        if (position < 1 || position > size)
        {
            Console.WriteLine("Posición fuera de rango.");
            return null;
        }

        Nodo current = Front;
        string value;

        if (position == 1)
        {
            value = Front.Name;
            Front = Front.Next;
            size--;
            if (Front == null) Rear = null;
            return value;
        }

        Nodo previous = null;
        int count = 1;
        while (count < position)
        {
            previous = current;
            current = current.Next;
            count++;
        }

        value = current.Name;
        previous.Next = current.Next;
        if (current == Rear) Rear = previous;
        size--;
        return value;
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
        Console.WriteLine();
    }
}
