using System;
using System.Collections.Generic;

public class MyQueue
{
    private char[] Elements;
    private int Size;
    private int Front;
    private int Rear;
    private int Count;

public MyQueue(int n)
{
    Elements = new char[n];
    Size = n;
    Front = 0;
    Rear = 0;
    Count = 0;
}

    public void Mostrar()
{
    Console.WriteLine("\nElementos en la cola:");
    if (IsEmpty())
    {
        Console.WriteLine("(vacía)");
        return;
    }
    int limite = Front;
    for (int i = 0; i < Count; i++)
    {
        Console.Write($"{Elements[limite]} ");
        limite = (limite + 1) % Size;
    }
    Console.WriteLine();
}

    public void Enqueue(char value)
    {
        if (Count == Size)
        {
            Console.WriteLine("La cola está llena, no se puede insertar.");
            return;
        }

        Elements[Rear] = value;
        Rear = (Rear + 1) % Size;
        Count++;
        Console.WriteLine($"Se insertó {value} en la cola.");
    }

    public char Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía, no se puede eliminar.");
            return '\0';
        }

        char value = Elements[Front];
        Front = (Front + 1) % Size;
        Count--;
        Console.WriteLine($"Se eliminó {value} de la cola.");
        return value;
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

    public int CountElements()
    {
        return Count;
    }

    public int Length()
    {
        return Size;
    }

    public bool Contains(char value)
{
    int limite = Front;
    for (int i = 0; i < Count; i++)
    {
        if (Elements[limite] == value)
            return true;
        limite = (limite + 1) % Size;
    }
    return false;
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
