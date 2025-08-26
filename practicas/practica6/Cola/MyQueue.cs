using System;

public class MyQueue
{
    private int Size;
    private int Front;
    private int Rear;
    private int Count;
    private char[] Elements;

    public MyQueue(int N) //Constructor
    {
        Size = N;
        Elements = new char[Size];
        Front = 0;
        Rear = -1;
        Count = 0;
    }
    
    public void Mostrar() // 1. Mostrar
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }
        Console.Write("Cola: ");
        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            Console.Write(Elements[index] + " ");
        }
        Console.WriteLine();
    }

    public void Enqueue(char item) // 2. Enqueue
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está llena.");
            return;
        }
        Rear = (Rear + 1) % Size;
        Elements[Rear] = item;
        Count++;
    }

    public char Dequeue() // 3. Dequeue
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return '\0';
        }
        char value = Elements[Front];
        Front = (Front + 1) % Size;
        Count--;
        return value;
    }

    public char Peek() // 4. Peek
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return '\0';
        }
        return Elements[Front];
    }

    public int GetCount() // 5. Count
    {
        return Count;
    }

    public int GetSize() // 6. Size
    {
        return Size;
    }

    public bool Contains(char item) // 7. Contains
    {
        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            if (Elements[index] == item) return true;
        }
        return false;
    }

    public bool IsEmpty() // 8. IsEmpty
    {
        return Count == 0;
    }

    public bool IsFull() // 9. IsFull
    {
        return Count == Size;
    }
}