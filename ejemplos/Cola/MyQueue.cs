using System;
using System.Collections.Generic;

public class MyQueue
{
    private char[] Elements;
    private int Size;
    private int Front;
    private int Rear;
    private int Count;

    public MyQueue(int N)
    {
        this.Elements = new char[2] { 'D', 'V' };
        this.Size = 2;
    }

    public void Mostrar()
    {
        Console.WriteLine("\nElementos en la cola:");
        for (int i = 0; i < this.Size; i++)
        {
            Console.Write($"{this.Elements[i]} ");
        }


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

    public bool IsEmpty()
    { 
        return Count == 0;
    }

}
