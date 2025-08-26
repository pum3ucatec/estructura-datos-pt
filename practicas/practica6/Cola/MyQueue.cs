using System;

public class MyQueue
{
    private int Size;       // Tamaño máximo de la cola
    private int Front;      // Índice del frente
    private int Rear;       // Índice del último elemento
    private int Count;      // Número de elementos en la cola
    private char[] Elements; // Arreglo para almacenar los elementos

    // Constructor: recibe el tamaño máximo de la cola
    public MyQueue(int N)
    {
        Size = N;
        Elements = new char[Size];
        Front = 0;
        Rear = -1;
        Count = 0;
    }

    public void Enqueue(char item)
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

    public char Dequeue()
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

    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return '\0';
        }
        return Elements[Front];
    }

    public int GetCount()
    {
        return Count;
    }

    public int GetSize()
    {
        return Size;
    }

    public bool Contains(char item)
    {
        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            if (Elements[index] == item) return true;
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

    public void Mostrar()
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
}