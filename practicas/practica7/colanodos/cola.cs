public class Cola
{
    public Nodo Front { get; private set; }
    public Nodo Rear { get; private set; }
    public int Count { get; private set; }

    public Cola()
    {
        this.Front = null;
        this.Rear = null;
        this.Count = 0;
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
            this.Rear.Next = nodo;
            this.Rear = nodo;
        }
        this.Count++;
    }

    public string Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No se puede eliminar.");
            return null;
        }

        string valorEliminado = Front.Name;
        Front = Front.Next;
        
        // Si la cola queda vacía después de eliminar
        if (Front == null)
        {
            Rear = null;
        }
        
        this.Count--;
        return valorEliminado;
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
        Count = 0;
        Console.WriteLine("Cola vaciada completamente.");
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

        Console.WriteLine("\n=== CONTENIDO DE LA COLA ===");
        Nodo current = Front;
        int posicion = 1;

        while (current != null)
        {
            Console.WriteLine($"{posicion}. {current.Name}");
            current = current.Next;
            posicion++;
        }
        Console.WriteLine($"Total de elementos: {Count}");
    }
}