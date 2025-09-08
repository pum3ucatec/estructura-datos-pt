using System;

public class Cola
{
    public Nodo Front { get; private set; }
    public Nodo Rear { get; private set; }
    private int CountElements;

    public Cola()
    {
        Front = null;
        Rear = null;
        CountElements = 0;
    }

    // Insertar un nombre
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
        CountElements++;
    }

    // Eliminar el primer elemento
    public string Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine(" La cola está vacía.");
            return null;
        }

        string value = Front.Name;
        Front = Front.Next;
        CountElements--;

        if (Front == null) Rear = null;

        return value;
    }

    // Eliminar por posición (1 = primer nodo)
    public string RemoveAt(int position)
    {
        if (IsEmpty())
        {
            Console.WriteLine(" La cola está vacía.");
            return null;
        }

        if (position < 1 || position > CountElements)
        {
            Console.WriteLine(" Posición inválida.");
            return null;
        }

        Nodo current = Front;
        string value;

        if (position == 1)
        {
            return Dequeue(); // ya tenemos el método para esto
        }

        Nodo prev = null;
        int index = 1;
        while (index < position)
        {
            prev = current;
            current = current.Next;
            index++;
        }

        value = current.Name;
        prev.Next = current.Next;

        if (current == Rear) Rear = prev;

        CountElements--;
        return value;
    }

    // Ver primer elemento
    public string Peek()
    {
        return IsEmpty() ? null : Front.Name;
    }

    // Buscar nombre y mostrar su posición
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

    // Verificar si contiene un nombre
    public bool Contains(string name)
    {
        return Search(name) != -1;
    }

    // Vaciar la cola
    public void Clear()
    {
        Front = null;
        Rear = null;
        CountElements = 0;
    }

    // Mostrar toda la cola
   public void View()
{
    Nodo current = this.Front;

    if (current == null)
    {
        Console.WriteLine(" La cola está vacía.");
        return;
    }

    Console.WriteLine(" Nombres que hay en la cola:");
    while (current != null)
    {
        Console.Write($"| {current.Name} ");
        current = current.Next;
    }
    Console.WriteLine("|");
}


    // Verificar si está vacía
    public bool IsEmpty()
    {
        return Front == null;
    }

    // Cantidad actual de elementos
    public int Count()
    {
        return CountElements;
    }
}
