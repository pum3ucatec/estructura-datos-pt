using System;

public class Cola
{
    public Nodo Front { get; private set; }
    public Nodo Rear { get; private set; }
    private int count;
    private int capacity;

    public Cola(int capacity = int.MaxValue)
    {
        this.Front = null;
        this.Rear = null;
        this.count = 0;
        this.capacity = capacity;
    }

    public void Enqueue(string name)
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está llena.");
            return;
        }

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
        count++;
    }

    public string Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return null;
        }

        string value = this.Front.Name;
        this.Front = this.Front.Next;

        if (this.Front == null)
            this.Rear = null;

        count--;
        return value;
    }

    public void View()
    {
        if (IsEmpty())
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

    public string Peek()
    {
        if (IsEmpty())
            return null;
        return this.Front.Name;
    }

    public int Count()
    {
        return this.count;
    }

    public int Capacity()
    {
        return this.capacity;
    }

    public bool Contains(string name)
    {
        Nodo current = this.Front;
        while (current != null)
        {
            if (current.Name == name)
                return true;
            current = current.Next;
        }
        return false;
    }

    public bool IsEmpty()
    {
        return this.count == 0;
    }

    public bool IsFull()
    {
        return this.count >= this.capacity;
    }
}
