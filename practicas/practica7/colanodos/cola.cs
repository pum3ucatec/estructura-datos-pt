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

    // Nueva función: Eliminar por posición
    public string RemoveAt(int position)
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No se puede eliminar.");
            return null;
        }

        if (position < 1 || position > Count)
        {
            Console.WriteLine($"Posición inválida. Debe estar entre 1 y {Count}.");
            return null;
        }

        // Caso especial: eliminar el primer elemento (posición 1)
        if (position == 1)
        {
            return Dequeue();
        }

        Nodo current = Front;
        Nodo previous = null;
        int currentPosition = 1;

        // Buscar el nodo en la posición especificada
        while (current != null && currentPosition < position)
        {
            previous = current;
            current = current.Next;
            currentPosition++;
        }

        // Eliminar el nodo encontrado
        if (current != null)
        {
            string removedValue = current.Name;
            previous.Next = current.Next;

            // Si eliminamos el último elemento, actualizar Rear
            if (current.Next == null)
            {
                Rear = previous;
            }

            Count--;
            Console.WriteLine($"Elemento '{removedValue}' eliminado de la posición {position}.");
            return removedValue;
        }

        return null;
    }

    // Nueva función: Eliminar por búsqueda y mostrar posición
    public string RemoveAndFindPosition(string name, out int position)
    {
        position = -1;
        
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No se puede eliminar.");
            return null;
        }

        // Caso especial: eliminar el primer elemento
        if (Front.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
        {
            position = 1;
            return Dequeue();
        }

        Nodo current = Front;
        Nodo previous = null;
        int currentPosition = 1;

        // Buscar el elemento
        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                position = currentPosition;
                string removedValue = current.Name;
                previous.Next = current.Next;

                // Si eliminamos el último elemento, actualizar Rear
                if (current.Next == null)
                {
                    Rear = previous;
                }

                Count--;
                Console.WriteLine($"Elemento '{removedValue}' encontrado y eliminado de la posición {position}.");
                return removedValue;
            }

            previous = current;
            current = current.Next;
            currentPosition++;
        }

        Console.WriteLine($"Elemento '{name}' no encontrado en la cola.");
        return null;
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