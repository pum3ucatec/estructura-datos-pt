public class Cola
{
    public Nodo Front { get; private set; }
    public Nodo Rear { get; private set; }

    public Cola()
    {
        this.Front = null;
        this.Rear = null;
    }

    public void Enqueue(string name)
    {
        Nodo nodo = new Nodo(name);

        if (this.IsEmpty())
        {
            this.Front = nodo;
            this.Rear = nodo;
        }
        else
        {
            this.Rear.Next = nodo;
            this.Rear = nodo;
        }
    }

    public string Dequeue()
    {
        if (this.IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return null;
        }

        string value = this.Front.Name;
        this.Front = this.Front.Next;

        if (this.Front == null)
        {
            this.Rear = null;
        }

        return value;
    }

    public string Peek()
    {
        if (this.IsEmpty())
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

    public void Clear()
    {
        this.Front = null;
        this.Rear = null;
    }

    public int Count()
    {
        int count = 0;
        Nodo current = this.Front;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    public bool Contains(string name)
    {
        Nodo current = this.Front;
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
        if (this.IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Nodo current = this.Front;

        Console.WriteLine("Contenido de la cola:");
        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}