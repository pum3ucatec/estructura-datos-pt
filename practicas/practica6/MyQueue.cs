using System;

public class QueueBase
{
    protected char[] elements;
    protected int size;
    protected int front;
    protected int rear;
    protected int count;

    public QueueBase(int n)
    {
        this.elements = new char[n];
        this.size = n;
        this.front = 0;
        this.rear = -1;
        this.count = 0;
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public bool IsFull()
    {
        return count == size;
    }

    // Devuelve la cantidad actual de elementos
    public int Count()
    {
        return count;
    }

    // Devuelve el tamaño máximo de la cola
    public int Length()
    {
        return size;
    }
}

public class MyQueue : QueueBase
{
    public MyQueue(int n) : base(n) { }

    // Enqueue (insertar)
    public void Enqueue(char element)
    {
        if (IsFull())
        {
            Console.WriteLine(" La cola está llena. No se puede insertar más datos.");
            return;
        }

        rear = (rear + 1) % size;
        elements[rear] = element;
        count++;
        Console.WriteLine($" Elemento '{element}' insertado en la cola.");
    }

    // Dequeue (eliminar)
    public char Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine(" La cola está vacía. No se puede eliminar.");
            return '\0';
        }

        char removed = elements[front];
        front = (front + 1) % size;
        count--;
        Console.WriteLine($" Elemento '{removed}' eliminado de la cola.");
        return removed;
    }

    // Peek (ver el frente sin eliminar)
    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine(" La cola está vacía.");
            return '\0';
        }
        return elements[front];
    }

    // Mostrar todos los elementos de la cola
    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine(" La cola está vacía.");
            return;
        }

        Console.Write(" Elementos en la cola: ");
        int index = front;
        for (int i = 0; i < count; i++)
        {
            Console.Write(elements[index] + " ");
            index = (index + 1) % size;
        }
        Console.WriteLine();
    }

    // Contains (verifica si un elemento existe en la cola)
    public bool Contains(char element)
    {
        if (IsEmpty())
            return false;

        int index = front;
        for (int i = 0; i < count; i++)
        {
            if (elements[index] == element)
                return true;
            index = (index + 1) % size;
        }
        return false;
    }
}
