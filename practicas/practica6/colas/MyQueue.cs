using System;

public class MyQueue
{
    private char[] Elements;
    private int Size;
    private int Front;
    private int Rear;
    private int Count;

    public MyQueue(int N)
    {
        this.Elements = new char[N];
        this.Size = N;
        this.Front = 0;
        this.Rear = -1;
        this.Count = 0;
    }

    public void Enqueue(char valor)
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está LLENA.");
            return;
        }
        Rear = (Rear + 1) % Size;
        Elements[Rear] = valor;
        Count++;
        Console.WriteLine($"Se ha introducido el valor: {valor}");
    }

    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está VACÍA.");
            return;
        }
        char valor = Elements[Front];
        Front = (Front + 1) % Size;
        Count--;
        Console.WriteLine($"Se ha eliminado el valor: {valor}");
    }

    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está VACÍA.");
            return '\0';
        }
        return Elements[Front];
    }

    public bool IsEmpty()
    {
        return Count == 0;
    }

    public bool IsFull()
    {
        return Count == Size;
    }

    public int GetCount()
    {
        return Count;
    }

    public int GetSize()
    {
        return Size;
    }

    public bool Contains(char valor)
    {
        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            if (Elements[index] == valor)
                return true;
        }
        return false;
    }

    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola actualmente está VACIA.");
            return;
        }
        Console.WriteLine("\nElementos en la cola:");
        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            Console.Write($"{Elements[index]} ");
        }
        Console.WriteLine();
    }
}