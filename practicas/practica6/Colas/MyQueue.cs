using System;

public class QueueBase
{
    protected char[] Elements;
    protected int Size;
    protected int Front;
    protected int Rear;
    protected int Count;

    public QueueBase(int N)
    {
        this.Elements = new char[N];
        this.Size = N;
        this.Front = 0;
        this.Rear = -1;
        this.Count = 0;
    }

    public bool IsEmpty()
    {
        return Count == 0;
    }

    public bool IsFull()
    {
        return Count == Size;
    }
}

public class MyQueue : QueueBase
{
    public MyQueue(int N) : base(N) { }

    public void Enqueue(char element)
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está llena. No se puede insertar más datos.");
            return;
        }

        Rear = (Rear + 1) % Size;
        Elements[Rear] = element;
        Count++;
        Console.WriteLine($"Elemento '{element}' insertado en la cola.");
    }

    public char Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No se puede eliminar.");
            return '\0';
        }

        char removed = Elements[Front];
        Front = (Front + 1) % Size;
        Count--;
        Console.WriteLine($"Elemento '{removed}' eliminado de la cola.");
        return removed;
    }

    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return '\0';
        }
        return Elements[Front];
    }

    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Console.WriteLine("\nElementos en la cola:");
        int index = Front;
        for (int i = 0; i < Count; i++)
        {
            Console.Write($"{Elements[index]} ");
            index = (index + 1) % Size;
        }
        Console.WriteLine();
    }
}
