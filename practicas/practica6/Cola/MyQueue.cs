using System;

public class MyQueue
{
    private int size;
    private int front;
    private int rear;
    private int count;
    private char[] elements;

    public MyQueue(int n)
    {
        size = n;
        elements = new char[size];
        front = 0;
        rear = -1;
        count = 0;
    }
    
    public void Mostrar() // 1. Mostrar
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }
        Console.Write("Cola: ");
        for (int i = 0; i < count; i++)
        {
            int index = (front + i) % size;
            Console.Write(elements[index] + " ");
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
        rear = (rear + 1) % size;
        elements[rear] = item;
        count++;
    }

    public char Dequeue() // 3. Dequeue
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return '\0';
        }
        char value = elements[front];
        front = (front + 1) % size;
        count--;
        return value;
    }

    public char Peek() // 4. Peek
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return '\0';
        }
        return elements[front];
    }

    public int GetCount() // 5. count
    {
        return count;
    }

    public int GetSize() // 6. size
    {
        return size;
    }

    public bool Contains(char item) // 7. Contains
    {
        for (int i = 0; i < count; i++)
        {
            int index = (front + i) % size;
            if (elements[index] == item) return true;
        }
        return false;
    }

    public bool IsEmpty() // 8. IsEmpty
    {
        return count == 0;
    }

    public bool IsFull() // 9. IsFull
    {
        return count == size;
    }
}