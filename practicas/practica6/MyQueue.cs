using System;

public class MyQueue
{
    private char[] array;
    private int size;
    private int front;
    private int rear;
    private int count;

    public MyQueue(int size)
    {
        this.size = size;
        array = new char[size];
        front = 0;
        rear = -1;
        count = 0;
    }

    // Agregar (Enqueue)
    public void Enqueue(char item)
    {
        if (IsFull())
        {
            Console.WriteLine("❌ La cola está llena.");
            return;
        }
        rear = (rear + 1) % size; // avance circular
        array[rear] = item;
        count++;
        Console.WriteLine($"✔️ Agregado: {item}");
    }

    // Eliminar (Dequeue)
    public char Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("❌ La cola está vacía.");
            return '\0';
        }
        char item = array[front];
        front = (front + 1) % size; // avance circular
        count--;
        return item;
    }

    // Ver frente (Peek)
    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("❌ La cola está vacía.");
            return '\0';
        }
        return array[front];
    }

    // Mostrar la cola
    public void Mostrar()
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
            Console.Write(array[index] + " ");
        }
        Console.WriteLine();
    }

    // Contar
    public int GetCount() => count;
    public int GetSize() => size;

    // Buscar
    public bool Contains(char item)
    {
        for (int i = 0; i < count; i++)
        {
            int index = (front + i) % size;
            if (array[index] == item) return true;
        }
        return false;
    }

    public bool IsEmpty() => count == 0;
    public bool IsFull() => count == size;
}