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

    public void Enqueue(string name)
    {
        Nodo nodo = new Nodo(name);
        if (IsEmpty()) Front = Rear = nodo;
        else { Rear.Next = nodo; Rear = nodo; }
        CountElements++;
    }

    public string Dequeue()
    {
        if (IsEmpty()) { Console.WriteLine(" Cola vacía."); return null; }
        string value = Front.Name;
        Front = Front.Next;
        CountElements--;
        if (Front == null) Rear = null;
        return value;
    }

    public string RemoveAt(int position)
    {
        if (IsEmpty()) { Console.WriteLine(" Cola vacía."); return null; }
        if (position < 1 || position > CountElements) { Console.WriteLine(" Posición inválida."); return null; }

        if (position == 1) return Dequeue();

        Nodo current = Front;
        Nodo prev = null;
        int index = 1;

        while (index < position)
        {
            prev = current;
            current = current.Next;
            index++;
        }

        string value = current.Name;
        prev.Next = current.Next;
        if (current == Rear) Rear = prev;
        CountElements--;
        return value;
    }

    public string Peek() => IsEmpty() ? null : Front.Name;

    public int Search(string name)
    {
        Nodo current = Front;
        int pos = 1;
        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) return pos;
            current = current.Next;
            pos++;
        }
        return -1;
    }

    public bool Contains(string name) => Search(name) != -1;
    public void Clear() { Front = Rear = null; CountElements = 0; }
    public bool IsEmpty() => Front == null;
    public int Count() => CountElements;

    public void View()
    {
        if (IsEmpty()) { Console.WriteLine(" Cola vacía."); return; }
        Console.WriteLine(" Nombres en la cola:");
        Nodo current = Front;
        while (current != null)
        {
            Console.Write($"| {current.Name} ");
            current = current.Next;
        }
        Console.WriteLine("|");
    }
}
