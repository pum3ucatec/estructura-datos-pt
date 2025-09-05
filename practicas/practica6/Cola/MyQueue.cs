using System;
using System.Collections.Generic;

public class MyQueue
{
    private int[] Elements;
    private int Size;
    private int Front;
    private int Rear;
    private int Count;

    public MyQueue(int N)
    {
        this.Size = N;
        this.Elements = new int[N];
        this.Front = -1;
        this.Rear = -1;
        this.Count = 0;
    }

    public void Enqueue(int item)
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está llena. No se puede insertar más elementos.");
            return;
        }

        if (IsEmpty())
        {
            Front = 0;
            Rear = 0;
        }
        else
        {
            Rear = (Rear + 1) % Size;
        }

        Elements[Rear] = item;
        Count++;
        Console.WriteLine($"Se insertó el número {item} en la cola.");
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No se puede eliminar elementos.");
            return -1;
        }

        int removedItem = Elements[Front];
        
        if (Front == Rear)
        {
            Front = -1;
            Rear = -1;
        }
        else
        {
            Front = (Front + 1) % Size;
        }
        
        Count--;
        return removedItem;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No hay elementos para mostrar.");
            return -1;
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

    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No hay elementos para mostrar.");
            return;
        }

        Console.WriteLine("\n===== Elementos en la COLA =====");
        int current = Front;
        for (int i = 0; i < Count; i++)
        {
            Console.Write($"{Elements[current]} ");
            current = (current + 1) % Size;
        }
        Console.WriteLine();
    }

    // Nuevo método: Verifica si un elemento está en la cola
    public bool Contains(int item)
    {
        if (IsEmpty())
        {
            return false;
        }

        int current = Front;
        for (int i = 0; i < Count; i++)
        {
            if (Elements[current] == item)
            {
                return true;
            }
            current = (current + 1) % Size;
        }
        return false;
    }

    // Nuevo método: Retorna el número de elementos en la cola
    public int CurrentCount 
{
    get { return this.Count; }
}
}