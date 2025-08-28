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

    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No se puede eliminar ningún elemento.");
            return;
        }
        this.Front = this.Front.Next;
        if (this.Front == null)
        {
            this.Rear = null;
        }
    }

    public void Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
        }
        else
        {
            Console.WriteLine($"El frente de la cola es: {this.Front.Name}");
        }
    }

    public bool IsEmpty()
    {
        return this.Front == null;
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
    public void View()
    {
        Nodo current = this.Front;

        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }

    }
    public void Clear()
    {
            this.Front = null;
            this.Rear = null;
        }
        public int Contains(string name)
    {
        Nodo current = this.Front;
        int posicion = 0;
        while (current != null)
        {
            if (current.Name == name)
            {
                return posicion; // Retorna la posición donde se encontró
            }
            current = current.Next;
            posicion++;
        }
        return -1; // No se encontró
    }
    
   
}
