public class Cola
{
    public Nodo Front { get; private set; }
    public Nodo Rear { get; private set; }

    public Cola()
    {
        this.Front = null;
        this.Rear = null;
    }

    // 1. Insertar
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
    }

    // 2. Eliminar
    public string Dequeue()
    {
        if (this.Front == null) return null;
        string eliminado = this.Front.Name;
        this.Front = this.Front.Next;
        if (this.Front == null) this.Rear = null;
        return eliminado;
    }

    // 3. Ver frente
    public string Peek()
    {
        return this.Front != null ? this.Front.Name : null;
    }

    // 4. Verificar si está vacía
    public bool IsEmpty()
    {
        return this.Front == null;
    }

    // 5. Contar elementos
    public int Count()
    {
        int contador = 0;
        Nodo actual = this.Front;
        while (actual != null)
        {
            contador++;
            actual = actual.Next;
        }
        return contador;
    }

    // 6. Limpiar cola
    public void Clear()
    {
        this.Front = null;
        this.Rear = null;
    }

    // 7. Buscar
    public bool Contains(string name)
    {
        Nodo actual = this.Front;
        while (actual != null)
        {
            if (actual.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return true;
            actual = actual.Next;
        }
        return false;
    }

    // 8. Mostrar cola
    public void View()
    {
        if (this.Front == null)
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Nodo current = this.Front;
        Console.Write("Cola: ");
        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}