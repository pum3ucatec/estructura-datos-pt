using System;
using System.Collections.Generic;

public class MyQueue
{
    private char[] Elements;
    private int Size;   // capacidad máxima
    private int Front;  // frente
    private int Rear;   // final
    private int Count;  // cantidad de elementos

    public MyQueue(int N)
    {
        this.Elements = new char[N];
        this.Size = N;
        this.Front = 0;
        this.Rear = -1;
        this.Count = 0;
    }

    // 1. Enqueue (insertar)
    public void Enqueue(char item)
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está llena, no se puede insertar.");
            return;
        }
        Rear = (Rear + 1) % Size;
        Elements[Rear] = item;
        Count++;
    }

    // 2. Dequeue (eliminar)
    public char Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía, no se puede eliminar.");
            return '\0';
        }
        char item = Elements[Front];
        Front = (Front + 1) % Size;
        Count--;
        return item;
    }

    // 3. Peek / Front (ver primer elemento)
    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return '\0';
        }
        return Elements[Front];
    }

    // 4. Count (cantidad actual)
    public int GetCount()
    {
        return Count;
    }

    // 5. Length / Size (capacidad máxima)
    public int GetSize()
    {
        return Size;
    }

    // 6. Contains (buscar elemento)
    public bool Contains(char item)
    {
        int i = Front;
        for (int c = 0; c < Count; c++)
        {
            if (Elements[i] == item)
                return true;
            i = (i + 1) % Size;
        }
        return false;
    }

    // 7. IsEmpty
    public bool IsEmpty()
    {
        return Count == 0;
    }

    // 8. IsFull
    public bool IsFull()
    {
        return Count == Size;
    }

    // Mostrar cola
    public void Mostrar()
    {
        Console.WriteLine("\nElementos en la cola:");
        int i = Front;
        for (int c = 0; c < Count; c++)
        {
            Console.Write($"{Elements[i]} ");
            i = (i + 1) % Size;
        }
        Console.WriteLine();
    }
}



                    