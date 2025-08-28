public class Cola
{
    public Nodo Front { get; private set; }
    public Nodo Rear { get; private set; }
    private int CountElements;  // contador de elementos

    public Cola()
    {
        this.Front = null;
        this.Rear = null;
        this.CountElements = 0;
    }

    // Insertar al final
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
        CountElements++;
    }

    // Eliminar del frente
    public string Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("La cola está vacía.");

        string value = Front.Name;
        Front = Front.Next;

        if (Front == null)
            Rear = null;

        CountElements--;
        return value;
    }

    // Ver el primero sin eliminar
    public string Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("La cola está vacía.");
        return Front.Name;
    }

    // ¿Está vacía?
    public bool IsEmpty()
    {
        return Front == null;
    }

    // Cantidad de elementos
    public int Count()
    {
        return CountElements;
    }

    // Vaciar cola
    public void Clear()
    {
        Front = null;
        Rear = null;
        CountElements = 0;
    }

    // ¿Contiene un valor?
    public bool Contains(string name)
    {
        Nodo current = Front;
        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return true;
            current = current.Next;
        }
        return false;
    }

    // Mostrar elementos
    public void View()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Nodo current = this.Front;
        Console.Write("Elementos en la cola: ");
        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}