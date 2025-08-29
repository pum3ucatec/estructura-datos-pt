public class Cola
{
    private Nodo? Front { get; set; }
    private Nodo? Rear { get; set; }

    public Cola()
    {
        Front = null;
        Rear = null;
    }

    public void Enqueue(string valor)
    {
        Nodo nuevoNodo = new Nodo(valor);

        if (Rear == null)
        {
            Front = nuevoNodo;
            Rear = nuevoNodo;
        }
        else
        {
            Rear.Next = nuevoNodo;
            Rear = nuevoNodo;
        }
    }

    public string? Dequeue()
    {
        if (Front == null)
        {
            Console.WriteLine("La cola está vacía.");
            return null;
        }

        string dato = Front.Data;
        Front = Front.Next;

        if (Front == null)
            Rear = null;

        return dato;
    }

    public string? Peek()
    {
        if (Front == null)
        {
            Console.WriteLine("La cola está vacía.");
            return null;
        }

        return Front.Data;
    }

    public bool IsEmpty()
    {
        return Front == null;
    }

    public void View()
    {
        Nodo? actual = Front;
        Console.Write("Contenido de la cola: ");

        while (actual != null)
        {
            Console.Write(actual.Data + " -> ");
            actual = actual.Next;
        }

        Console.WriteLine("null");
    }

    public bool Contains(string valor)
    {
        Nodo? actual = Front;
        while (actual != null)
        {
            if (actual.Data == valor)
                return true;
            actual = actual.Next;
        }
        return false;
    }

    public void Clear()
    {
        Front = null;
        Rear = null;
        Console.WriteLine("La cola ha sido vaciada.");
    }

    public int Count()
    {
        int count = 0;
        Nodo? actual = Front;
        while (actual != null)
        {
            count++;
            actual = actual.Next;
        }
        return count;
    }
    public bool delete_p(int posicion)
    {
        if (posicion == 1)
        {
            Front = Front.Next;
            if (Front == null) // si se eliminó el único nodo
                Rear = null;
            return true;
        }

        // Recorremos hasta el nodo anterior al que queremos eliminar
        Nodo? actual = Front;
        int index = 1;
        while (actual != null && index < posicion - 1)
        {
            actual = actual.Next;
            index++;
        }

        // Si llegamos al final sin encontrar la posición
        if (actual == null || actual.Next == null)
        {
            Console.WriteLine("La posición no existe en la cola.");
            return false;
        }

        // Eliminamos el nodo apuntando al siguiente
        actual.Next = actual.Next.Next;

        // Si eliminamos el último nodo, actualizar Rear
        if (actual.Next == null)
            Rear = actual;

        return true;
    }
}
